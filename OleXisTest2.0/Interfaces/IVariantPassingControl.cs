using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OleXisTest
{
    interface IVariantPassingControl
    {
        bool CheckAnswer();
        IAnswerListItem GetAnswerListItem(string short_question_desc = null);
        void SetDefaultDockStyle();
    }
}
