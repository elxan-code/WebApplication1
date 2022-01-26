using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    
        public class AppDbContext : IdentityDbContext
        {


            public AppDbContext(DbContextOptions options) : base(options)
            {

            }

            public DbSet<Employee> Employees { get; set; }
            public DbSet<Position> Positions { get; set; }
             public DbSet<CustomUser> CustomUsers { get; set; }
           public DbSet<Settings> Settings { get; set; }
           public DbSet<Social> Socials { get; set; }




    }
    }
