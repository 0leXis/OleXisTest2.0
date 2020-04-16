using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OleXisTest
{
    static class InfoEditableControlFactory
    {
        static public IInfoEditControl GetInfoEditableControl(IQuestionInfo info)
        {
            if (info is SimpleQuestionInfo)
                return new SimpleInfoEditControl(info as SimpleQuestionInfo);
            throw new ArgumentException("Для данного типа info не найден соответствующий элемент управления");
        }
    }
}
