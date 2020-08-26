using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using MySite.Models;

namespace MySite.ViewModels
{
  public class MainViewModel
  {
    public List<Blog> Blogs { get; set; }

    public List<Course> Courses { get; set; }
    public List<Project> Projects { get; set; }
  }
}
