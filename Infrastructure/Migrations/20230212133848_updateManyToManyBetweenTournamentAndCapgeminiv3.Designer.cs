﻿// <auto-generated />
using System;
using Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(CapFootDatabaseContext))]
    [Migration("20230212133848_updateManyToManyBetweenTournamentAndCapgeminiv3")]
    partial class updateManyToManyBetweenTournamentAndCapgeminiv3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entites.Capgemini", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfTeams")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Capgeminis");

                    b.HasData(
                        new
                        {
                            Id = new Guid("002908a6-84b5-4b44-89ef-af09ed65f1a4"),
                            City = "Casablanca",
                            Country = "Morocco",
                            DateCreated = new DateTime(2023, 2, 12, 14, 38, 47, 791, DateTimeKind.Local).AddTicks(6684),
                            DateCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2023, 2, 12, 14, 38, 47, 791, DateTimeKind.Local).AddTicks(6745),
                            Name = "TS",
                            NumberOfTeams = 16
                        },
                        new
                        {
                            Id = new Guid("274bc7f6-c1a7-42ec-bc03-3be2c70421a9"),
                            City = "Rabat",
                            Country = "Morocco",
                            DateCreated = new DateTime(2023, 2, 12, 14, 38, 47, 791, DateTimeKind.Local).AddTicks(6768),
                            DateCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2023, 2, 12, 14, 38, 47, 791, DateTimeKind.Local).AddTicks(6771),
                            Name = "TS",
                            NumberOfTeams = 8
                        });
                });

            modelBuilder.Entity("Domain.Entites.CapgeminiTournament", b =>
                {
                    b.Property<Guid>("tournamentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("capgeminiId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("tournamentId", "capgeminiId");

                    b.HasIndex("capgeminiId");

                    b.ToTable("CapgeminiTournaments");
                });

            modelBuilder.Entity("Domain.Entites.Groupe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TournamentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Domain.Entites.Tournament", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CountryOrganisation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isFinished")
                        .HasColumnType("bit");

                    b.Property<bool>("isSignUpCompleted")
                        .HasColumnType("bit");

                    b.Property<bool>("isStarted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Tournaments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("eba9ffc2-46bc-45e4-916f-29ab4d8b5cd5"),
                            CountryOrganisation = "Maroc",
                            DateCreated = new DateTime(2023, 2, 12, 14, 38, 47, 792, DateTimeKind.Local).AddTicks(2015),
                            DateModified = new DateTime(2023, 2, 12, 14, 38, 47, 792, DateTimeKind.Local).AddTicks(2046),
                            Name = "Tournoi Ramadan",
                            isFinished = false,
                            isSignUpCompleted = false,
                            isStarted = false
                        });
                });

            modelBuilder.Entity("Domain.Entites.CapgeminiTournament", b =>
                {
                    b.HasOne("Domain.Entites.Capgemini", "capgemini")
                        .WithMany("capgeminiTournament")
                        .HasForeignKey("capgeminiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entites.Tournament", "tournament")
                        .WithMany("capgeminiTournament")
                        .HasForeignKey("tournamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("capgemini");

                    b.Navigation("tournament");
                });

            modelBuilder.Entity("Domain.Entites.Capgemini", b =>
                {
                    b.Navigation("capgeminiTournament");
                });

            modelBuilder.Entity("Domain.Entites.Tournament", b =>
                {
                    b.Navigation("capgeminiTournament");
                });
#pragma warning restore 612, 618
        }
    }
}