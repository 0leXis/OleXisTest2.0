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
    public partial class AlternativeVariantEditControl : UserControl, IVariantEditControl
    {
        public AlternativeVariantEditControl()
        {
            InitializeComponent();
        }

        public AlternativeVariantEditControl(AlternativeQuestionAnswer alternativeQuestionAnswer) : this()
        {
            if (alternativeQuestionAnswer.IsYesAnswer)
                radioButtonYes.Checked = true;
            else
                radioButtonNo.Checked = true;
        }

        public IQuestionAnswer GetAnswer()
        {
            if (radioButtonYes.Checked)
                return new AlternativeQuestionAnswer(true);
            else
                return new AlternativeQuestionAnswer(false);
        }
    }
}
