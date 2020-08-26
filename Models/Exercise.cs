using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Models
{
  public class Exercise
  {
    public int Id { get; set; }
    public int LessonId { get; set; }
    public Lesson Lesson { get; set; }

    public string Content { get; set; }

    public List<Test> Tests { get; set; }

    public Exercise()
    {
      Tests = new List<Test>();
    }
  }
}
