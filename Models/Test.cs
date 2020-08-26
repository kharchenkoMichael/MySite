using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Models
{
  public class Test
  {
    public int Id { get; set; }
    public int ExerciseId { get; set; }
    public Exercise Exercise { get; set; }
    public string Input { get; set; }
    public string Output { get; set; }

  }
}
