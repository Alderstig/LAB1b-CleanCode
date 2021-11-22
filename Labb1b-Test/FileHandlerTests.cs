using System;
using Labb1b_Terminal;
using NUnit.Framework;

namespace Labb1b_Test
{
    [TestFixture]
    public class FileHandlerTests
    {
        [Test]
        public void ReadFile_ReadLinesFromLocalTxtFile_ReturnsTrueIfNotNull()
        {
            FileHandler fileHandler = new FileHandler();
            var textArr = fileHandler.ReadFile();

            Assert.NotNull(textArr);
        }
    }
}

