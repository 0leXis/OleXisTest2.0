using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OleXisTest
{
    static class EditableControlFactory
    {
        static public IVariantEditControl GetEditableControl(IQuestionAnswer answer)
        {
            if(answer is AccordanceQuestionAnswer)
                return new AccordanceVariantEditControl(answer as AccordanceQuestionAnswer);
            else
            if (answer is AlternativeQuestionAnswer)
                return new AlternativeVariantEditControl(answer as AlternativeQuestionAnswer);
            else
            if (answer is FreeStatementQuestionAnswer)
                return new FreeStatementVariantEditControl(answer as FreeStatementQuestionAnswer);
            else
            if (answer is MultiQuestionAnswer)
                return new MultiVariantEditControl(answer as MultiQuestionAnswer);
            else
            if (answer is SingleQuestionAnswer)
                return new SingleVariantEditControl(answer as SingleQuestionAnswer);
            else
            if (answer is SequenceQuestionAnswer)
                return new SequenceVariantEditControl(answer as SequenceQuestionAnswer);
            throw new ArgumentException("Для данного типа answer не найден соответствующий элемент управления");
        }
    }
}
