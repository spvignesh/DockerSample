using System;
using System.Threading;

namespace ConsoleApp_DotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Thread.Sleep(2000);
                Console.WriteLine(GetCharacter());
            }
        }

        private static char GetCharacter()
        {
            const string chars= @"qwertyuiopasdfghjklzxcvbnm1234567890";
            var random = new Random();
            var num = random.Next(0, chars.Length - 1);
            return chars[num];
        }
    }
}
