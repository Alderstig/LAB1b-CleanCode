using System;
using System.IO;

namespace Labb1b_Terminal
{
    public class FileHandler : IDataReader
    {
        public string[] GetStrings()
        { 
            //Change path so that it matches your repo
            string[] textArr = File.ReadAllLines(@"C:\Users\alder\Source\Repos\LAB1b-CleanCode\indata.txt");

            return textArr;
        }

        public string[] ReadFile()
        {
            try
            {
                string[] textArr = GetStrings();

                if (textArr.Length == 0)
                {
                    throw new Exception("File is empty");
                }
                else
                {
                    return textArr;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }
    }
}

