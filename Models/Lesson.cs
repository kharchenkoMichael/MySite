using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Models
{
  public class Lesson
  {
    public int Id { get; set; }
    public int CourseId { get; set; }
    public Course Course { get; set; }
    [Required]
    public string Title { get; set; }
    public string VideoCW { get; set; }
    public string VideoHW { get; set; }

    public List<Exercise> Exercises { get; set; }

    public Lesson()
    {
      Exercises = new List<Exercise>();
    }
  }
}
