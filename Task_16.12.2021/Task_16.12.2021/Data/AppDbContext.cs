using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_16._12._2021.Models;

namespace Task_16._12._2021.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions option) : base(option)
        {

        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<CustomUser> CustomUsers { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<LatestArticle> LatestArticles { get; set; }
        public DbSet<OurWork> OurWorks { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SiteSocial> SiteSocials { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<TagToWork> TagToWorks { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<TwitterFeed> TwitterFeeds { get; set; }
        public DbSet<WorkTag> WorkTags { get; set; }
    }
}
