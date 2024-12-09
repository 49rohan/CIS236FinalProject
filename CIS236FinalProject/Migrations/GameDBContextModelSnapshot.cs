﻿// <auto-generated />
using System;
using CIS236FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CIS236FinalProject.Migrations
{
    [DbContext(typeof(GameDBContext))]
    partial class GameDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CIS236FinalProject.Models.Badge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Badges");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Awarded for winning their first battle",
                            Name = "First Victory",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("CIS236FinalProject.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Attack")
                        .HasColumnType("int");

                    b.Property<int>("Defense")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Attack = 50,
                            Defense = 40,
                            Name = "Warrior",
                            Speed = 30,
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            Attack = 60,
                            Defense = 50,
                            Name = "Knight",
                            Speed = 40,
                            TeamId = 2
                        });
                });

            modelBuilder.Entity("CIS236FinalProject.Models.Division", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Divisions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bronze"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Silver"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Gold"
                        });
                });

            modelBuilder.Entity("CIS236FinalProject.Models.Move", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Power")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("Moves");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CharacterId = 1,
                            Name = "Slash",
                            Power = 20
                        },
                        new
                        {
                            Id = 2,
                            CharacterId = 2,
                            Name = "DoubleSlash",
                            Power = 40
                        });
                });

            modelBuilder.Entity("CIS236FinalProject.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("DivisionId")
                        .HasColumnType("int");

                    b.Property<int>("MaxCharacters")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DivisionId");

                    b.HasIndex("UserId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("CIS236FinalProject.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "John"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Adam"
                        });
                });

            modelBuilder.Entity("CIS236FinalProject.Models.Badge", b =>
                {
                    b.HasOne("CIS236FinalProject.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CIS236FinalProject.Models.Character", b =>
                {
                    b.HasOne("CIS236FinalProject.Models.Team", "Team")
                        .WithMany("Characters")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("CIS236FinalProject.Models.Move", b =>
                {
                    b.HasOne("CIS236FinalProject.Models.Character", "Character")
                        .WithMany("Moves")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("CIS236FinalProject.Models.Team", b =>
                {
                    b.HasOne("CIS236FinalProject.Models.Division", null)
                        .WithMany("Teams")
                        .HasForeignKey("DivisionId");

                    b.HasOne("CIS236FinalProject.Models.User", "User")
                        .WithMany("Teams")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CIS236FinalProject.Models.Character", b =>
                {
                    b.Navigation("Moves");
                });

            modelBuilder.Entity("CIS236FinalProject.Models.Division", b =>
                {
                    b.Navigation("Teams");
                });

            modelBuilder.Entity("CIS236FinalProject.Models.Team", b =>
                {
                    b.Navigation("Characters");
                });

            modelBuilder.Entity("CIS236FinalProject.Models.User", b =>
                {
                    b.Navigation("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
