namespace Temp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<College> Colleges { get; set; }
        public virtual DbSet<College_Registration2> College_Registration2 { get; set; }
        public virtual DbSet<CollegeBranch> CollegeBranches { get; set; }
        public virtual DbSet<CollegeChoice> CollegeChoices { get; set; }
        public virtual DbSet<CollegePayment> CollegePayments { get; set; }
        public virtual DbSet<CollegeRegistration> CollegeRegistrations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<College>()
                .Property(e => e.collegetype)
                .IsUnicode(false);

            modelBuilder.Entity<College>()
                .HasMany(e => e.CollegeRegistrations)
                .WithRequired(e => e.College)
                .HasForeignKey(e => e.CollegeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<College_Registration2>()
                .Property(e => e.landlinePhone)
                .IsUnicode(false);

            modelBuilder.Entity<College_Registration2>()
                .Property(e => e.Regdate)
                .IsUnicode(false);

            modelBuilder.Entity<CollegeRegistration>()
                .Property(e => e.OfficerName)
                .IsUnicode(false);

            modelBuilder.Entity<CollegeRegistration>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<CollegeRegistration>()
                .Property(e => e.CollegeType)
                .IsUnicode(false);
        }
    }
}
