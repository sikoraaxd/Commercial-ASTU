using Commercial_ASTU.MVVM.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commercial_ASTU
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Cafedra> Cafedras { get; set; }
        public DbSet<Institute> Institutes { get; set; }
        public DbSet<RequestDB> RequestDBs { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=CommercialASTU;Username=postgres;Password=alexgeniuss56455285");
        }
    }
}
