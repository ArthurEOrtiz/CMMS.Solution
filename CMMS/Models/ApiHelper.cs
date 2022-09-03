using System.Threading.Tasks;
using RestSharp;

namespace CMMS.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCall(string apiKey)
    {
      RestClient client = new RestClient(""); //launch url in here 
      RestRequest request = new RestRequest($"{apiKey}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}