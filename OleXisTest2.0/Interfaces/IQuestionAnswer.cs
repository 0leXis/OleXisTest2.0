using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace OleXisTest
{
    public interface IQuestionAnswer
    {
        int QuestionScore { get; set; }
        bool ValidateAnswer();
        string GetQuestionTaskInfo();
        void ToWord(IWordAnswerPrinter printer);
    }
}
