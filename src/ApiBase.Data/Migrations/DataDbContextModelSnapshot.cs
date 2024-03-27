﻿// <auto-generated />
using System;
using ApiBase.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiBase.Infra.Data.Migrations
{
    [DbContext(typeof(DataDbContext))]
    partial class DataDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiBase.Domain.Entities.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("Ativo");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("CPF");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("DATE")
                        .HasColumnName("DataNascimento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasColumnName("Email");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasColumnName("Login");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasColumnName("Nome");

                    b.Property<string>("Profissao")
                        .IsRequired()
                        .HasColumnType("varchar(14)")
                        .HasColumnName("Profissao");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(256)")
                        .HasColumnName("Senha");

                    b.Property<byte>("Tipo")
                        .HasColumnType("tinyint")
                        .HasColumnName("Tipo");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
