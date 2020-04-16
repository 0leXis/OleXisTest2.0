using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OleXisTest
{
    public interface ITest
    {
        List<IQuestion> Questions { get; }
        List<string> Sections { get; }
        TestParams Params { get; }

        void InitSerializedTest();
    }
}
