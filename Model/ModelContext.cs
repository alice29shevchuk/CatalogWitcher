using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CatalogWitcher.Model
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=ModelContext2")
        {
        }

        public virtual DbSet<Chapter> Chapters { get; set; }
        public virtual DbSet<Character> Characters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chapter>()
                .HasMany(e => e.Characters)
                .WithOptional(e => e.Chapter)
                .HasForeignKey(e => e.CharaptersId);

            modelBuilder.Entity<Character>()
                .Property(e => e.Img)
                .IsUnicode(false);
        }
    }
}
