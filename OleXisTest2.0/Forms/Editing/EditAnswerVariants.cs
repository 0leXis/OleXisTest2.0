using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OleXisTest
{
    public partial class EditAnswerVariants : Form
    {
        UserControl variants;
        public IQuestionAnswer QuestionAnswer
        {
            get
            {
                return _questionAnswer;
            }
        }

        private IQuestionAnswer _questionAnswer = null;

        private EditAnswerVariants()
        {
            InitializeComponent();
        }

        public EditAnswerVariants(IQuestionAnswer questionAnswer) : this()
        {
            variants = EditableControlFactory.GetEditableControl(questionAnswer) as UserControl;
            panel.Controls.Add(variants);
            variants.Dock = DockStyle.Fill;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            var tmp_questionAnswer = (variants as IVariantEditControl).GetAnswer();
            if (tmp_questionAnswer.ValidateAnswer())
            {
                _questionAnswer = tmp_questionAnswer;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
