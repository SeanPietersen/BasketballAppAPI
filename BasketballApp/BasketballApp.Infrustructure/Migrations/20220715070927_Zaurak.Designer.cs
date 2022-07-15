﻿// <auto-generated />
using System;
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
    [Migration("20220715070927_Zaurak")]
    partial class Zaurak
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BasketballApp.Domain.Coach", b =>
                {
                    b.Property<int>("CoachId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CoachId"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsQualified")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<int>("YearsOfExperience")
                        .HasColumnType("int");

                    b.HasKey("CoachId");

                    b.HasIndex("TeamId");

                    b.ToTable("Coaches");

                    b.HasData(
                        new
                        {
                            CoachId = 1,
                            FirstName = "Steve",
                            IsQualified = true,
                            LastName = "Kerr",
                            Rank = 1,
                            TeamId = 3,
                            YearsOfExperience = 10
                        },
                        new
                        {
                            CoachId = 2,
                            FirstName = "Mike",
                            IsQualified = true,
                            LastName = "Brown",
                            Rank = 2,
                            TeamId = 3,
                            YearsOfExperience = 5
                        },
                        new
                        {
                            CoachId = 3,
                            FirstName = "Frank",
                            IsQualified = false,
                            LastName = "Vogel",
                            Rank = 1,
                            TeamId = 1,
                            YearsOfExperience = 2
                        },
                        new
                        {
                            CoachId = 4,
                            FirstName = "Mike",
                            IsQualified = true,
                            LastName = "Penberthy",
                            Rank = 2,
                            TeamId = 3,
                            YearsOfExperience = 15
                        },
                        new
                        {
                            CoachId = 5,
                            FirstName = "Tyronn",
                            IsQualified = true,
                            LastName = "Lue",
                            Rank = 1,
                            TeamId = 2,
                            YearsOfExperience = 15
                        },
                        new
                        {
                            CoachId = 6,
                            FirstName = "Jason",
                            IsQualified = false,
                            LastName = "Powell",
                            Rank = 3,
                            TeamId = 2,
                            YearsOfExperience = 1
                        },
                        new
                        {
                            CoachId = 7,
                            FirstName = "Mike",
                            IsQualified = true,
                            LastName = "Penberthy",
                            Rank = 2,
                            TeamId = 3,
                            YearsOfExperience = 15
                        },
                        new
                        {
                            CoachId = 8,
                            FirstName = "Kevin",
                            IsQualified = false,
                            LastName = "Young",
                            Rank = 2,
                            TeamId = 4,
                            YearsOfExperience = 1
                        },
                        new
                        {
                            CoachId = 9,
                            FirstName = "Erik",
                            IsQualified = true,
                            LastName = "Spoelstra",
                            Rank = 1,
                            TeamId = 6,
                            YearsOfExperience = 5
                        },
                        new
                        {
                            CoachId = 10,
                            FirstName = "Nate",
                            IsQualified = false,
                            LastName = "McMillan",
                            Rank = 1,
                            TeamId = 8,
                            YearsOfExperience = 2
                        },
                        new
                        {
                            CoachId = 11,
                            FirstName = "Todd",
                            IsQualified = false,
                            LastName = "Campbell",
                            Rank = 3,
                            TeamId = 9,
                            YearsOfExperience = 1
                        },
                        new
                        {
                            CoachId = 12,
                            FirstName = "Ime",
                            IsQualified = false,
                            LastName = "Udoka",
                            Rank = 1,
                            TeamId = 10,
                            YearsOfExperience = 4
                        },
                        new
                        {
                            CoachId = 13,
                            FirstName = "Ben",
                            IsQualified = true,
                            LastName = "Sullivan",
                            Rank = 2,
                            TeamId = 10,
                            YearsOfExperience = 6
                        });
                });

            modelBuilder.Entity("BasketballApp.Domain.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlayerId"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PlayerHeight")
                        .HasColumnType("float");

                    b.Property<double>("PlayerWeight")
                        .HasColumnType("float");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            PlayerId = 1,
                            DateOfBirth = new DateTime(1998, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Stephan",
                            LastName = "Curry",
                            PlayerHeight = 1.8899999999999999,
                            PlayerWeight = 83.900000000000006,
                            TeamId = 3
                        },
                        new
                        {
                            PlayerId = 2,
                            DateOfBirth = new DateTime(1984, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Lebron",
                            LastName = "James",
                            PlayerHeight = 2.1000000000000001,
                            PlayerWeight = 113.40000000000001,
                            TeamId = 1
                        },
                        new
                        {
                            PlayerId = 3,
                            DateOfBirth = new DateTime(1991, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Kawhi",
                            LastName = "Leonard",
                            PlayerHeight = 2.04,
                            PlayerWeight = 102.09999999999999,
                            TeamId = 2
                        },
                        new
                        {
                            PlayerId = 4,
                            DateOfBirth = new DateTime(1996, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Devin",
                            LastName = "Booker",
                            PlayerHeight = 1.98,
                            PlayerWeight = 93.400000000000006,
                            TeamId = 4
                        },
                        new
                        {
                            PlayerId = 5,
                            DateOfBirth = new DateTime(1995, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Nikola",
                            LastName = "Jokic",
                            PlayerHeight = 2.2000000000000002,
                            PlayerWeight = 128.80000000000001,
                            TeamId = 5
                        },
                        new
                        {
                            PlayerId = 6,
                            DateOfBirth = new DateTime(1989, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jimmy",
                            LastName = "Butler",
                            PlayerHeight = 2.04,
                            PlayerWeight = 104.3,
                            TeamId = 6
                        },
                        new
                        {
                            PlayerId = 7,
                            DateOfBirth = new DateTime(1994, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Gary",
                            LastName = "Harris",
                            PlayerHeight = 1.95,
                            PlayerWeight = 95.299999999999997,
                            TeamId = 7
                        },
                        new
                        {
                            PlayerId = 8,
                            DateOfBirth = new DateTime(1998, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Trey",
                            LastName = "Young",
                            PlayerHeight = 1.8600000000000001,
                            PlayerWeight = 74.400000000000006,
                            TeamId = 8
                        },
                        new
                        {
                            PlayerId = 9,
                            DateOfBirth = new DateTime(1997, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Lonzo",
                            LastName = "Ball",
                            PlayerHeight = 2.0099999999999998,
                            PlayerWeight = 86.200000000000003,
                            TeamId = 9
                        },
                        new
                        {
                            PlayerId = 10,
                            DateOfBirth = new DateTime(1998, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jayson",
                            LastName = "Tatum",
                            PlayerHeight = 2.0699999999999998,
                            PlayerWeight = 95.299999999999997,
                            TeamId = 10
                        });
                });

            modelBuilder.Entity("BasketballApp.Domain.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            TeamId = 1,
                            Name = "Los Angeles Lakers",
                            State = "Claifornia"
                        },
                        new
                        {
                            TeamId = 2,
                            Name = "Los Angeles Clippers",
                            State = "Claifornia"
                        },
                        new
                        {
                            TeamId = 3,
                            Name = "Golden State Warriors",
                            State = "Claifornia"
                        },
                        new
                        {
                            TeamId = 4,
                            Name = "Phoenix Suns",
                            State = "Arizona"
                        },
                        new
                        {
                            TeamId = 5,
                            Name = "Denvor Nuggets",
                            State = "Colorado"
                        },
                        new
                        {
                            TeamId = 6,
                            Name = "Miami Heat",
                            State = "Florida"
                        },
                        new
                        {
                            TeamId = 7,
                            Name = "Orlando Magic",
                            State = "Florida"
                        },
                        new
                        {
                            TeamId = 8,
                            Name = "Atlanta Hawks",
                            State = "Georgia"
                        },
                        new
                        {
                            TeamId = 9,
                            Name = "Chicago Bulls",
                            State = "Illinois"
                        },
                        new
                        {
                            TeamId = 10,
                            Name = "Boston Celtics",
                            State = "Massachusetts"
                        });
                });

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

            modelBuilder.Entity("BasketballApp.Domain.Coach", b =>
                {
                    b.HasOne("BasketballApp.Domain.Team", "Team")
                        .WithMany("Coaches")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("BasketballApp.Domain.Player", b =>
                {
                    b.HasOne("BasketballApp.Domain.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("BasketballApp.Domain.Team", b =>
                {
                    b.Navigation("Coaches");

                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
