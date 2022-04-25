using Microsoft.EntityFrameworkCore;
using MudBlazorWASM.Shared.Models;

namespace MudBlazorWASM.Server.Data
{
    public class WebAppDbContext : DbContext
    {
        public WebAppDbContext(DbContextOptions<WebAppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Egrade>(entity =>
            {
                entity.ToTable("EGrades");

                entity.HasIndex(e => e.DepartmentsId, "IX_EGrades_DepartmentsId");

                entity.HasIndex(e => e.SubjectCodeId, "IX_EGrades_SubjectCodeId");

                entity.Property(e => e.Syear).HasColumnName("SYear");

                entity.HasOne(d => d.SubjectCode)
                    .WithMany(p => p.Egrades)
                    .HasForeignKey(d => d.SubjectCodeId);
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

                entity.Property(e => e.Subject)
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
