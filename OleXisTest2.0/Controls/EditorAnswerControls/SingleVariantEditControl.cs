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
    public partial class SingleVariantEditControl : UserControl, IVariantEditControl
    {
        private List<Label> VariantNumber;
        private List<TextBox> TextVariant;
        private List<Button> DeleteVariant;
        private List<RadioButton> CorrectVariantSingle;

        public SingleVariantEditControl()
        {
            InitializeComponent();
            VariantNumber = new List<Label>();
            TextVariant = new List<TextBox>();
            DeleteVariant = new List<Button>();
            CorrectVariantSingle = new List<RadioButton>();
        }

        public SingleVariantEditControl(SingleQuestionAnswer singleQuestionAnswer) : this()
        {
            for (var i = 0; i < singleQuestionAnswer.Variants.Count; i++)
            {
                AddVariant();
                TextVariant[i].Text = singleQuestionAnswer.Variants[i];
            }
            if(CorrectVariantSingle.Count > 0)
                CorrectVariantSingle[singleQuestionAnswer.Answer].Checked = true;
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

            var tmpRadioButton = OleXisTest.Controls.GetRadioButton("Правильный вариант", OleXisTest.Controls.RADIOBUTTON_WIDTH, controlsTop, panelVariants, tmpButton);
            CorrectVariantSingle.Add(tmpRadioButton);
        }

        private void ButtonDeleteClick(object Sender, EventArgs e)
        {
            var tmp = Sender as Button;
            var index = DeleteVariant.FindIndex(x => x == tmp);

            VariantNumber[index].Dispose();
            TextVariant[index].Dispose();
            DeleteVariant[index].Dispose();
            CorrectVariantSingle[index].Dispose();

            VariantNumber.RemoveAt(index);
            TextVariant.RemoveAt(index);
            DeleteVariant.RemoveAt(index);
            CorrectVariantSingle.RemoveAt(index);

            for (var i = index; i < TextVariant.Count; i++)
            {
                VariantNumber[i].Text = (i + 1) + ". ";

                VariantNumber[i].Top -= OleXisTest.Controls.INDENT_Y;
                TextVariant[i].Top -= OleXisTest.Controls.INDENT_Y;
                DeleteVariant[i].Top -= OleXisTest.Controls.INDENT_Y;
                CorrectVariantSingle[i].Top -= OleXisTest.Controls.INDENT_Y;
            }
        }

        public IQuestionAnswer GetAnswer()
        {
            var variants = new List<string>();
            foreach (var Variant in TextVariant)
                variants.Add(Variant.Text);
            var answer = 0;
            for (var i = 0; i < CorrectVariantSingle.Count; i++)
                if (CorrectVariantSingle[i].Checked)
                {
                    answer = i;
                    break;
                }
            return new SingleQuestionAnswer(variants, answer);
        }

        private void SingleVariantEditControl_SizeChanged(object sender, EventArgs e)
        {
            panelVariants.Height = this.Height - OleXisTest.Controls.PANEL_YLOCATION;
        }
    }
}
