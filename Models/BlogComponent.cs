using Microsoft.AspNetCore.Razor.Language.Intermediate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Models
{

  public class BlogComponent
  {
    public int Id { get; set; }
    public int BlogId { get; set; }
    public string ContentHtml { get; set; }
    public int OrderPosition { get; set; }
  }
}
