using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NetClasses;

namespace OleXisTest
{
    public partial class AnswerListDialog : Form
    {
        //Элементы, отображающие информацию
        List<Label> Ansvers = new List<Label>();
        public AnswerListDialog(List<AnswerListItem> answers)
        {
            InitializeComponent();
            var graphics = CreateGraphics();
            foreach (var answer in answers)
            {
                var description = answer.IsRight ? answer.QuestionDescription + " (" + answer.Question_score + " баллов)" : answer.QuestionDescription + "(0 из " + answer.Question_score + " баллов)";
                Ansvers.Add(OleXisTest.Controls.GetLabelYSequence(description, OleXisTest.Controls.INDENT_X, OleXisTest.Controls.GetStringWidth(description, graphics) + 50, OleXisTest.Controls.GetStringHeight(description, graphics), panel, Ansvers.Count > 0 ? Ansvers.Last() : null));
                foreach (var variant in answer.Variants)
                {
                    var label = OleXisTest.Controls.GetLabelYSequence("   " + variant.VariantText, OleXisTest.Controls.INDENT_X, OleXisTest.Controls.GetStringWidth("   " + variant.VariantText, graphics) + 50, OleXisTest.Controls.GetStringHeight("   " + variant.VariantText, graphics), panel, Ansvers.Count > 0 ? Ansvers.Last() : null);
                    switch (variant.Type)
                    {
                        case AnswerVariations.WrongAnswerNotChoosed:
                            break;
                        case AnswerVariations.RightAnswerChoosed:
                            label.ForeColor = Color.Green;
                            break;
                        case AnswerVariations.RightAnswerNotChoosed:
                            label.ForeColor = Color.Red;
                            break;
                        case AnswerVariations.WrongAnswerChoosed:
                            label.ForeColor = Color.DarkRed;
                            break;
                        default:
                            throw new ArgumentException("Невозможно определить цвет Label для данного значения типа AnswerVariations");
                    }
                    Ansvers.Add(label);
                }
                Ansvers.Last().Height += 10;
            }
        }
    }
}
