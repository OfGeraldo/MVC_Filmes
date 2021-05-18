using Microsoft.EntityFrameworkCore;
using MvcFilmes.Models;

namespace MvcFilmes.Data
{
    public class MvcFilmesContext : DbContext
    {
        public MvcFilmesContext (DbContextOptions<MvcFilmesContext> options)
            : base(options)
        {
        }

        public DbSet<Filme> Filme { get; set; }
        public DbSet<Ator> Ator { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ator>()
                .HasOne(f => f.Filme)
                .WithMany(a => a.Atores)
                .HasForeignKey(f => f.FilmeID);
        }
    }
}