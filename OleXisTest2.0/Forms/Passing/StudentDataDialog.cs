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
        public StudentDataDialog()
        {
            InitializeComponent();
        }

        private void StudentDataDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBoxClass.Text == "" || textBoxFIO.Text == "")
            {
                MessageBox.Show("Поля \"ФИО\" и \"Класс\\Группа\" должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            _class = textBoxClass.Text;
            _fio = textBoxFIO.Text;
        }
    }
}
