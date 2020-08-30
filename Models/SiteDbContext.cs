using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MySite.Models
{
  public class SiteDbContext: IdentityDbContext<User>
  {
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<BlogComponent> BlogComponents { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Test> Tests { get; set; }

    public SiteDbContext(DbContextOptions<SiteDbContext> options)
      : base(options)
    {
    }
  }
}
