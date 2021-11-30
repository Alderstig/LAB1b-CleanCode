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
    public class FileHandlerTests
    {
        [Test]
        public void ReadFile_ReadLinesFromLocalTxtFile_ReturnsTrueIfNotNull()
        {
            IDataReader dataReader = new FileHandler();
            var textArr = dataReader.ReadFile();

            Assert.NotNull(textArr);
        }
    }
}
