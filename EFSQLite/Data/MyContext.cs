using EFSQLite.Models;
using Microsoft.EntityFrameworkCore;

namespace EFSQLite.Data
{
    public class MyContext : DbContext
    {
        public MyContext() 
        {
            Database.EnsureCreated();// Zajistí vytvoření tabulky
        }

        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source= Soubor.db"); // naše SQLite databáze ve složce BIN
        }
    }
}
