using Microsoft.EntityFrameworkCore;
using RMS.Infrastructure;
using System;
using System.Windows.Forms;

namespace RMS.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=RMS_DB;Trusted_Connection=True;";
            var optionsBuilder = new DbContextOptionsBuilder<RmsDBContext>();
            optionsBuilder.UseSqlServer(connectionString);
            using (var context = new RmsDBContext(optionsBuilder.Options))
            {
             
                context.Database.EnsureCreated();
                Application.Run(new MainForm());
            }
        }
    }
}