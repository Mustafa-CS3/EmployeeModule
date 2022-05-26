using EmployeeModule.IdentityAuth;
using EmployeeModule.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeModule.DbContext
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder bd)
        {
            base.OnModelCreating(bd);
        }

        public DbSet<Employee> Employee { get; set; }
    }
}
