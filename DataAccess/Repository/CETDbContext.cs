using DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CETDbContext : DbContext
    {
        public CETDbContext() 
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server =SPK\SQLEXPRESS;database=CETDB;integrated security=true");
        }
        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; } 
    }

}
