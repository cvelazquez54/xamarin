using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TeacherHiring.Services
{
    public class BaseApiService
    {
        public HttpClient ApiClient;
        public HttpResponseMessage ApiResponse = null;

        public BaseApiService()
        {
            ApiClient = new HttpClient();
            ApiClient.MaxResponseContentBufferSize = long.MaxValue;
        }
    }
}
