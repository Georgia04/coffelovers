using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CofffeeLovers.Models;

namespace CoffeeLovers.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CofffeeLovers.Models.Address> Address { get; set; }
        public DbSet<CofffeeLovers.Models.Customer> Customer { get; set; }
    }
}
