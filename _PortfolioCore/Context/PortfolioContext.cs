using _PortfolioCore.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace _PortfolioCore.Context
{
    public class PortfolioContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-LNEC8NA;initial Catalog=_PortfolioCoreDb;integrated security=true;");
        }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Contact> Contacts { get; set; }

    }
}
