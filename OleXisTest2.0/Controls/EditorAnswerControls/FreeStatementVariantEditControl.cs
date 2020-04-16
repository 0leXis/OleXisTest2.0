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
    public partial class FreeStatementVariantEditControl : UserControl, IVariantEditControl
    {
        public FreeStatementVariantEditControl()
        {
            InitializeComponent();
        }

        public FreeStatementVariantEditControl(FreeStatementQuestionAnswer freeStatementQuestionAnswer) : this()
        {
            textBoxAnswer.Text = freeStatementQuestionAnswer.Answer;
        }

        public IQuestionAnswer GetAnswer()
        {
            return new FreeStatementQuestionAnswer(textBoxAnswer.Text);
        }
    }
}
