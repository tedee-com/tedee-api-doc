using Microsoft.Extensions.Configuration;
using System.IO;

namespace Tedee.Api.CodeSamples.Helpers
{
    public static class ConfigHelpers
    {
        public static AppConfig GetAppConfig()
        {
            return GetConfiguration().GetSection("appConfig").Get<AppConfig>();
        }
        public static ApiCredentials GetApiCredentials()
        {
            var config = GetConfiguration();

            return GetConfiguration().GetSection("apiCredentials").Get<ApiCredentials>();
        }

        private static IConfiguration GetConfiguration()
        {
            return new ConfigurationBuilder()
              .AddJsonFile("appsettings.json", false, true)
              .Build();
        }
    }
}
