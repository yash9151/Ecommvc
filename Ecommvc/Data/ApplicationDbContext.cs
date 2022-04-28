using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Ecommvc.Models;

namespace Ecommvc.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //public DbSet<Ecommvc.Models.Category> Categories { get; set; }
        //public DbSet<Ecommvc.Models.Products> Products { get; set; }
    }
}
