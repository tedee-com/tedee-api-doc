using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Tedee.Api.CodeSamples.Helpers;
using Tedee.Api.CodeSamples.Models;

namespace Tedee.Api.CodeSamples.Actions
{
    public static class S01AuthenticateUsingJWT
    {
        public static async Task Authenticate()
        {
            var userCredentials = ConfigHelpers.GetUserCredentials();
            var appConfig = ConfigHelpers.GetAppConfig();

            var jwt = await GetJWT(userCredentials, appConfig);

            Console.WriteLine($"Your access token: {jwt}");

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

                var response = await client.GetAsync($"{appConfig.ApiUrl}my/device");
                var result = await response.Content.ReadAsStringAsync();

                Console.WriteLine($"Response status code: {response.StatusCode}");
            };

        }

        private static async Task<string> GetJWT(UserCredentials userCredentials, AppConfig appConfig)
        {
            using (var client = new HttpClient())
            {
                var parameters = new Dictionary<string, string>
                {
                    { "grant_type", "password" },
                    { "username", userCredentials.UserName },
                    { "password", userCredentials.Password },
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
