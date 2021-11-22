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
                string[] textArr = File.ReadAllLines(@"/Users/philipalderstig/Projects/Labb1b-Terminal/indata.txt");

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

