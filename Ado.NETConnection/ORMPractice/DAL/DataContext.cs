using Microsoft.EntityFrameworkCore;
using ORMPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMPractice.DAL
{
    internal class DataContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-HPCK2O7;Database=Academy;Trusted_Connection=true;TrustServerCertificate=True");


        }
    }
}
