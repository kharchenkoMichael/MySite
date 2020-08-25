using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Models
{
  public class Lesson
  {
    public int Id { get; set; }
    public int CourseId { get; set; }
    public string Title { get; set; }
    public string VideoCW { get; set; }
    public string VideoHW { get; set; }
  }
}
