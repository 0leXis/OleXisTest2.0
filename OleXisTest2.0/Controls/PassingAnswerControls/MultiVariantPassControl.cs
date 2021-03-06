﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NetClasses;

namespace OleXisTest
{
    public partial class MultiVariantPassControl : UserControl, IVariantPassingControl
    {
        private List<CheckBox> VariantMulti;
        MultiQuestionAnswer answer;
        public MultiVariantPassControl(MultiQuestionAnswer multiQuestionAnswer, bool isPreviewState)
        {
            InitializeComponent();
            answer = multiQuestionAnswer;
            VariantMulti = new List<CheckBox>();
            //Добавление вариантов в случайном порядке
            var added_indexes = new HashSet<int>();
            var rnd = new Random();
            var graphics = CreateGraphics();
            for (var i = 0; i < multiQuestionAnswer.Variants.Count; i++)
            {
                int index;
                do
                    index = rnd.Next(0, multiQuestionAnswer.Variants.Count);
                while (added_indexes.Contains(index));
                added_indexes.Add(index);
                VariantMulti.Add(OleXisTest.Controls.GetCheckBox(multiQuestionAnswer.Variants[i], OleXisTest.Controls.GetStringWidth(multiQuestionAnswer.Variants[i], graphics) + 20, index * OleXisTest.Controls.PASSING_RADIOBUTTON_INDENT_Y, this));
                if (isPreviewState)
                {
                    VariantMulti.Last().AutoCheck = false;
                    if (multiQuestionAnswer.Answers.Contains(i))
                        VariantMulti.Last().Checked = true;
                }
            }
        }

        public bool CheckAnswer()
        {
            for(var i = 0; i < answer.Answers.Count; i++)
                if (!VariantMulti[answer.Answers[i]].Checked)
                    return false;
            return true;
        }

        public bool ValidateAnswer()
        {
            for (var i = 0; i < VariantMulti.Count; i++)
                if (VariantMulti[i].Checked)
                    return true;
            MessageBox.Show("Вы должны выбрать как минимум 1 вариант ответа", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (VariantMulti[i].Checked && answer.Answers.Contains(i))
                    answerListItem.Variants.Add(new AnswerListVariant(AnswerVariations.RightAnswerChoosed, answer.Variants[i]));
                else
                if (VariantMulti[i].Checked && !answer.Answers.Contains(i))
                {
                    answerListItem.Variants.Add(new AnswerListVariant(AnswerVariations.WrongAnswerChoosed, answer.Variants[i]));
                    answerListItem.IsRight = false;
                }
                else
                if (!VariantMulti[i].Checked && answer.Answers.Contains(i))
                {
                    answerListItem.Variants.Add(new AnswerListVariant(AnswerVariations.RightAnswerNotChoosed, answer.Variants[i]));
                    answerListItem.IsRight = false;
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
