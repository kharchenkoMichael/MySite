using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Models
{
  public class Blog
  {
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    public string Picture { get; set; }

    public List<BlogComponent> BlogComponents { get; set; }

    public Blog()
    {
      BlogComponents = new List<BlogComponent>();
    }
  }
}
