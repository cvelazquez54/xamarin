using Domain.Teacher;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TeacherHiring.Services
{
    public class TeacherServices: BaseApiService
    {
        private string _apiUrl;

        public TeacherServices(string apiUrl)
        {
            _apiUrl = apiUrl;
        }

        public async Task<IEnumerable<DtoClassAvailable>> GetAvailableClasses(string token)
        {

            var uri = new Uri(string.Format(_apiUrl + "Materia/GetListMateriaApps"));

            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            ApiClient.DefaultRequestHeaders.Add("Token", token);

            HttpResponseMessage response = await ApiClient.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var classes = JsonConvert.DeserializeObject<dynamic>(result);

                return new List<DtoClassAvailable>();
            }

            return null;

        }
    }
}
