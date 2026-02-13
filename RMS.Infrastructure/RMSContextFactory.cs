using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.Design;



namespace RMS.Infrastructure
{
    public class RMSContextFactory : IDesignTimeDbContextFactory<RmsDBContext>
    {
        public RmsDBContext CreateDbContext(string[] args) {
            var optionsBuilder = new DbContextOptionsBuilder<RmsDBContext>();
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=RMS_Db;Integrated Security=True");
            return new RmsDBContext(optionsBuilder.Options);
        }
    }
}