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
    public partial class StudentDataDialog : Form
    {
        public string Class
        {
            get
            {
                return _class;
            }
        }
        
        public string FIO
        {
            get
            {
                return _fio;
            }
        }

        private string _class;
        private string _fio;
        private bool _isOk = false;
        public StudentDataDialog()
        {
            InitializeComponent();
        }

        private void StudentDataDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isOk)
                return;
            if (textBoxClass.Text == "" || textBoxFIO.Text == "")
            {
                MessageBox.Show("Поля \"ФИО\" и \"Класс\\Группа\" должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            _class = textBoxClass.Text;
            _fio = textBoxFIO.Text;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            _isOk = true;
        }

        private void textBoxFIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == 8 || e.KeyChar == 127))
                e.Handled = true;
        }

        private void textBoxClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == 8 || e.KeyChar == 127))
                e.Handled = true;
        }
    }
}
