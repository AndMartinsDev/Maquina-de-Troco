﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MqTroco.Data;

namespace MqTroco.Migrations
{
    [DbContext(typeof(SystemContext))]
    [Migration("20221017153224_Caixa")]
    partial class Caixa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MqTroco.Data.Caixa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Caixa");
                });

            modelBuilder.Entity("MqTroco.Data.Moeda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CaixaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Qtd")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CaixaId");

                    b.ToTable("Moeda");
                });

            modelBuilder.Entity("MqTroco.Data.Moeda", b =>
                {
                    b.HasOne("MqTroco.Data.Caixa", null)
                        .WithMany("Moedas")
                        .HasForeignKey("CaixaId");
                });
#pragma warning restore 612, 618
        }
    }
}
