using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OleXisTest
{
    static class InfoViewFactory
    {
        static public IQuestionInfoView GetInfoViewControl(IQuestionInfo info)
        {
            if (info is SimpleQuestionInfo)
                return new SimpleQuestionInfoView(info as SimpleQuestionInfo);
            throw new ArgumentException("Для данного типа info не найден соответствующий элемент управления");
        }
    }
}
