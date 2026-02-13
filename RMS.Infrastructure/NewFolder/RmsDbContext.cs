using Microsoft.EntityFrameworkCore;
using RMS.Domain.Entities;




namespace RMS.Infrastructure

{

    public class RmsDBContext : DbContext

    {

        public RmsDBContext(DbContextOptions<RmsDBContext> options) : base(options)

        {

        }
        public DbSet<Equipment> Equipments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            if (!optionsBuilder.IsConfigured)

            {

                optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=RMS_Db;Integrated Security=True");

            }

        }

    }

}