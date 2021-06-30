﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using career.DAL.Concrete.EntityFramework;

namespace career.DAL.Migrations
{
    [DbContext(typeof(CareerContext))]
    [Migration("20210630095938_Users")]
    partial class Users
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("career.Entity.Concrete.Departmant", b =>
                {
                    b.Property<int>("DepartmantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("ParentDepartmantId")
                        .HasColumnType("integer");

                    b.HasKey("DepartmantId");

                    b.HasIndex("ParentDepartmantId");

                    b.ToTable("Departmants");

                    b.HasData(
                        new
                        {
                            DepartmantId = 10,
                            IsDeleted = false,
                            Name = "Layihələndirmə"
                        },
                        new
                        {
                            DepartmantId = 11,
                            IsDeleted = false,
                            Name = "Proqram təminatının hazırlanması"
                        },
                        new
                        {
                            DepartmantId = 12,
                            IsDeleted = false,
                            Name = "Ümumi "
                        },
                        new
                        {
                            DepartmantId = 13,
                            IsDeleted = false,
                            Name = "Verilənlər bazasının idarə edilməsi və şəbəkə inzibatçılığı"
                        },
                        new
                        {
                            DepartmantId = 14,
                            IsDeleted = false,
                            Name = "Maliyyə"
                        });
                });

            modelBuilder.Entity("career.Entity.Concrete.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("DepartmantId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Pin")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("character varying(7)");

                    b.Property<int>("PositionId")
                        .HasColumnType("integer");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmantId");

                    b.HasIndex("PositionId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("career.Entity.Concrete.Position", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("DepartmantId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PositionId");

                    b.HasIndex("DepartmantId");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            PositionId = 10,
                            DepartmantId = 11,
                            IsDeleted = false,
                            Name = "Kiçik mütəxəssis"
                        },
                        new
                        {
                            PositionId = 11,
                            DepartmantId = 12,
                            IsDeleted = false,
                            Name = "Mütəxəssis"
                        },
                        new
                        {
                            PositionId = 12,
                            DepartmantId = 13,
                            IsDeleted = false,
                            Name = "Apararıcı mütəxəssis"
                        },
                        new
                        {
                            PositionId = 13,
                            DepartmantId = 12,
                            IsDeleted = false,
                            Name = "Baş mütəxəssis"
                        },
                        new
                        {
                            PositionId = 14,
                            DepartmantId = 14,
                            IsDeleted = false,
                            Name = "Sektor müdiri"
                        },
                        new
                        {
                            PositionId = 15,
                            DepartmantId = 10,
                            IsDeleted = false,
                            Name = "Şöbə müdiri"
                        },
                        new
                        {
                            PositionId = 16,
                            DepartmantId = 14,
                            IsDeleted = false,
                            Name = "Direktor müavini"
                        },
                        new
                        {
                            PositionId = 17,
                            DepartmantId = 13,
                            IsDeleted = false,
                            Name = "Direktor"
                        });
                });

            modelBuilder.Entity("career.Entity.Concrete.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("bytea");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("career.Entity.Concrete.Vacancy", b =>
                {
                    b.Property<int>("VacancyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Education")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("MaximumAgeLimit")
                        .HasColumnType("integer");

                    b.Property<int>("MinimumAgeLimit")
                        .HasColumnType("integer");

                    b.Property<string>("RelativePerson")
                        .HasColumnType("text");

                    b.Property<string>("RequiredExperience")
                        .HasColumnType("text");

                    b.Property<DateTime>("VacancyEndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("VacancyHeader")
                        .HasColumnType("text");

                    b.Property<DateTime>("VacancyStartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("VacancyTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("WorkLocation")
                        .HasColumnType("text");

                    b.HasKey("VacancyId");

                    b.HasIndex("VacancyTypeId");

                    b.ToTable("Vacancies");
                });

            modelBuilder.Entity("career.Entity.Concrete.VacancyInformation", b =>
                {
                    b.Property<int>("VacancyInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("VacancyId")
                        .HasColumnType("integer");

                    b.Property<string>("VacancyInfoLabel")
                        .HasColumnType("text");

                    b.Property<string>("VacancyInfoValue")
                        .HasColumnType("text");

                    b.HasKey("VacancyInfoId");

                    b.HasIndex("VacancyId");

                    b.ToTable("VacancyInformation");
                });

            modelBuilder.Entity("career.Entity.Concrete.VacancyRequirement", b =>
                {
                    b.Property<int>("VacancyRequirementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("RequirementPunct")
                        .HasColumnType("text");

                    b.Property<int>("VacancyId")
                        .HasColumnType("integer");

                    b.HasKey("VacancyRequirementId");

                    b.HasIndex("VacancyId");

                    b.ToTable("VacancyRequirements");
                });

            modelBuilder.Entity("career.Entity.Concrete.VacancyType", b =>
                {
                    b.Property<int>("VacancyTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Key")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("VacancyTypeId");

                    b.ToTable("VacancyTypes");

                    b.HasData(
                        new
                        {
                            VacancyTypeId = 1,
                            IsDeleted = false,
                            Key = "intern",
                            Name = "Təcrübə proqramı"
                        },
                        new
                        {
                            VacancyTypeId = 2,
                            IsDeleted = false,
                            Key = "work",
                            Name = "İş vakansiyası"
                        });
                });

            modelBuilder.Entity("career.Entity.Concrete.Departmant", b =>
                {
                    b.HasOne("career.Entity.Concrete.Departmant", "ParentDepartmant")
                        .WithMany()
                        .HasForeignKey("ParentDepartmantId");

                    b.Navigation("ParentDepartmant");
                });

            modelBuilder.Entity("career.Entity.Concrete.Employee", b =>
                {
                    b.HasOne("career.Entity.Concrete.Departmant", "Departmant")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmantId");

                    b.HasOne("career.Entity.Concrete.Position", "Position")
                        .WithMany("Employees")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departmant");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("career.Entity.Concrete.Position", b =>
                {
                    b.HasOne("career.Entity.Concrete.Departmant", "Departmant")
                        .WithMany("Positions")
                        .HasForeignKey("DepartmantId");

                    b.Navigation("Departmant");
                });

            modelBuilder.Entity("career.Entity.Concrete.Vacancy", b =>
                {
                    b.HasOne("career.Entity.Concrete.VacancyType", "VacancyType")
                        .WithMany("Vacancies")
                        .HasForeignKey("VacancyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VacancyType");
                });

            modelBuilder.Entity("career.Entity.Concrete.VacancyInformation", b =>
                {
                    b.HasOne("career.Entity.Concrete.Vacancy", "Vacancy")
                        .WithMany("VacancyInformation")
                        .HasForeignKey("VacancyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vacancy");
                });

            modelBuilder.Entity("career.Entity.Concrete.VacancyRequirement", b =>
                {
                    b.HasOne("career.Entity.Concrete.Vacancy", "Vacancy")
                        .WithMany("VacancyRequirements")
                        .HasForeignKey("VacancyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vacancy");
                });

            modelBuilder.Entity("career.Entity.Concrete.Departmant", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Positions");
                });

            modelBuilder.Entity("career.Entity.Concrete.Position", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("career.Entity.Concrete.Vacancy", b =>
                {
                    b.Navigation("VacancyInformation");

                    b.Navigation("VacancyRequirements");
                });

            modelBuilder.Entity("career.Entity.Concrete.VacancyType", b =>
                {
                    b.Navigation("Vacancies");
                });
#pragma warning restore 612, 618
        }
    }
}
