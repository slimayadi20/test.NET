﻿// <auto-generated />
using System;
using AM.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AMContext))]
    [Migration("20230512140702_slim")]
    partial class slim
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cinema", b =>
                {
                    b.Property<int>("cinemaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cinemaId"));

                    b.Property<string>("localisation")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("cinemaId");

                    b.ToTable("Cinema");
                });

            modelBuilder.Entity("Film", b =>
                {
                    b.Property<int>("filmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("filmId"));

                    b.Property<DateTime>("dateRealisation")
                        .HasColumnType("datetime2");

                    b.Property<double>("duree")
                        .HasColumnType("float");

                    b.Property<double>("prix")
                        .HasColumnType("float");

                    b.Property<string>("titre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("typeFilm")
                        .HasColumnType("int");

                    b.HasKey("filmId");

                    b.ToTable("Film");
                });

            modelBuilder.Entity("FilmSalle", b =>
                {
                    b.Property<int>("filmsfilmId")
                        .HasColumnType("int");

                    b.Property<int>("sallesidSalle")
                        .HasColumnType("int");

                    b.HasKey("filmsfilmId", "sallesidSalle");

                    b.HasIndex("sallesidSalle");

                    b.ToTable("FilmSalle");
                });

            modelBuilder.Entity("Projection", b =>
                {
                    b.Property<int>("filmFk")
                        .HasColumnType("int");

                    b.Property<int>("salleFk")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateProjection")
                        .HasColumnType("datetime2");

                    b.Property<int>("filmId")
                        .HasColumnType("int");

                    b.Property<int>("salleidSalle")
                        .HasColumnType("int");

                    b.Property<string>("typeProjection")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("filmFk", "salleFk", "dateProjection");

                    b.HasIndex("filmId");

                    b.HasIndex("salleidSalle");

                    b.ToTable("Projection");
                });

            modelBuilder.Entity("Salle", b =>
                {
                    b.Property<int>("idSalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idSalle"));

                    b.Property<int>("cinemaId")
                        .HasColumnType("int");

                    b.Property<int>("nbPlaces")
                        .HasColumnType("int");

                    b.Property<int>("numero")
                        .HasColumnType("int");

                    b.HasKey("idSalle");

                    b.HasIndex("cinemaId");

                    b.ToTable("Salle");
                });

            modelBuilder.Entity("FilmSalle", b =>
                {
                    b.HasOne("Film", null)
                        .WithMany()
                        .HasForeignKey("filmsfilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Salle", null)
                        .WithMany()
                        .HasForeignKey("sallesidSalle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Projection", b =>
                {
                    b.HasOne("Film", "film")
                        .WithMany()
                        .HasForeignKey("filmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Salle", "salle")
                        .WithMany()
                        .HasForeignKey("salleidSalle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("film");

                    b.Navigation("salle");
                });

            modelBuilder.Entity("Salle", b =>
                {
                    b.HasOne("Cinema", "cinema")
                        .WithMany("salles")
                        .HasForeignKey("cinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cinema");
                });

            modelBuilder.Entity("Cinema", b =>
                {
                    b.Navigation("salles");
                });
#pragma warning restore 612, 618
        }
    }
}
