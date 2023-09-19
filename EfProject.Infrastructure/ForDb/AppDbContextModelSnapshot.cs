﻿// <auto-generated />
using EfProject.Infrastructure.DbConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EfProject.Infrastructure.ForDb
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EfProject.Domain.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Salary")
                        .HasColumnType("integer");

                    b.Property<int>("level")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("EfProject.Domain.Models.Project", b =>
                {
                    b.Property<int>("project_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("project_id"));

                    b.Property<int>("employeeId")
                        .HasColumnType("integer");

                    b.Property<string>("isCreated")
                        .HasColumnType("text");

                    b.Property<string>("project_name")
                        .HasColumnType("text");

                    b.HasKey("project_id");

                    b.HasIndex("employeeId");

                    b.ToTable("projects");
                });

            modelBuilder.Entity("EfProject.Domain.Models.Project", b =>
                {
                    b.HasOne("EfProject.Domain.Models.Employee", null)
                        .WithMany("Projects")
                        .HasForeignKey("employeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EfProject.Domain.Models.Employee", b =>
                {
                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
