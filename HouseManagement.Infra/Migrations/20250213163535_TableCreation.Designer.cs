﻿// <auto-generated />
using HouseManagement.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HouseManagement.Infra.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250213163535_TableCreation")]
    partial class TableCreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HouseManagement.Domain.Entity.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(70)");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("HouseManagement.Domain.Entity.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<int>("IdPerson")
                        .HasColumnType("int");

                    b.Property<bool>("IsReceita")
                        .HasColumnType("bit");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal (7,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdPerson");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("HouseManagement.Domain.Entity.Transaction", b =>
                {
                    b.HasOne("HouseManagement.Domain.Entity.Person", "Person")
                        .WithMany("Transactions")
                        .HasForeignKey("IdPerson")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("HouseManagement.Domain.Entity.Person", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
