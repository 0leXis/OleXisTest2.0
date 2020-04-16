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
    public partial class FreeStatementPassControl : UserControl, IVariantPassingControl
    {
        FreeStatementQuestionAnswer answer;
        public FreeStatementPassControl(FreeStatementQuestionAnswer freeStatementQuestionAnswer, bool isPreviewState)
        {
            InitializeComponent();
            answer = freeStatementQuestionAnswer;
            if (isPreviewState)
            {
                textBoxAnswer.Text = freeStatementQuestionAnswer.Answer;
                textBoxAnswer.KeyPress += textBoxAnswer_KeyPress;
            }
        }

        public bool CheckAnswer()
        {
            if (answer.Answer != textBoxAnswer.Text)
                return false;
            return true;
        }

        public IAnswerListItem GetAnswerListItem(string short_question_desc = null)
        {
            var answerListItem = new AnswerListItem();
            answerListItem.IsRight = true;
            //TODO: Система баллов
            answerListItem.Question_score = 1;
            if (short_question_desc != null)
                answerListItem.QuestionDescription = short_question_desc;
            if (answer.Answer == textBoxAnswer.Text)
                answerListItem.Variants.Add(new AnswerListVariant(AnswerVariations.RightAnswerChoosed, textBoxAnswer.Text));
            else
            {
                answerListItem.Variants.Add(new AnswerListVariant(AnswerVariations.WrongAnswerChoosed, "Ваш ответ: " + textBoxAnswer.Text));
                answerListItem.Variants.Add(new AnswerListVariant(AnswerVariations.WrongAnswerChoosed, "Правильный ответ: " + answer.Answer));
                answerListItem.IsRight = false;
            }
            return answerListItem;
        }

        private void textBoxAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public void SetDefaultDockStyle()
        {
            Dock = DockStyle.None;
        }
    }
}
