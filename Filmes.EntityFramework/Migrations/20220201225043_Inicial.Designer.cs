﻿// <auto-generated />
using Filmes.EntityFramework.Dados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Filmes.EntityFramework.Migrations
{
    [DbContext(typeof(FilmesContexto))]
    [Migration("20220201225043_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Filmes.EntityFramework.Negocio.Ator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("actor_id");

                    b.Property<string>("PrimeiroNome")
                        .IsRequired()
                        .HasColumnName("firts_name")
                        .HasColumnType("varchar(45)");

                    b.Property<string>("UltimoNome")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasColumnType("varchar(45)");

                    b.Property<DateTime>("last_update")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("actor");
                });
#pragma warning restore 612, 618
        }
    }
}
