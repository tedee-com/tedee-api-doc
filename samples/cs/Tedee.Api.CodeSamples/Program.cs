using System;
using System.Threading.Tasks;
using Tedee.Api.CodeSamples.Actions;

namespace Tedee.Api.CodeSamples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Tedee's api code samples.");
            Console.WriteLine("=========================");
            Console.WriteLine(string.Empty);

            await SelectAction();
        }

        private static async Task SelectAction()
        {
            Console.WriteLine("What would you like to do now?");
            Console.WriteLine("0. Exit.");
            Console.WriteLine("1. Authenticate with JWT.");
            var action = Console.ReadLine();

            switch (action)
            {
                case "0":
                    return;
                case "1":
                    await S01AuthenticateUsingJWT.Authenticate();
                    break;
                default:
                    Console.WriteLine("Provided action is incorrect. Please provide the action number.");
                    break;
            }

            Console.WriteLine(string.Empty);

            await SelectAction();
        }
    }
}
