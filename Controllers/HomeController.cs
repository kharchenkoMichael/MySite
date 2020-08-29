using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MySite.Models;
using MySite.ViewModels;

namespace MySite.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private readonly SiteDbContext _context;

    public HomeController(ILogger<HomeController> logger, SiteDbContext context)
    {
      _logger = logger;
      _context = context;
    }

    public IActionResult Index()
    {
      var blogs = _context.Blogs.Take(4);
      var courses = _context.Courses.Take(3);
      var projects = _context.Projects.Take(2);
      return View(new MainViewModel
      {
        Blogs = blogs.ToList(),
        Courses = courses.ToList(),
        Projects = projects.ToList()
      });
    }

    public IActionResult Blogs()
    {
      return View(_context.Blogs.ToList());
    }

    public IActionResult Blog(int id)
    {
      return View(_context.Blogs.Where(blog => blog.Id == id).Include(b => b.BlogComponents).FirstOrDefault());
    }

    public IActionResult BlogCard(Blog blog)
    {
      return PartialView(blog);
    }

    public IActionResult CourseCard(Course course)
    {
      return PartialView(course);
    }

    public IActionResult ProjectCard(Project project)
    {
      return PartialView(project);
    }
    public IActionResult LessonCard(Lesson lesson)
    {
      return PartialView(lesson);
    }

    public IActionResult ProjectHorizontalCard(Project project)
    {
      return PartialView(project);
    }

    public IActionResult Projects()
    {
      return View(_context.Projects.ToList());
    }

    public IActionResult Courses()
    {
      return View(_context.Courses.ToList());
    }
    public IActionResult Course(int id)
    {
      return View(_context.Courses.Where(course => course.Id == id).Include(c => c.Lessons).FirstOrDefault());
    }


    public IActionResult Lesson(int id)
    {
      return View(_context.Lessons.Where(lesson => lesson.Id == id).Include(l => l.Exercises).FirstOrDefault());
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
