using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OleXisTest
{
    interface IInfoEditControl
    {
        IQuestionInfo GetInfo();
        bool ValidateInfo();
    }
}
