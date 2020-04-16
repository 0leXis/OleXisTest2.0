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
    public partial class SequenceVariantEditControl : UserControl, IVariantEditControl
    {
        List<Label> VariantNumber;
        List<TextBox> SequenceText;
        List<Button> UpVariant;
        List<Button> DownVariant;
        List<Button> DeleteVariant;
        public SequenceVariantEditControl()
        {
            InitializeComponent();
            VariantNumber = new List<Label>();
            SequenceText = new List<TextBox>();
            DeleteVariant = new List<Button>();
            UpVariant = new List<Button>();
            DownVariant = new List<Button>();
        }

        public SequenceVariantEditControl(SequenceQuestionAnswer sequenceQuestionAnswer) : this()
        {
            for (var i = 0; i < sequenceQuestionAnswer.Variants.Count; i++)
            {
                AddVariant();
                SequenceText[i].Text = sequenceQuestionAnswer.Variants[i];
            }
        }

        private void buttonAddVariant_Click(object sender, EventArgs e)
        {
            AddVariant();
        }

        private void AddVariant()
        {
            panelVariants.VerticalScroll.Value = 0;
            var controlsTop = SequenceText.Count * OleXisTest.Controls.INDENT_Y;
            var currentVariantNumber = SequenceText.Count + 1;

            var tmpLabel = OleXisTest.Controls.GetLabel(currentVariantNumber + ". ", OleXisTest.Controls.VARIANTNUMBER_LABEL_WIDTH, controlsTop, panelVariants, null);
            VariantNumber.Add(tmpLabel);

            var tmpTextBox = OleXisTest.Controls.GetTextBox(OleXisTest.Controls.TEXT_BOX_WIDTH, controlsTop, panelVariants, tmpLabel);
            SequenceText.Add(tmpTextBox);

            var tmpButton = OleXisTest.Controls.GetButton(" ↓", OleXisTest.Controls.ARROW_BUTTON_SIZE, controlsTop - 1, panelVariants, tmpTextBox);
            tmpButton.Click += UpClick;
            UpVariant.Add(tmpButton);

            tmpButton = OleXisTest.Controls.GetButton(" ↑", OleXisTest.Controls.ARROW_BUTTON_SIZE, controlsTop - 1, panelVariants, tmpButton);
            tmpButton.Click += DownClick;
            DownVariant.Add(tmpButton);

            tmpButton = OleXisTest.Controls.GetButton("Удалить", OleXisTest.Controls.DELETE_BUTTON_SIZE, controlsTop - 1, panelVariants, tmpButton);
            tmpButton.Click += ButtonDeleteClick;
            DeleteVariant.Add(tmpButton);
        }

        private void ButtonDeleteClick(object Sender, EventArgs e)
        {
            var tmp = Sender as Button;
            var index = DeleteVariant.FindIndex(x => x == tmp);

            VariantNumber[index].Dispose();
            SequenceText[index].Dispose();
            DeleteVariant[index].Dispose();
            UpVariant[index].Dispose();
            DownVariant[index].Dispose();

            VariantNumber.RemoveAt(index);
            SequenceText.RemoveAt(index);
            DeleteVariant.RemoveAt(index);
            UpVariant.RemoveAt(index);
            DownVariant.RemoveAt(index);

            for (var i = index; i < SequenceText.Count; i++)
            {
                VariantNumber[i].Text = (i + 1) + ". ";

                VariantNumber[i].Top -= OleXisTest.Controls.INDENT_Y;
                SequenceText[i].Top -= OleXisTest.Controls.INDENT_Y;
                DeleteVariant[i].Top -= OleXisTest.Controls.INDENT_Y;
                UpVariant[i].Top -= OleXisTest.Controls.INDENT_Y;
                DownVariant[i].Top -= OleXisTest.Controls.INDENT_Y;
            }
        }

        //Поместить вариант выше
        public void UpClick(object Sender, EventArgs e)
        {
            var tmp = Sender as Button;
            var index = UpVariant.FindIndex(x => x == tmp);
            if (index < UpVariant.Count - 1)
            {
                var tmpcomp = SequenceText[index];
                SequenceText[index] = SequenceText[index + 1];
                SequenceText[index + 1] = tmpcomp;

                var tmpbtn = UpVariant[index];
                UpVariant[index] = UpVariant[index + 1];
                UpVariant[index + 1] = tmpbtn;

                tmpbtn = DownVariant[index];
                DownVariant[index] = DownVariant[index + 1];
                DownVariant[index + 1] = tmpbtn;

                tmpbtn = DeleteVariant[index];
                DeleteVariant[index] = DeleteVariant[index + 1];
                DeleteVariant[index + 1] = tmpbtn;

                SequenceText[index + 1].Top += OleXisTest.Controls.INDENT_Y;
                UpVariant[index + 1].Top += OleXisTest.Controls.INDENT_Y;
                DownVariant[index + 1].Top += OleXisTest.Controls.INDENT_Y;
                DeleteVariant[index + 1].Top += OleXisTest.Controls.INDENT_Y;

                SequenceText[index].Top -= OleXisTest.Controls.INDENT_Y;
                UpVariant[index].Top -= OleXisTest.Controls.INDENT_Y;
                DownVariant[index].Top -= OleXisTest.Controls.INDENT_Y;
                DeleteVariant[index].Top -= OleXisTest.Controls.INDENT_Y;
            }
        }
        //Поместить вариант ниже
        public void DownClick(object Sender, EventArgs e)
        {
            var tmp = Sender as Button;
            var index = DownVariant.FindIndex(x => x == tmp);
            if (index > 0)
            {
                var tmpcomp = SequenceText[index];
                SequenceText[index] = SequenceText[index - 1];
                SequenceText[index - 1] = tmpcomp;

                var tmpbtn = UpVariant[index];
                UpVariant[index] = UpVariant[index - 1];
                UpVariant[index - 1] = tmpbtn;

                tmpbtn = DownVariant[index];
                DownVariant[index] = DownVariant[index - 1];
                DownVariant[index - 1] = tmpbtn;

                tmpbtn = DeleteVariant[index];
                DeleteVariant[index] = DeleteVariant[index - 1];
                DeleteVariant[index - 1] = tmpbtn;

                SequenceText[index].Top += OleXisTest.Controls.INDENT_Y;
                UpVariant[index].Top += OleXisTest.Controls.INDENT_Y;
                DownVariant[index].Top += OleXisTest.Controls.INDENT_Y;
                DeleteVariant[index].Top += OleXisTest.Controls.INDENT_Y;

                SequenceText[index - 1].Top -= OleXisTest.Controls.INDENT_Y;
                UpVariant[index - 1].Top -= OleXisTest.Controls.INDENT_Y;
                DownVariant[index - 1].Top -= OleXisTest.Controls.INDENT_Y;
                DeleteVariant[index - 1].Top -= OleXisTest.Controls.INDENT_Y;
            }
        }

        public IQuestionAnswer GetAnswer()
        {
            var variants = new List<string>();
            foreach (var Variant in SequenceText)
                variants.Add(Variant.Text);
            return new SequenceQuestionAnswer(variants);
        }

        private void SequenceVariantEditControl_SizeChanged(object sender, EventArgs e)
        {
            panelVariants.Height = this.Height - OleXisTest.Controls.PANEL_YLOCATION;
        }
    }
}
