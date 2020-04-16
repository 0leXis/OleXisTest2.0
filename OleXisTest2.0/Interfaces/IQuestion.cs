using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace OleXisTest
{
    public interface IQuestion
    {
        string Section { get; set; }
        string Name { get; set; }
        IQuestionInfo QuestionInfo { get; set; }
        IQuestionAnswer QuestionAnswer { get; set; }
        MemoryStream Serialize();
    }
}
