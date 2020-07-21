using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BankAspCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<BankCard> BankCards { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceProvider> ServiceProviders { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
