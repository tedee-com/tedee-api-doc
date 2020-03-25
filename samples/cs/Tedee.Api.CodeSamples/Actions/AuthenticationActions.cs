using System;
using System.Threading.Tasks;
using Tedee.Api.CodeSamples.Models;

namespace Tedee.Api.CodeSamples.Actions
{
    public class AuthenticationActions
    {
        private AppConfig _appConfig;

        public AuthenticationActions(AppConfig appConfig)
        {
            _appConfig = appConfig;
        }

        public Task<string> Authenticate()
        {
            Console.WriteLine("Let's authenticate!");
            Console.WriteLine("User name/Email: ");
            var userName = Console.ReadLine();
            Console.WriteLine("Password: ");
            var password = ConsoleHelpers.ReadPassword();

            var authapiClient = new AuthApiClient(_appConfig);
            return authapiClient.GetAccessToken(userName, password);
        }
    }
}
