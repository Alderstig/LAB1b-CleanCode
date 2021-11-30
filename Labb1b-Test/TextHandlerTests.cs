using Labb1b_Terminal;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1b_Test
{
    [TestFixture]
    public class TextHandlerTests
    {
        private List<string> _correctlyReversedList = new List<string> { "pilihP", "sraL", "nevS", "derflA", "naröG" };

        [Test]
        public void ReverseText_ReverseLinesFromTextArray_ReturnsTrueIfReversedCorrectly()
        {
            IDataReader fileHandler = new FileHandler();
            var textArr = fileHandler.ReadFile();

            ITextHandler textHandler = new TextHandler();
            var reversedTextList = textHandler.ReverseText(textArr);

            CollectionAssert.AreEqual(reversedTextList, _correctlyReversedList);
        }
    }
}
