using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Entities;

namespace PrimeiraAPI.Context {
    public class LocalDbContext : DbContext {
        public LocalDbContext (DbContextOptions<LocalDbContext> options) : base (options) { }
        public DbSet<Carro> carro { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder){ }
    }
}