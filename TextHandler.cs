using System;
using System.Collections.Generic;

namespace Labb1b_Terminal
{
    public class TextHandler
    {
        public List<string> ReverseText(string[] textArr)
        {
            List<string> textArrReversed = new();

            foreach (var text in textArr)
            {
                char[] charArr = text.ToCharArray();
                Array.Reverse(charArr);
                string lineReversed = new string(charArr);

                textArrReversed.Add(lineReversed);
            }

            return textArrReversed;
        }
    }
}

