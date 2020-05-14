using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OleXisTest
{
    public interface IQuestionAnswer
    {
        int QuestionScore { get; set; }
        bool ValidateAnswer();
    }
}
