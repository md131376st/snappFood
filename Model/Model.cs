namespace workinterview.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=Modelvender")
        {
        }

        public virtual DbSet<Vender> Venders { get; set; }
        public virtual DbSet<VenderBage> VenderBages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vender>()
                .HasMany(e => e.VenderBages)
                .WithOptional(e => e.Vender)
                .HasForeignKey(e => e.IdVender)
                .WillCascadeOnDelete();
        }
    }
}
