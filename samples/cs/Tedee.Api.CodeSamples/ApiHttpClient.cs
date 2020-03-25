using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Tedee.Api.CodeSamples.Models;

namespace Tedee.Api.CodeSamples
{
    public class ApiHttpClient : HttpClient
    {
        public ApiHttpClient(AppConfig config, string jwt)
        {
            this.BaseAddress = new Uri(config.ApiUrl);
            this.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);
        }

    }
}
