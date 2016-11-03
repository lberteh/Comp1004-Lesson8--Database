namespace Comp1004_Lesson8.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CollegeContext : DbContext
    {
        public CollegeContext()
            : base("name=CollegeConnection")
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(e => e.ProgramDescription)
                .IsFixedLength();
        }
    }
}
