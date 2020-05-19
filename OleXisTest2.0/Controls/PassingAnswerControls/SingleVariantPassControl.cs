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
    public partial class SingleVariantPassControl : UserControl, IVariantPassingControl
    {
        private List<RadioButton> VariantSingle;
        SingleQuestionAnswer answer;
        public SingleVariantPassControl(SingleQuestionAnswer singleQuestionAnswer, bool isPreviewState)
        {
            InitializeComponent();
            answer = singleQuestionAnswer;
            VariantSingle = new List<RadioButton>();
            //Добавление вариантов в случайном порядке
            var added_indexes = new HashSet<int>();
            var rnd = new Random();
            var graphics = CreateGraphics();
            for (var i = 0; i < singleQuestionAnswer.Variants.Count; i++)
            {
                int index;
                do
                    index = rnd.Next(0, singleQuestionAnswer.Variants.Count);
                while (added_indexes.Contains(index));
                added_indexes.Add(index);
                VariantSingle.Add(OleXisTest.Controls.GetRadioButton(singleQuestionAnswer.Variants[i], OleXisTest.Controls.GetStringWidth(singleQuestionAnswer.Variants[i], graphics) + 20, index * OleXisTest.Controls.PASSING_RADIOBUTTON_INDENT_Y, this));
                if (isPreviewState)
                {
                    VariantSingle.Last().AutoCheck = false;
                }
            }
            if (isPreviewState)
                VariantSingle[singleQuestionAnswer.Answer].Checked = true;
        }

        public bool CheckAnswer()
        {
            if (!VariantSingle[answer.Answer].Checked)
                return false;
            return true;
        }

        public bool ValidateAnswer()
        {
            for (var i = 0; i < VariantSingle.Count; i++)
                if (VariantSingle[i].Checked)
                    return true;
            MessageBox.Show("Вы должны выбрать вариант ответа", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public AnswerListItem GetAnswerListItem(string questionName, string shortQuestionDesc)
        {
            var answerListItem = new AnswerListItem();
            answerListItem.IsRight = true;
            answerListItem.QuestionName = questionName;
            answerListItem.Question_score = answer.QuestionScore;
            answerListItem.QuestionDescription = shortQuestionDesc;
            for (var i = 0; i < answer.Variants.Count; i++)
                if (VariantSingle[i].Checked && answer.Answer == i)
                    answerListItem.Variants.Add(new AnswerListVariant(AnswerVariations.RightAnswerChoosed, answer.Variants[i]));
                else
                if (VariantSingle[i].Checked && answer.Answer != i)
                {
                    answerListItem.IsRight = false;
                    answerListItem.Variants.Add(new AnswerListVariant(AnswerVariations.WrongAnswerChoosed, answer.Variants[i]));
                }
                else
                if (!VariantSingle[i].Checked && answer.Answer == i)
                {
                    answerListItem.IsRight = false;
                    answerListItem.Variants.Add(new AnswerListVariant(AnswerVariations.RightAnswerNotChoosed, answer.Variants[i]));
                }
                else
                    answerListItem.Variants.Add(new AnswerListVariant(AnswerVariations.WrongAnswerNotChoosed, answer.Variants[i]));
            return answerListItem;
        }

        public void SetDefaultDockStyle()
        {
            Dock = DockStyle.Fill;
        }
    }
}
