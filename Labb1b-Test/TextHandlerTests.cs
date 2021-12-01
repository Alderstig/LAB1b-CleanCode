using Labb1b_Terminal;
using Moq;
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
        private string[] _list = new string[] { "Philip", "Lars", "Sven", "Alfred", "Göran" };

        [Test]
        public void ReverseText_ReverseLinesFromTextArray_ReturnsTrueIfReversedCorrectly()
        {
            Mock<IDataReader> mock = new Mock<IDataReader>();
            mock.Setup(x => x.ReadFile()).Returns(_list);

            IDataReader fileHandler = mock.Object;

            var textArr = fileHandler.ReadFile();

            TextHandler textHandler = new TextHandler();
            var reversedTextList = textHandler.ReverseText(textArr);

            CollectionAssert.AreEqual(reversedTextList, _correctlyReversedList);
        }
    }
}
