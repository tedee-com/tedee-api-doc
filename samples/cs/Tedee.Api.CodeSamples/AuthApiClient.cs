using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Tedee.Api.CodeSamples.Models;

namespace Tedee.Api.CodeSamples
{
    public class AuthApiClient
    {
        private AppConfig _appConfig;

        public AuthApiClient(AppConfig appConfig)
        {
            _appConfig = appConfig;
        }

        public async Task<string> GetAccessToken(string userName, string password)
        {
            using (var client = new HttpClient())
            {
                var parameters = new Dictionary<string, string>
                {
                    { "grant_type", "password" },
                    { "username", userName },
                    { "password", password },
                    { "scope", $"openid {_appConfig.ClientId}" },
                    { "client_id", _appConfig.ClientId },
                    { "response_type", "token id_token" }
                };

                // FormUrlEncodedContent adds "application/x-www-form-urlencoded" Content-Type by default
                using (var content = new FormUrlEncodedContent(parameters))
                {
                    var response = await client.PostAsync(_appConfig.AuthApiUrl, content);
                    var result = await response.Content.ReadAsAsync<AccessTokenResponse>();

                    return result.AccessToken;
                }
            }
        }
    }
}
