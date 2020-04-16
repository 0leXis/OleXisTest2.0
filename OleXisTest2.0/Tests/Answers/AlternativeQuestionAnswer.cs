using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OleXisTest
{
    [Serializable]
    public class AlternativeQuestionAnswer : IQuestionAnswer, ICloneable
    {
        //Варианты ответа и ответы
        public bool IsYesAnswer { get; set; }

        public AlternativeQuestionAnswer() : this(true) { }
        public AlternativeQuestionAnswer(bool IsYesAnswer)
        {
            this.IsYesAnswer = IsYesAnswer;
        }

        public AlternativeQuestionAnswer(AlternativeQuestionAnswer answerToClone)
        {
            IsYesAnswer = answerToClone.IsYesAnswer;
        }

        public object Clone()
        {
            return new AlternativeQuestionAnswer(this);
        }

        public bool ValidateAnswer()
        {
            return true;
        }
    }
}
