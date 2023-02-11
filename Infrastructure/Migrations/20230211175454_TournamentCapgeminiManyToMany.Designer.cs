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
    [Migration("20230211175454_TournamentCapgeminiManyToMany")]
    partial class TournamentCapgeminiManyToMany
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CapgeminiTournament", b =>
                {
                    b.Property<Guid>("CapgeminisId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TournamentsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CapgeminisId", "TournamentsId");

                    b.HasIndex("TournamentsId");

                    b.ToTable("CapgeminiTournament");
                });

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
                            Id = new Guid("7cc4bb38-838f-4d3d-9248-a6c9c3f18086"),
                            City = "Casablanca",
                            Country = "Morocco",
                            DateCreated = new DateTime(2023, 2, 11, 18, 54, 53, 726, DateTimeKind.Local).AddTicks(6391),
                            DateCreation = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2023, 2, 11, 18, 54, 53, 726, DateTimeKind.Local).AddTicks(6459),
                            Name = "TS",
                            NumberOfTeams = 0
                        });
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

                    b.HasKey("Id");

                    b.ToTable("Tournaments");
                });

            modelBuilder.Entity("CapgeminiTournament", b =>
                {
                    b.HasOne("Domain.Entites.Capgemini", null)
                        .WithMany()
                        .HasForeignKey("CapgeminisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entites.Tournament", null)
                        .WithMany()
                        .HasForeignKey("TournamentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
