using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OleXisTest
{
    [Serializable]
    public class FreeStatementQuestionAnswer : IQuestionAnswer, ICloneable
    {
        //Варианты ответа и ответы
        public string Answer 
        {
            get
            {
                return _answer;
            }
            set
            {
                if(value == null)
                    throw new ArgumentNullException("Значение Answer не должно быть null");
                _answer = value;
            }
        }
        string _answer;
        public FreeStatementQuestionAnswer()
        {
            _answer = "";
        }
        public FreeStatementQuestionAnswer(string Answer)
        {
            this.Answer = Answer;
        }

        public FreeStatementQuestionAnswer(FreeStatementQuestionAnswer answerToClone)
        {
            Answer = answerToClone.Answer;
        }

        public object Clone()
        {
            return new FreeStatementQuestionAnswer(this);
        }

        public bool ValidateAnswer()
        {
            if (_answer == "")
            {
                MessageBox.Show("Значение не может быть пустым", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
