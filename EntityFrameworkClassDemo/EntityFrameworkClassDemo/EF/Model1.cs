namespace EntityFrameworkClassDemo.EF
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

        public virtual DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .Property(e => e.cDepartmentCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.vDepartmentName)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.vDepartmentHead)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.vLocation)
                .IsUnicode(false);
        }
    }
}
