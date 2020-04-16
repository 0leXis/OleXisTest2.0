using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OleXisTest
{
    [Serializable]
    public class SingleQuestionAnswer : IQuestionAnswer, ICloneable
    {
        //Варианты ответа и ответы
        public List<string> Variants { get; }
        public int Answer { get; set; }

        public SingleQuestionAnswer() 
        {
            Variants = new List<string>();
        }
        public SingleQuestionAnswer(List<string> Variants, int Answer)
        {
            if (Variants == null)
                throw new ArgumentNullException("Значение Variants не должно быть null");
            this.Variants = Variants;
            this.Answer = Answer;
        }

        public SingleQuestionAnswer(SingleQuestionAnswer answerToClone)
        {
            Variants = new List<string>(answerToClone.Variants);
            Answer = answerToClone.Answer;
        }

        public object Clone()
        {
            return new SingleQuestionAnswer(this);
        }
        public bool ValidateAnswer()
        {
            if (Variants.Count < 2)
            {
                MessageBox.Show("Для данного типа вопроса необходимо добавить как минимум 2 варианта ответа", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(Answer < 0 || Answer > Variants.Count - 1)
            {
                MessageBox.Show("Номер правильного ответа не совпадает с порядковым номером варианта ответа", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
