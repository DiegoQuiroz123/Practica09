using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LinqEntity
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=MoviesEntities")
        {
        }

        public virtual DbSet<MOVIES> MOVIES { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MOVIES>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MOVIES>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<MOVIES>()
                .Property(e => e.Genre)
                .IsUnicode(false);
        }
    }
}
