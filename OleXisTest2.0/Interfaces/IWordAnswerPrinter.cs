using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OleXisTest
{
    public interface IWordAnswerPrinter
    {
        void AddColumn(List<string> answers);
        void AddString(string str);
        //void AddImage();
    }
}
