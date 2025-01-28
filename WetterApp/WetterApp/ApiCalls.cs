using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetterApp
{
    public class ApiCalls
    {
        private readonly IConfiguration? _config;
        private readonly string? _apiKey;
        private HttpClient client = new HttpClient();

        public ApiCalls(IConfiguration? config)
        {
            _config = config;
            _apiKey = _config?["ApiKeyWeatherApi"];
        }

        


    }
}
