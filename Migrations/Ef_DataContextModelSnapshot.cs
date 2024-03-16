﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StudentsApi.Ef_Core;

#nullable disable

namespace StudentsApi.Migrations
{
    [DbContext(typeof(Ef_DataContext))]
    partial class Ef_DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("StudentsApi.Ef_Core.Students", b =>
                {
                    b.Property<int>("StudentsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StudentsId"));

                    b.Property<string>("StudentDepartment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StudentEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StudentPhone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("StudentsId");

                    b.ToTable("StudentsDb");
                });
#pragma warning restore 612, 618
        }
    }
}