using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OleXisTest
{
    static class PassingControlFactory
    {
        static public IVariantPassingControl GetPassingControl(IQuestionAnswer questionAnswer, bool isPreviewState)
        {
            if(questionAnswer is AccordanceQuestionAnswer)
                return new AccordanceVariantPassControl(questionAnswer as AccordanceQuestionAnswer, isPreviewState);
            else
            if (questionAnswer is AlternativeQuestionAnswer)
                return new AlternativeVariantPassControl(questionAnswer as AlternativeQuestionAnswer, isPreviewState);
            else
            if (questionAnswer is FreeStatementQuestionAnswer)
                return new FreeStatementPassControl(questionAnswer as FreeStatementQuestionAnswer, isPreviewState);
            else
            if (questionAnswer is MultiQuestionAnswer)
                return new MultiVariantPassControl(questionAnswer as MultiQuestionAnswer, isPreviewState);
            else
            if (questionAnswer is SingleQuestionAnswer)
                return new SingleVariantPassControl(questionAnswer as SingleQuestionAnswer, isPreviewState);
            else
            if (questionAnswer is SequenceQuestionAnswer)
                return new SequenceVariantPassControl(questionAnswer as SequenceQuestionAnswer, isPreviewState);
            throw new ArgumentException("Для данного типа questionAnswer не найден соответствующий элемент управления");
        }
    }
}
