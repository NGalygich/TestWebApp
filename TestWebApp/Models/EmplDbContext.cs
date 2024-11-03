using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace TestWebApp.Models
{
    public class EmplDbContext : DbContext
    {


        public EmplDbContext(DbContextOptions<EmplDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        //public DbSet<Employee> Employees { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employee>().HasKey(x => x.Id);
        //    base.OnModelCreating(modelBuilder);
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "TestDB.db" };
        //    var connectionString = connectionStringBuilder.ToString();
        //    var connection = new SqliteConnection(connectionString);

        //    optionsBuilder.UseSqlite(connection);
        //}
    }
}
