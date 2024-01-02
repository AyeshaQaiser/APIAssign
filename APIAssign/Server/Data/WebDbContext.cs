using Microsoft.EntityFrameworkCore;
using APIAssign.Shared;
using System;

namespace APIAssign.Server.Data
{
    public class WebDbContext:DbContext
    {
        public WebDbContext(DbContextOptions<WebDbContext> options) : base(options) 
        {

        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Product> product { get; set; }
        public DbSet<SignUp> Register { get; set; }


    }
}
