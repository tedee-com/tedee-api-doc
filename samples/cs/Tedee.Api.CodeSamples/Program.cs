using System;
using System.Threading.Tasks;

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
            var action = Console.ReadLine();

            switch (action)
            {
                case "0":
                    return;
                default:
                    Console.WriteLine("Provided action is incorrect. Please provide the action number.");
                    break;
            }

            Console.WriteLine(string.Empty);

            await SelectAction();
        }
    }
}
