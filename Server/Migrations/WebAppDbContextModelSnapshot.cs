// <auto-generated />
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

            modelBuilder.Entity("EgradeSubject", b =>
                {
                    b.Property<int>("EgradesId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectsId")
                        .HasColumnType("int");

                    b.HasKey("EgradesId", "SubjectsId");

                    b.HasIndex("SubjectsId");

                    b.ToTable("EgradeSubject");
                });

            modelBuilder.Entity("MudBlazorWASM.Shared.Models.AuthenticationUser.AppUser", b =>
                {
                    b.Property<int>("Userid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Userid");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Userid"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Cellnumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Emailid")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Userid");

                    b.ToTable("userdetails", (string)null);
                });

            modelBuilder.Entity("MudBlazorWASM.Shared.Models.Egrade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Day")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentsId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfferNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Semester")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectCode")
                        .HasColumnType("int");

                    b.Property<string>("Syear")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SYear");

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotUnits")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");


                    b.HasIndex(new[] { "DepartmentsId" }, "DepartmentId");

                    b.HasIndex(new[] { "SubjectCode" }, "SubjectCode");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Birthdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FathersName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MothersName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Religion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentNo")
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
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("COURSENO");

                    b.Property<int?>("Deptno")
                        .HasColumnType("int")
                        .HasColumnName("DEPTNO");

                    b.Property<string>("First")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("FIRST");

                    b.Property<string>("Last")
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

                    b.Property<string>("Subjects")
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

            modelBuilder.Entity("EgradeSubject", b =>
                {
                    b.HasOne("MudBlazorWASM.Shared.Models.Egrade", null)
                        .WithMany()
                        .HasForeignKey("EgradesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MudBlazorWASM.Shared.Models.Subject", null)
                        .WithMany()
                        .HasForeignKey("SubjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
