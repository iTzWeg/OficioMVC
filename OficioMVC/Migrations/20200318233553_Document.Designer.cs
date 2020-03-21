﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OficioMVC.Models;

namespace OficioMVC.Migrations
{
    [DbContext(typeof(OficioMVCContext))]
    [Migration("20200318233553_Document")]
    partial class Document
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("OficioMVC.Models.Documento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Ano");

                    b.Property<string>("Assunto")
                        .IsRequired();

                    b.Property<string>("CaminhoArq");

                    b.Property<DateTime>("DataAlteracao");

                    b.Property<DateTime>("DataEnvio");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("Numeracao");

                    b.Property<string>("Observacoes");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("Numeracao", "Ano")
                        .IsUnique();

                    b.ToTable("Documento");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Documento");
                });

            modelBuilder.Entity("OficioMVC.Models.Siga_profs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ativo");

                    b.Property<string>("dpto");

                    b.Property<string>("user_login")
                        .IsRequired();

                    b.Property<string>("user_nicename");

                    b.Property<string>("user_pass")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Siga_profs");
                });

            modelBuilder.Entity("OficioMVC.Models.Edital", b =>
                {
                    b.HasBaseType("OficioMVC.Models.Documento");

                    b.Property<int>("Tipo");

                    b.ToTable("Edital");

                    b.HasDiscriminator().HasValue("Edital");
                });

            modelBuilder.Entity("OficioMVC.Models.Documento", b =>
                {
                    b.HasOne("OficioMVC.Models.Siga_profs", "Usuario")
                        .WithMany("Documentos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}