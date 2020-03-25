using System;
using System.Text;

namespace Tedee.Api.CodeSamples
{
    public static class ConsoleHelpers
    {
        public static string ReadPassword()
        {
            var builder = new StringBuilder();
            while (true)
            {
                var cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }

                if (cki.Key == ConsoleKey.Backspace)
                {
                    if (builder.Length > 0)
                    {
                        Console.Write("\b\0\b");
                        builder.Length--;
                    }

                    continue;
                }

                Console.Write('*');
                builder.Append(cki.KeyChar);
            }

            return builder.ToString();
        }
    }
}
