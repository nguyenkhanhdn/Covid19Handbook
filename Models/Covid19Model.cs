using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace Covid19Handbook.Models
{
    public partial class Covid19Model : DbContext
    {
        public Covid19Model()
            : base("name=Covid19Model")
        {
            Database.SetInitializer<Covid19Model>(new DropCreateDatabaseIfModelChanges<Covid19Model>());
        }

        //public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<comment> comments { get; set; }
        public virtual DbSet<doctor> doctors { get; set; }
        public virtual DbSet<document> documents { get; set; }
        public virtual DbSet<F01s> F01s { get; set; }
        public virtual DbSet<hotline> hotlines { get; set; }
        public virtual DbSet<Monitoring> Monitorings { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<QA> QAs { get; set; }
        public virtual DbSet<Thankful> Thanks { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Category>()
            //    .HasMany(e => e.News)
            //    .WithRequired(e => e.Category)
            //    .HasForeignKey(e => e.CategoryId)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<doctor>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<document>()
                .Property(e => e.docNo)
                .IsUnicode(false);

            modelBuilder.Entity<document>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<F01s>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<hotline>()
                .Property(e => e.hotline1)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.YearofBirth)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<QA>()
                .Property(e => e.question)
                .IsUnicode(false);

            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
        }
    }
}
