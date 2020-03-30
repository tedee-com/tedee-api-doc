using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Tedee.Api.CodeSamples.Models;

namespace Tedee.Api.CodeSamples.Helpers
{
    public static class AppHelpers
    {
        public static async Task<HttpClient> CreateAndAuthenticateClient()
        {
            var apiCredentials = ConfigHelpers.GetApiCredentials();
            var appConfig = ConfigHelpers.GetAppConfig();
            var jwt = await GetJwt(apiCredentials, appConfig);

            var client = new HttpClient
            {
                BaseAddress = new Uri(appConfig.ApiUrl)
            };
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);
            return client;
        }

        private static async Task<string> GetJwt(ApiCredentials apiCredentials, AppConfig appConfig)
        {
            using (var client = new HttpClient())
            {
                var parameters = new Dictionary<string, string>
                {
                    { "grant_type", "password" },
                    { "username", apiCredentials.UserName },
                    { "password", apiCredentials.Password },
                    { "scope", $"openid {appConfig.ClientId}" },
                    { "client_id", appConfig.ClientId },
                    { "response_type", "token id_token" }
                };

                // FormUrlEncodedContent adds "application/x-www-form-urlencoded" Content-Type by default
                using (var content = new FormUrlEncodedContent(parameters))
                {
                    var response = await client.PostAsync(appConfig.AuthApiUrl, content);
                    var result = await response.Content.ReadAsAsync<AccessTokenResponse>();

                    return result.AccessToken;
                }
            }
        }
    }
}
