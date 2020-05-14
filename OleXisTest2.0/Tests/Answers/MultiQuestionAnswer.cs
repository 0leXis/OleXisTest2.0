using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OleXisTest
{
    [Serializable]
    public class MultiQuestionAnswer : IQuestionAnswer
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
        public List<int> Answers { get; }

        public MultiQuestionAnswer()
        {
            Variants = new List<string>();
            Answers = new List<int>();
        }
        public MultiQuestionAnswer(List<string> Variants, List<int> Answers)
        {
            if (Variants == null)
                throw new ArgumentNullException("Значение Variants не должно быть null");
            if(Answers == null)
                throw new ArgumentNullException("Значение Answers не должно быть null");
            this.Variants = Variants;
            this.Answers = Answers;
        }

        public MultiQuestionAnswer(MultiQuestionAnswer answerToClone)
        {
            Variants = new List<string>(answerToClone.Variants);
            Answers = new List<int>(answerToClone.Answers);
        }

        public object Clone()
        {
            return new MultiQuestionAnswer(this);
        }

        public bool ValidateAnswer()
        {
            if (Variants.Count < 2)
            {
                MessageBox.Show("Для данного типа вопроса необходимо добавить как минимум 2 варианта ответа", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            foreach(var answer in Answers)
                if (answer < 0 || answer > Variants.Count - 1)
                {
                    MessageBox.Show("Номер правильного ответа не совпадает с порядковым номером варианта ответа", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            return true;
        }
    }
}
