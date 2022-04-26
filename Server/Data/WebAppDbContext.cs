using Microsoft.EntityFrameworkCore;
using MudBlazorWASM.Shared.Models;

namespace MudBlazorWASM.Server.Data
{
    public class WebAppDbContext : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public WebAppDbContext(DbContextOptions<WebAppDbContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Egrade>(entity =>
            {
                entity.ToTable("EGrades");

                entity.HasIndex(e => e.DepartmentsId, "DepartmentId");

                entity.HasIndex(e => e.SubjectCode, "SubjectCode");

                entity.Property(e => e.Syear).HasColumnName("SYear");

                //entity.HasMany(d => d.SubjectCode)
                //    .WithMany(p => p.Egrades)
                //    .HasForeignKey(d => d.SubjectCode);
            });

            modelBuilder.Entity<SummaryGrade>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Average).HasColumnName("AVERAGE");

                entity.Property(e => e.Courseno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COURSENO");

                entity.Property(e => e.Deptno).HasColumnName("DEPTNO");

                entity.Property(e => e.First)
                    .IsUnicode(false)
                    .HasColumnName("FIRST");

                entity.Property(e => e.Last)
                    .IsUnicode(false)
                    .HasColumnName("LAST");

                entity.Property(e => e.Mi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MI");

                entity.Property(e => e.Offerno).HasColumnName("OFFERNO");

                entity.Property(e => e.Studno).HasColumnName("STUDNO");

                entity.Property(e => e.Subjects)
                    .IsUnicode(false)
                    .HasColumnName("SUBJECT");

                entity.Property(e => e.Term1).HasColumnName("TERM1");

                entity.Property(e => e.Term2).HasColumnName("TERM2");

                entity.Property(e => e.Term3).HasColumnName("TERM3");

                entity.Property(e => e.Term4).HasColumnName("TERM4");
            });

            //  OnModelCreatingPartial(modelBuilder);
        }

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        //  public virtual DbSet<Department> DepartmentList { get; set; }
        public virtual DbSet<Egrade> Egrades { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<SummaryGrade> SummaryGrades { get; set; }


    }
}
