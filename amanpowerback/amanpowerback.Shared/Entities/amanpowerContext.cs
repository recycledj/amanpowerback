using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace amanpowerback.Shared.Entities
{
    public partial class amanpowerContext : DbContext
    {
        public amanpowerContext()
        {
        }

        public amanpowerContext(DbContextOptions<amanpowerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Rutina> Rutina { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rutina>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Ejercicio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Repeticiones)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
