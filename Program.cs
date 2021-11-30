using System;

namespace Labb1b_Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataReader dataReader = new FileHandler();

            string[] textArr = dataReader.ReadFile();

            foreach (var item in textArr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------------------");

            ITextHandler textHandler = new TextHandler();

            var listReversed = textHandler.ReverseText(textArr);

            foreach (var item in listReversed)
            {
                Console.WriteLine(item);
            }
        }
    }
}
