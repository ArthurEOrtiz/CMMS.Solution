using System;
using System.Collections.Generic; 

namespace CMMS.Models
{
  public class Dispatch
  {
    public int DispatchId { get; set; } // maybe want to privately set this after each one is created?
    public int MachineID { get; set; } // want to get that from the API?
    public string DispatcType { get; set; } // unplanned downtime, or preventive maintenance downtime
    public string Description { get; set; }

  }
}