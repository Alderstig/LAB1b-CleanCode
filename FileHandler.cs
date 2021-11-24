using System;
using System.IO;

namespace Labb1b_Terminal
{
    public class FileHandler
    {
        public string[] ReadFile()
        {
            try
            {
                //Change relative path so that it matches your repo
                string[] textArr = File.ReadAllLines(@"C:\Users\alder\source\repos\LAB1b-CleanCode\indata.txt");

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

