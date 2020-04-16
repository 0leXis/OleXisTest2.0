using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OleXisTest
{
    public interface ITestSaveProvider
    {
        bool Save(ITest test);
        ITest Load(string password = null);
    }
}
