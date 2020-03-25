using System;
using System.Threading.Tasks;
using Tedee.Api.CodeSamples.Actions;
using Tedee.Api.CodeSamples.Models;

namespace Tedee.Api.CodeSamples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Tedee's api code samples.");
            Console.WriteLine("=========================");
            Console.WriteLine(string.Empty);

            var appConfig = new AppConfig();
            var authApiClient = new AuthenticationActions(appConfig);
            var jwt = await authApiClient.Authenticate();
            var apiClient = new ApiHttpClient(appConfig, jwt);

            Console.WriteLine("You're authenticated!");
            await SelectAction(apiClient);
        }

        private static async Task SelectAction(ApiHttpClient apiClient)
        {
            Console.WriteLine("What would you like to do now?");
            Console.WriteLine("0. Exit.");
            Console.WriteLine("1. Get devices count.");
            var action = Console.ReadLine();

            switch (action)
            {
                case "0":
                    return;
                case "1":
                    var devicesActions = new DeviceActions(apiClient);
                    await devicesActions.GetDevicesCount();
                    break;
                default:
                    Console.WriteLine("I don't know this action. Please provide the action number.");
                    await SelectAction(apiClient);
                    break;
            }

            await SelectAction(apiClient);
        }
    }
}
