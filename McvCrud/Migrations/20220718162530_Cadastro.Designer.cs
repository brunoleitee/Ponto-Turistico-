﻿// <auto-generated />
using McvCrud.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace McvCrud.Migrations
{
    [DbContext(typeof(McvCrudContext))]
    [Migration("20220718162530_Cadastro")]
    partial class Cadastro
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("McvCrud.Models.Cadastro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CEP")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Referencia")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Rua")
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Cadastro");
                });
#pragma warning restore 612, 618
        }
    }
}
