using Microsoft.EntityFrameworkCore;
using MudBlazorWASM.Shared.Models;
using MudBlazorWASM.Shared.Models.AuthenticationUser;

namespace MudBlazorWASM.Server.Data
{
    public partial class WebAppDbContext : DbContext
    {

      //  private readonly DbContextOption<WebAppDbContext> options;

        public WebAppDbContext()
        {
        }

        public WebAppDbContext(DbContextOptions<WebAppDbContext> options)
            : base(options) 

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public WebAppDbContext(DbContextOptions<WebAppDbContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        {
        }
        
        // public virtual DbSet<Department> DepartmentList { get; set; }
        public virtual DbSet<Egrade> Egrades { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Subject> Subjects { get; set; } = null!;
        public virtual DbSet<SummaryGrade> SummaryGrades { get; set; } = null!;
        public virtual DbSet<AppUser> AppUsers { get; set; } = null!;
       // public DbContextOption<WebAppDbContext> Options { get; }

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

            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.ToTable("userdetails");
                entity.Property(e => e.Userid).HasColumnName("Userid");
                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);
                entity.Property(e => e.Cellnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Emailid)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
            OnModelCreatingPartial(modelBuilder);

            //  OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public class DbContextOption<T>
        {
        }
    }
}
