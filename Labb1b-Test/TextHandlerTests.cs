using System;
using System.Collections.Generic;
using Labb1b_Terminal;
using NUnit.Framework;

namespace Labb1b_Test
{
    [TestFixture]
    public class TextHandlerTests
    {
        private List<string> _correctlyReversedList = new List<string> { "pilihP", "sraL", "nevS", "derflA", "naröG" };

        [Test]
        public void ReverseText_ReverseLinesFromTextArray_ReturnsTrueIfReversedCorrectly()
        {
            FileHandler fileHandler = new FileHandler();
            var textArr = fileHandler.ReadFile();

            TextHandler textHandler = new TextHandler();
            var reversedTextList = textHandler.ReverseText(textArr);

            for (int i = 0; i < reversedTextList.Count; i++)
            {
                Assert.That(reversedTextList[i], Is.EqualTo(_correctlyReversedList[i]));
            }
        }
    }
}

