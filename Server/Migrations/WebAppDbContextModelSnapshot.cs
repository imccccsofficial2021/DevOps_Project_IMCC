﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MudBlazorWASM.Server.Data;

#nullable disable

namespace MudBlazorWASM.Server.Migrations
{
    [DbContext(typeof(WebAppDbContext))]
    partial class WebAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MudBlazorWASM.Shared.Models.Egrade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentsId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfferNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Semester")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectCodeId")
                        .HasColumnType("int");

                    b.Property<string>("Syear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SYear");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotUnits")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "DepartmentsId" }, "EGrades_DepartmentsId");

                    b.HasIndex(new[] { "SubjectCodeId" }, "EGrades_SubjectCodeId");

                    b.ToTable("EGrades", (string)null);
                });

            modelBuilder.Entity("MudBlazorWASM.Shared.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Birthdate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FathersName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MothersName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Religion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("MudBlazorWASM.Shared.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LabUnits")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LecUnits")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreRequisite")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotUnits")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("MudBlazorWASM.Shared.Models.SummaryGrade", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<double?>("Average")
                        .HasColumnType("float")
                        .HasColumnName("AVERAGE");

                    b.Property<string>("Courseno")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("COURSENO");

                    b.Property<int?>("Deptno")
                        .HasColumnType("int")
                        .HasColumnName("DEPTNO");

                    b.Property<string>("First")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("FIRST");

                    b.Property<string>("Last")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("LAST");

                    b.Property<string>("Mi")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("MI");

                    b.Property<int>("Offerno")
                        .HasColumnType("int")
                        .HasColumnName("OFFERNO");

                    b.Property<int>("Studno")
                        .HasColumnType("int")
                        .HasColumnName("STUDNO");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("SUBJECT");

                    b.Property<double?>("Term1")
                        .HasColumnType("float")
                        .HasColumnName("TERM1");

                    b.Property<double?>("Term2")
                        .HasColumnType("float")
                        .HasColumnName("TERM2");

                    b.Property<double?>("Term3")
                        .HasColumnType("float")
                        .HasColumnName("TERM3");

                    b.Property<double?>("Term4")
                        .HasColumnType("float")
                        .HasColumnName("TERM4");

                    b.HasKey("Id");

                    b.ToTable("SummaryGrades");
                });

            modelBuilder.Entity("MudBlazorWASM.Shared.Models.Egrade", b =>
                {
                    b.HasOne("MudBlazorWASM.Shared.Models.Subject", "SubjectCode")
                        .WithMany("Egrades")
                        .HasForeignKey("SubjectCodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubjectCode");
                });

            modelBuilder.Entity("MudBlazorWASM.Shared.Models.Subject", b =>
                {
                    b.Navigation("Egrades");
                });
#pragma warning restore 612, 618
        }
    }
}
