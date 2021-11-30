using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1b_Terminal
{
    public interface IDataReader
    {
        string[] GetStrings();
        string[] ReadFile();
    }
}
