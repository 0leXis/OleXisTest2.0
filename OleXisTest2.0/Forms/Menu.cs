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
    public partial class Menu : Form
    {
        private Editor editorForm;

        public Menu()
        {
            InitializeComponent();
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            Hide();
            editorForm = new Editor();
            editorForm.ShowDialog();
            Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //TODO: if connected to server, do server test choose
            using(var studentData = new StudentDataDialog())
            {
                if(studentData.ShowDialog() == DialogResult.OK)
                {
                    string fileName;
                    using(var passing = new TestPassing(studentData.FIO, studentData.Class, FileProcessor.LoadTestFile(out fileName)))
                    {
                        Hide();
                        passing.ShowDialog();
                        Show();
                    }
                }
            }
        }
    }
}
