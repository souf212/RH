﻿// <auto-generated />
using System;
using HR_Management_System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HR_Management_System.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Conges", b =>
                {
                    b.Property<int>("IdConges")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AdminComment")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateDebut")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateFin")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdEmploye")
                        .HasColumnType("int");

                    b.Property<string>("Motif")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdConges");

                    b.HasIndex("IdEmploye");

                    b.ToTable("Conges");
                });

            modelBuilder.Entity("HR_Management_System.Models.Employes", b =>
                {
                    b.Property<int>("IdEmploye")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdUtilisateur")
                        .HasColumnType("int");

                    b.HasKey("IdEmploye");

                    b.HasIndex("IdUtilisateur")
                        .IsUnique();

                    b.ToTable("Employes");
                });

            modelBuilder.Entity("HR_Management_System.Models.Taches", b =>
                {
                    b.Property<int>("IdTaches")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdEmploye")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Statut")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("IdTaches");

                    b.HasIndex("IdEmploye");

                    b.ToTable("Taches");
                });

            modelBuilder.Entity("HR_Management_System.viewModels.Absences", b =>
                {
                    b.Property<int>("IdAbsences")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAbsence")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdEmploye")
                        .HasColumnType("int");

                    b.Property<string>("Justification")
                        .HasColumnType("longtext");

                    b.HasKey("IdAbsences");

                    b.HasIndex("IdEmploye");

                    b.ToTable("Absences");
                });

            modelBuilder.Entity("HR_Management_System.viewModels.Administrateur", b =>
                {
                    b.Property<int>("IdAdmin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdUtilisateur")
                        .HasColumnType("int");

                    b.HasKey("IdAdmin");

                    b.HasIndex("IdUtilisateur")
                        .IsUnique();

                    b.ToTable("Administrateurs");
                });

            modelBuilder.Entity("HR_Management_System.viewModels.Contrat", b =>
                {
                    b.Property<int>("IdContrat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateDebut")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DateFin")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdEmploye")
                        .HasColumnType("int");

                    b.Property<decimal>("SalaireDeBase")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("TypeContrat")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdContrat");

                    b.HasIndex("IdEmploye");

                    b.ToTable("Contrats");
                });

            modelBuilder.Entity("HR_Management_System.viewModels.FicheDePaie", b =>
                {
                    b.Property<int>("IdFicheDePaie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdContrat")
                        .HasColumnType("int");

                    b.Property<decimal>("SalaireNet")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("IdFicheDePaie");

                    b.HasIndex("IdContrat");

                    b.ToTable("FichesDePaie");
                });

            modelBuilder.Entity("HR_Management_System.viewModels.HistoriqueAbsences", b =>
                {
                    b.Property<int>("IdHistoriqueAbsences")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdAbsences")
                        .HasColumnType("int");

                    b.HasKey("IdHistoriqueAbsences");

                    b.HasIndex("IdAbsences");

                    b.ToTable("HistoriqueAbsences");
                });

            modelBuilder.Entity("HR_Management_System.viewModels.HistoriqueConges", b =>
                {
                    b.Property<int>("IdHistoriqueConges")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdConges")
                        .HasColumnType("int");

                    b.HasKey("IdHistoriqueConges");

                    b.HasIndex("IdConges");

                    b.ToTable("HistoriqueConges");
                });

            modelBuilder.Entity("HR_Management_System.viewModels.Planning", b =>
                {
                    b.Property<int>("IdPlanning")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateDebut")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateFin")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdEmploye")
                        .HasColumnType("int");

                    b.Property<string>("Statut")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdPlanning");

                    b.HasIndex("IdEmploye");

                    b.ToTable("Plannings");
                });

            modelBuilder.Entity("HR_Management_System.viewModels.Pointage", b =>
                {
                    b.Property<int>("IdPointage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("HeureEntree")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("HeureSortie")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdEmploye")
                        .HasColumnType("int");

                    b.HasKey("IdPointage");

                    b.HasIndex("IdEmploye");

                    b.ToTable("Pointages");
                });

            modelBuilder.Entity("HR_Management_System.viewModels.ReconnaissanceFaciale", b =>
                {
                    b.Property<int>("IdReconnaissanceFaciale")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("HeureDetectee")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdEmploye")
                        .HasColumnType("int");

                    b.Property<string>("ImageFaciale")
                        .HasColumnType("longtext");

                    b.HasKey("IdReconnaissanceFaciale");

                    b.HasIndex("IdEmploye");

                    b.ToTable("ReconnaissanceFaciales");
                });

            modelBuilder.Entity("HR_Management_System.viewModels.Salaire", b =>
                {
                    b.Property<int>("IdSalaire")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Competence")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdEmploye")
                        .HasColumnType("int");

                    b.Property<decimal>("MontantBrut")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("MontantNet")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("IdSalaire");

                    b.HasIndex("IdEmploye");

                    b.ToTable("Salaires");
                });

            modelBuilder.Entity("HR_Management_System.viewModels.Utilisateur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CIN")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Utilisateurs");
                });

            modelBuilder.Entity("Conges", b =>
                {
                    b.HasOne("HR_Management_System.Models.Employes", "Employe")
                        .WithMany("Conges")
                        .HasForeignKey("IdEmploye")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employe");
                });

            modelBuilder.Entity("HR_Management_System.Models.Employes", b =>
                {
                    b.HasOne("HR_Management_System.viewModels.Utilisateur", "Utilisateur")
                        .WithOne()
                        .HasForeignKey("HR_Management_System.Models.Employes", "IdUtilisateur")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Utilisateur");
                });

            modelBuilder.Entity("HR_Management_System.Models.Taches", b =>
                {
                    b.HasOne("HR_Management_System.Models.Employes", "Employe")
                        .WithMany("Taches")
                        .HasForeignKey("IdEmploye")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Employe");
                });

            modelBuilder.Entity("HR_Management_System.viewModels.Absences", b =>
                {
                    b.HasOne("HR_Management_System.Models.Employes", "Employe")
                        .WithMany("Absences")
                        .HasForeignKey("IdEmploye")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employe");
                });

            modelBuilder.Entity("HR_Management_System.viewModels.Administrateur", b =>
                {
                    b.HasOne("HR_Management_System.viewModels.Utilisateur", "Utilisateur")
                        .WithOne()
                        .HasForeignKey("HR_Management_System.viewModels.Administrateur", "IdUtilisateur")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Utilisateur");
                });

            modelBuilder.Entity("HR_Management_System.viewModels.Contrat", b =>
                {
                    b.HasOne("HR_Management_System.Models.Employes", "Employe")
                        .WithMany("Contrats")
                        .HasForeignKey("IdEmploye")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employe");
                });

            modelBuilder.Entity("HR_Management_System.viewModels.FicheDePaie", b =>
                {
                    b.HasOne("HR_Management_System.viewModels.Contrat", "Contrat")
                        .WithMany("FichesDePaie")
                        .HasForeignKey("IdContrat")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contrat");
                });

            modelBuilder.Entity("HR_Management_System.viewModels.HistoriqueAbsences", b =>
                {
                    b.HasOne("HR_Management_System.viewModels.Absences", "Absence")
                        .WithMany()
                        .HasForeignKey("IdAbsences")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Absence");
                });

            modelBuilder.Entity("HR_Management_System.viewModels.HistoriqueConges", b =>
                {
                    b.HasOne("Conges", "Conges")
                        .WithMany()
                        .HasForeignKey("IdConges")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conges");
                });

            modelBuilder.Entity("HR_Management_System.viewModels.Planning", b =>
                {
                    b.HasOne("HR_Management_System.Models.Employes", "Employe")
                        .WithMany()
                        .HasForeignKey("IdEmploye")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employe");
                });

            modelBuilder.Entity("HR_Management_System.viewModels.Pointage", b =>
                {
                    b.HasOne("HR_Management_System.Models.Employes", "Employe")
                        .WithMany()
                        .HasForeignKey("IdEmploye")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employe");
                });

            modelBuilder.Entity("HR_Management_System.viewModels.ReconnaissanceFaciale", b =>
                {
                    b.HasOne("HR_Management_System.Models.Employes", "Employe")
                        .WithMany("ReconnaissanceFaciales")
                        .HasForeignKey("IdEmploye")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employe");
                });

            modelBuilder.Entity("HR_Management_System.viewModels.Salaire", b =>
                {
                    b.HasOne("HR_Management_System.Models.Employes", "Employe")
                        .WithMany("Salaires")
                        .HasForeignKey("IdEmploye")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employe");
                });

            modelBuilder.Entity("HR_Management_System.Models.Employes", b =>
                {
                    b.Navigation("Absences");

                    b.Navigation("Conges");

                    b.Navigation("Contrats");

                    b.Navigation("ReconnaissanceFaciales");

                    b.Navigation("Salaires");

                    b.Navigation("Taches");
                });

            modelBuilder.Entity("HR_Management_System.viewModels.Contrat", b =>
                {
                    b.Navigation("FichesDePaie");
                });
#pragma warning restore 612, 618
        }
    }
}
