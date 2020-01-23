﻿// <auto-generated />
using RS1_2017_09_11.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace RS1_2017_09_11.Migrations
{
    [DbContext(typeof(MojContext))]
    partial class MojContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ispit_2017_09_11_DotnetCore.EntityModels.DodjeljenPredmet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OdjeljenjeStavkaId");

                    b.Property<int>("PredmetId");

                    b.Property<int>("ZakljucnoKrajGodine");

                    b.Property<int>("ZakljucnoPolugodiste");

                    b.HasKey("Id");

                    b.HasIndex("OdjeljenjeStavkaId");

                    b.HasIndex("PredmetId");

                    b.ToTable("DodjeljenPredmet");
                });

            modelBuilder.Entity("Ispit_2017_09_11_DotnetCore.EntityModels.Nastavnik", b =>
                {
                    b.Property<int>("NastavnikID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImePrezime");

                    b.HasKey("NastavnikID");

                    b.ToTable("Nastavnik");
                });

            modelBuilder.Entity("Ispit_2017_09_11_DotnetCore.EntityModels.Odjeljenje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsPrebacenuViseOdjeljenje");

                    b.Property<int?>("NastavnikID");

                    b.Property<string>("Oznaka");

                    b.Property<int>("Razred");

                    b.Property<string>("SkolskaGodina");

                    b.HasKey("Id");

                    b.HasIndex("NastavnikID");

                    b.ToTable("Odjeljenje");
                });

            modelBuilder.Entity("Ispit_2017_09_11_DotnetCore.EntityModels.OdjeljenjeStavka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojUDnevniku");

                    b.Property<int>("OdjeljenjeId");

                    b.Property<int>("UcenikId");

                    b.HasKey("Id");

                    b.HasIndex("OdjeljenjeId");

                    b.HasIndex("UcenikId");

                    b.ToTable("OdjeljenjeStavka");
                });

            modelBuilder.Entity("Ispit_2017_09_11_DotnetCore.EntityModels.Predmet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.Property<int>("Razred");

                    b.HasKey("Id");

                    b.ToTable("Predmet");
                });

            modelBuilder.Entity("Ispit_2017_09_11_DotnetCore.EntityModels.Ucenik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImePrezime");

                    b.HasKey("Id");

                    b.ToTable("Ucenik");
                });

            modelBuilder.Entity("Ispit_2017_09_11_DotnetCore.EntityModels.DodjeljenPredmet", b =>
                {
                    b.HasOne("Ispit_2017_09_11_DotnetCore.EntityModels.OdjeljenjeStavka", "OdjeljenjeStavka")
                        .WithMany()
                        .HasForeignKey("OdjeljenjeStavkaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ispit_2017_09_11_DotnetCore.EntityModels.Predmet", "Predmet")
                        .WithMany()
                        .HasForeignKey("PredmetId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ispit_2017_09_11_DotnetCore.EntityModels.Odjeljenje", b =>
                {
                    b.HasOne("Ispit_2017_09_11_DotnetCore.EntityModels.Nastavnik", "Nastavnik")
                        .WithMany()
                        .HasForeignKey("NastavnikID");
                });

            modelBuilder.Entity("Ispit_2017_09_11_DotnetCore.EntityModels.OdjeljenjeStavka", b =>
                {
                    b.HasOne("Ispit_2017_09_11_DotnetCore.EntityModels.Odjeljenje", "Odjeljenje")
                        .WithMany()
                        .HasForeignKey("OdjeljenjeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ispit_2017_09_11_DotnetCore.EntityModels.Ucenik", "Ucenik")
                        .WithMany()
                        .HasForeignKey("UcenikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
