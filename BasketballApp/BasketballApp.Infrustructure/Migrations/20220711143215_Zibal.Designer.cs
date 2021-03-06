// <auto-generated />
using BasketballApp.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BasketballApp.Infrustructure.Migrations
{
    [DbContext(typeof(BasketballAppContext))]
    [Migration("20220711143215_Zibal")]
    partial class Zibal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BasketballApp.Domain.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "seanpietersen7@gmail.com",
                            FirstName = "Sean",
                            LastName = "Pietersen",
                            Password = "Sean1234"
                        },
                        new
                        {
                            UserId = 2,
                            Email = "jase.pietersen7@gmail.com",
                            FirstName = "Jason",
                            LastName = "Pietersen",
                            Password = "Jason1234"
                        },
                        new
                        {
                            UserId = 3,
                            Email = "pfpietersen@gmail.com",
                            FirstName = "Percival",
                            LastName = "Pietersen",
                            Password = "Percy1234"
                        },
                        new
                        {
                            UserId = 4,
                            Email = "cmpietersen7@gmail.com",
                            FirstName = "Claudia",
                            LastName = "Pietersen",
                            Password = "Claudia1234"
                        },
                        new
                        {
                            UserId = 5,
                            Email = "rumerkerm@gmail.com",
                            FirstName = "Rumer",
                            LastName = "Manis",
                            Password = "Rumer1234"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
