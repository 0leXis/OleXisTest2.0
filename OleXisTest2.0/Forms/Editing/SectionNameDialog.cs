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
    public partial class SectionNameDialog : Form
    {
        public string SectionName
        {
            get
            {
                return _sectionName;
            }
        }

        private string _sectionName = null;
        private Editor _parent;
        public SectionNameDialog(Editor parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public SectionNameDialog(Editor parent, string sectionToEdit)
        {
            InitializeComponent();
            _parent = parent;
            textBoxName.Text = sectionToEdit;
        }
        private void buttonCreateVopr_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Поле \"Название\" должно быть заполнено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!_parent.CheckQuestionOrSectionName(_sectionName))
            {
                _sectionName = textBoxName.Text;
                Close();
            }
            else
                MessageBox.Show("Раздел или вопрос с таким именем уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
