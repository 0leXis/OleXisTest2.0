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
    public partial class AccordanceVariantEditControl : UserControl, IVariantEditControl
    {
        //Отступы для компонентов
        public const int IndentX = 3;
        public const int IndentY = 35;

        List<Label> VariantNumber;
        List<TextBox> Accordance1Text;
        List<TextBox> Accordance2Text;
        List<Button> DeleteVariant;
        public AccordanceVariantEditControl()
        {
            InitializeComponent();
            VariantNumber = new List<Label>();
            Accordance1Text = new List<TextBox>();
            Accordance2Text = new List<TextBox>();
            DeleteVariant = new List<Button>();
        }

        public AccordanceVariantEditControl(AccordanceQuestionAnswer accordanceQuestionAnswer) : this()
        {
            for (var i = 0; i < accordanceQuestionAnswer.Variants.Count; i++)
            {
                buttonAddVariant_Click(this, new EventArgs());
                Accordance1Text[i].Text = accordanceQuestionAnswer.Variants[i];
                Accordance2Text[i].Text = accordanceQuestionAnswer.Accordances[i];
            }
        }

        private void buttonAddVariant_Click(object sender, EventArgs e)
        {
            AddVariant();
        }

        private void AddVariant()
        {
            panelVariants.VerticalScroll.Value = 0;
            var controlsTop = Accordance1Text.Count * OleXisTest.Controls.INDENT_Y;
            var currentVariantNumber = Accordance1Text.Count + 1;

            var tmpLabel = OleXisTest.Controls.GetLabel(currentVariantNumber + ". ", OleXisTest.Controls.VARIANTNUMBER_LABEL_WIDTH, controlsTop, panelVariants, null);
            VariantNumber.Add(tmpLabel);

            var tmpTextBox = OleXisTest.Controls.GetTextBox(OleXisTest.Controls.TEXT_BOX_WIDTH, controlsTop, panelVariants, tmpLabel);
            Accordance1Text.Add(tmpTextBox);

            tmpTextBox = OleXisTest.Controls.GetTextBox(OleXisTest.Controls.TEXT_BOX_WIDTH, controlsTop, panelVariants, tmpTextBox);
            Accordance2Text.Add(tmpTextBox);

            var tmpButton = OleXisTest.Controls.GetButton("Удалить", OleXisTest.Controls.DELETE_BUTTON_SIZE, controlsTop - 1, panelVariants, tmpTextBox);
            tmpButton.Click += ButtonDeleteClick;
            DeleteVariant.Add(tmpButton);
        }

        private void ButtonDeleteClick(object Sender, EventArgs e)
        {
            var tmp = Sender as Button;
            var index = DeleteVariant.FindIndex(x => x == tmp);

            VariantNumber[index].Dispose();
            Accordance1Text[index].Dispose();
            DeleteVariant[index].Dispose();
            Accordance2Text[index].Dispose();

            VariantNumber.RemoveAt(index);
            Accordance1Text.RemoveAt(index);
            DeleteVariant.RemoveAt(index);
            Accordance2Text.RemoveAt(index);

            for (var i = index; i < Accordance1Text.Count; i++)
            {
                VariantNumber[i].Text = (i + 1) + ". ";

                VariantNumber[i].Top -= IndentY;
                Accordance1Text[i].Top -= IndentY;
                DeleteVariant[i].Top -= IndentY;
                Accordance2Text[i].Top -= IndentY;
            }
        }

        public IQuestionAnswer GetAnswer()
        {
            var variants = new List<string>();
            var accordances = new List<string>();
            for (var i = 0; i < Accordance1Text.Count; i++)
            {
                variants.Add(Accordance1Text[i].Text);
                accordances.Add(Accordance2Text[i].Text);
            }
            return new AccordanceQuestionAnswer(variants, accordances);
        }

        private void AccordanceVariantEditControl_SizeChanged(object sender, EventArgs e)
        {
            panelVariants.Height = this.Height - OleXisTest.Controls.PANEL_YLOCATION;
        }
    }
}
