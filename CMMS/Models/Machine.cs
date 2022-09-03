using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CMMS.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    public string Name { get; set; }
    public string SerialNumber { get; set; }
    public int Hours { get; set; } 
    public string Status { get; set; }

    public static List<Machine> GetMachines(string apiKey)
    {
      var apiCallTask = ApiHelper.ApiCall(apiKey);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Machine> machineList = JsonConvert.DeserializeObject<List<Machine>>(jsonResponse["results"].ToString());

      return machineList;

    }
  }
}