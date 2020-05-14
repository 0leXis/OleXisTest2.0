using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OleXisTest
{
    public partial class AnswerListDialog : Form
    {
        //Элементы, отображающие информацию
        List<Label> Ansvers = new List<Label>();
        public AnswerListDialog(List<IAnswerListItem> answers)
        {
            InitializeComponent();
            var graphics = CreateGraphics();
            foreach (var answer in answers)
            {
                var description = answer.IsRight ? answer.QuestionDescription + " (" + answer.Question_score + " баллов)" : answer.QuestionDescription + "(0 из " + answer.Question_score + " баллов)";
                Ansvers.Add(OleXisTest.Controls.GetLabel(description, OleXisTest.Controls.GetStringWidth(description, graphics) + 50, Ansvers.Count * OleXisTest.Controls.INDENT_Y, panel));
                foreach (var variant in answer.Variants)
                {
                    var label = OleXisTest.Controls.GetLabel("   " + variant.VariantText, OleXisTest.Controls.GetStringWidth("   " + variant.VariantText, graphics) + 50, Ansvers.Count * OleXisTest.Controls.INDENT_Y, panel);
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
            }
        }
    }
}
