using System;

namespace Labb1b_Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHandler fileHandler = new();

            string[] textArr = fileHandler.ReadFile();

            foreach (var item in textArr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------------------");

            TextHandler textHandler = new();

            var listReversed = textHandler.ReverseText(textArr);

            foreach (var item in listReversed)
            {
                Console.WriteLine(item);
            }
        }
    }
}
