using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BesTravel.Models
{
  public class OpeningHours
  {
    public bool open_now { get; set; }
    public List<object> weekday_text { get; set; }
  }

}
