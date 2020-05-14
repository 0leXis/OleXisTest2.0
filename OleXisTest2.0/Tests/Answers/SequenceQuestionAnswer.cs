using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OleXisTest
{
    [Serializable]
    public class SequenceQuestionAnswer : IQuestionAnswer, ICloneable
    {
        //Варианты ответа и ответы
        public int QuestionScore
        {
            get
            {
                return _questionScore;
            }
            set
            {
                if (value < 1)
                    _questionScore = 1;
                else
                    _questionScore = value;
            }
        }
        int _questionScore = 1;
        public List<string> Variants { get; }

        public SequenceQuestionAnswer()
        {
            Variants = new List<string>();
        }
        public SequenceQuestionAnswer(List<string> Variants)
        {
            if (Variants == null)
                throw new ArgumentNullException("Значение Variants не должно быть null");
            this.Variants = Variants;
        }

        public SequenceQuestionAnswer(SequenceQuestionAnswer answerToClone)
        {
            Variants = new List<string>(answerToClone.Variants);
        }

        public object Clone()
        {
            return new SequenceQuestionAnswer(this);
        }

        public bool ValidateAnswer()
        {
            if (Variants.Count < 2)
            {
                MessageBox.Show("Для данного типа вопроса необходимо добавить как минимум 2 варианта ответа", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
