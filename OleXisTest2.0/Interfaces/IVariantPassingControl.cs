using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OleXisTest
{
    interface IVariantPassingControl
    {
        bool CheckAnswer();
        AnswerListItem GetAnswerListItem(string questionName, string shortQuestionDesc);
        void SetDefaultDockStyle();
    }
}
