using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OleXisTest
{
    [Serializable]
    public class AccordanceQuestionAnswer : IQuestionAnswer, ICloneable
    {
        //Варианты ответа и ответы
        public List<string> Variants { get; }
        public List<string> Accordances { get; }

        public AccordanceQuestionAnswer()
        {
            Variants = new List<string>();
            Accordances = new List<string>();
        }
        public AccordanceQuestionAnswer(List<string> Variants, List<string> Accordances)
        {
            if (Variants == null)
                throw new ArgumentNullException("Значение Answer не должно быть null");
            if (Accordances == null)
                throw new ArgumentNullException("Значение Answer не должно быть null");
            this.Variants = Variants;
            this.Accordances = Accordances;
        }

        public AccordanceQuestionAnswer(AccordanceQuestionAnswer answerToClone)
        {
            Variants = new List<string>(answerToClone.Variants);
            Accordances = new List<string>(answerToClone.Accordances);
        }

        public object Clone()
        {
            return new AccordanceQuestionAnswer(this);
        }

        public bool ValidateAnswer()
        {
            if (Variants.Count < 2 || Accordances.Count < 2)
            {
                MessageBox.Show("Для данного типа вопроса необходимо добавить как минимум 2 варианта ответа и соответствия", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Variants.Count != Accordances.Count)
            {
                MessageBox.Show("Число вариантов и соответствий не совпадает", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
