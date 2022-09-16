using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncComponents.Model
{
    public class UserService
    {
        private string url = "https://jsonplaceholder.typicode.com/users";

        public async Task<List<User>> GetUsersAsync()
        {
            HttpClient http = new HttpClient();
            HttpResponseMessage response = await http.GetAsync(url);
            string content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<User>>(content);
        }
    }
}
