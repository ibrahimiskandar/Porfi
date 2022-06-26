using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Porfi.Models;

namespace Porfi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        private readonly DbContextOptions _options;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            _options = options;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
