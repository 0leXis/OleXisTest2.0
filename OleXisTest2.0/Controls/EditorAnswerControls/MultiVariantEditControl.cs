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
    public partial class MultiVariantEditControl : UserControl, IVariantEditControl
    {
        //Отступы для компонентов
        public const int IndentX = 3;
        public const int IndentY = 35;

        private List<Label> VariantNumber;
        private List<TextBox> TextVariant;
        private List<Button> DeleteVariant;
        private List<CheckBox> CorrectVariantMulti;

        public MultiVariantEditControl()
        {
            InitializeComponent();
            VariantNumber = new List<Label>();
            TextVariant = new List<TextBox>();
            DeleteVariant = new List<Button>();
            CorrectVariantMulti = new List<CheckBox>();
        }

        public MultiVariantEditControl(MultiQuestionAnswer multiQuestionAnswer) : this()
        {
            for (var i = 0; i < multiQuestionAnswer.Variants.Count; i++)
            {
                AddVariant();
                TextVariant[i].Text = multiQuestionAnswer.Variants[i];
                if (multiQuestionAnswer.Answers.Contains(i))
                    CorrectVariantMulti[i].Checked = true;
            }
        }

        private void buttonAddVariant_Click(object sender, EventArgs e)
        {
            AddVariant();
        }

        private void AddVariant()
        {
            panelVariants.VerticalScroll.Value = 0;
            var controlsTop = TextVariant.Count * OleXisTest.Controls.INDENT_Y + 1;
            var currentVariantNumber = TextVariant.Count + 1;

            var tmpLabel = OleXisTest.Controls.GetLabel(currentVariantNumber + ". ", OleXisTest.Controls.VARIANTNUMBER_LABEL_WIDTH, controlsTop, panelVariants, null);
            VariantNumber.Add(tmpLabel);

            var tmpTextBox = OleXisTest.Controls.GetTextBox(OleXisTest.Controls.TEXT_BOX_WIDTH, controlsTop, panelVariants, tmpLabel);
            TextVariant.Add(tmpTextBox);

            var tmpButton = OleXisTest.Controls.GetButton("Удалить", OleXisTest.Controls.DELETE_BUTTON_SIZE, controlsTop - 1, panelVariants, tmpTextBox);
            tmpButton.Click += ButtonDeleteClick;
            DeleteVariant.Add(tmpButton);

            var tmpCheckBox = OleXisTest.Controls.GetCheckBox("Правильный вариант", OleXisTest.Controls.RADIOBUTTON_WIDTH, controlsTop, panelVariants, tmpButton);
            CorrectVariantMulti.Add(tmpCheckBox);
        }

        private void ButtonDeleteClick(object Sender, EventArgs e)
        {
            var tmp = Sender as Button;
            var index = DeleteVariant.FindIndex(x => x == tmp);

            VariantNumber[index].Dispose();
            TextVariant[index].Dispose();
            DeleteVariant[index].Dispose();
            CorrectVariantMulti[index].Dispose();

            VariantNumber.RemoveAt(index);
            TextVariant.RemoveAt(index);
            DeleteVariant.RemoveAt(index);
            CorrectVariantMulti.RemoveAt(index);

            for (var i = index; i < TextVariant.Count; i++)
            {
                VariantNumber[i].Text = (i + 1) + ". ";

                VariantNumber[i].Top -= IndentY;
                TextVariant[i].Top -= IndentY;
                DeleteVariant[i].Top -= IndentY;
                CorrectVariantMulti[i].Top -= IndentY;
            }
        }

        public IQuestionAnswer GetAnswer()
        {
            var variants = new List<string>();
            foreach (var Variant in TextVariant)
                variants.Add(Variant.Text);

            var answers = new List<int>();
            for (var i = 0; i < CorrectVariantMulti.Count; i++)
                if (CorrectVariantMulti[i].Checked)
                {
                    answers.Add(i);
                }
            return new MultiQuestionAnswer(variants, answers);
        }

        private void MultiVariantEditControl_SizeChanged(object sender, EventArgs e)
        {
            panelVariants.Height = this.Height - OleXisTest.Controls.PANEL_YLOCATION;
        }
    }
}
