using EternaProject.Models;
using Microsoft.EntityFrameworkCore;

namespace EternaProject.Data
{
    public class EternaContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectImage> ProjectImages { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public EternaContext(DbContextOptions options) : base(options)
        {
        }

    }
}


