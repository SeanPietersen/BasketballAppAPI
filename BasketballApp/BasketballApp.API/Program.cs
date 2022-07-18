using AutoMapper;
using BasketballApp.Application.Contracts;
using BasketballApp.Application.Profiles;
using BasketballApp.Application.Services;
using BasketballApp.Infrastructure.DbContexts;
using BasketballApp.Infrastructure.Services.Repositories;
using BasketballApp.Infrustructure.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager Configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IUserContract, UserContract>();
builder.Services.AddTransient<ITeamContract, TeamContract>();
builder.Services.AddTransient<IPlayerContract, PlayerContract>();
builder.Services.AddTransient<IJwtService, JwtService>();

builder.Services.AddDbContext<BasketballAppContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("BasketballAppDBConnectionString")));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ITeamRepository, TeamRepository>();
builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();


var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new UserProfile());
    mc.AddProfile(new TeamProfile());
    mc.AddProfile(new PlayerProfile());
});

IMapper mapper = mapperConfig.CreateMapper();

builder.Services.AddSingleton(mapper);

builder.Services.AddAuthentication("Bearer")
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new()
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = Configuration["Authentication:Issuer"],
            ValidAudience = Configuration["Authentication:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.ASCII.GetBytes(Configuration["Authentication:SecretForKey"]))
        };

    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();

app.UseCors(x => x
   .AllowAnyOrigin()
   .AllowAnyMethod()
   .AllowAnyHeader());

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
