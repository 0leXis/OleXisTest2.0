using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OleXisTest
{
    public partial class AlternativeVariantPassControl : UserControl, IVariantPassingControl
    {
        AlternativeQuestionAnswer answer;
        public AlternativeVariantPassControl(AlternativeQuestionAnswer alternativeQuestionAnswer, bool isPreviewState)
        {
            InitializeComponent();
            answer = alternativeQuestionAnswer;
            if (isPreviewState)
            {
                if (alternativeQuestionAnswer.IsYesAnswer)
                    radioButtonYes.Checked = true;
                else
                    radioButtonNo.Checked = true;
                radioButtonYes.AutoCheck = false;
                radioButtonNo.AutoCheck = false;
            }
        }

        public bool CheckAnswer()
        {
            if (answer.IsYesAnswer && radioButtonYes.Checked || !(answer.IsYesAnswer || radioButtonYes.Checked))
                return true;
            else
                return false;
        }

        public bool ValidateAnswer()
        {
            if (!radioButtonYes.Checked && !radioButtonNo.Checked)
            {
                MessageBox.Show("Вы не выбрали вариант ответа", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public AnswerListItem GetAnswerListItem(string questionName, string shortQuestionDesc)
        {
            var answerListItem = new AnswerListItem();
            answerListItem.IsRight = true;
            answerListItem.QuestionName = questionName;
            answerListItem.Question_score = answer.QuestionScore;
            answerListItem.QuestionDescription = shortQuestionDesc;
            if (answer.IsYesAnswer && radioButtonYes.Checked)
            {
                answerListItem.Variants.Add(new AnswerListVariant(AnswerVariations.RightAnswerChoosed, "Да"));
                answerListItem.Variants.Add(new AnswerListVariant(AnswerVariations.WrongAnswerNotChoosed, "Нет"));
            }
            else
            if(!(answer.IsYesAnswer || radioButtonYes.Checked))
            {
                answerListItem.Variants.Add(new AnswerListVariant(AnswerVariations.RightAnswerChoosed, "Нет"));
                answerListItem.Variants.Add(new AnswerListVariant(AnswerVariations.WrongAnswerNotChoosed, "Да"));
            }
            else
            if (radioButtonYes.Checked)
            {
                answerListItem.Variants.Add(new AnswerListVariant(AnswerVariations.RightAnswerNotChoosed, "Нет"));
                answerListItem.Variants.Add(new AnswerListVariant(AnswerVariations.WrongAnswerChoosed, "Да"));
                answerListItem.IsRight = false;
            }
            else
            {
                answerListItem.Variants.Add(new AnswerListVariant(AnswerVariations.RightAnswerNotChoosed, "Да"));
                answerListItem.Variants.Add(new AnswerListVariant(AnswerVariations.WrongAnswerChoosed, "Нет"));
                answerListItem.IsRight = false;
            }
            return answerListItem;
        }

        public void SetDefaultDockStyle()
        {
            Dock = DockStyle.None;
        }
    }
}
