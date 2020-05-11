﻿using System;
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

        public IAnswerListItem GetAnswerListItem(string short_question_desc = null)
        {
            var answerListItem = new AnswerListItem();
            answerListItem.IsRight = true;
            //TODO: Система баллов
            answerListItem.Question_score = 1;
            if (short_question_desc != null)
                answerListItem.QuestionDescription = short_question_desc;
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