using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Problem_7
{
    public partial class SchoolContext : DbContext
    {
        public SchoolContext()
            : base("name=SchoolContext")
        {
        }

        public virtual DbSet<Pupil> Pupils { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pupil>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<Pupil>()
                .Property(e => e.surname)
                .IsUnicode(false);

            modelBuilder.Entity<Pupil>()
                .Property(e => e.sex)
                .IsUnicode(false);

            modelBuilder.Entity<Pupil>()
                .HasMany(e => e.Subjects)
                .WithRequired(e => e.Pupil)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subject>()
                .Property(e => e.subject_name)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.surname)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.sex)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.subject_name)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Subjects)
                .WithRequired(e => e.Teacher)
                .WillCascadeOnDelete(false);
        }
    }
}
