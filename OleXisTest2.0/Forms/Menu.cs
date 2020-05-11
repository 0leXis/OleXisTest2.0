using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace OleXisTest
{
    public partial class Menu : Form
    {
        private NetConnection connection;
        public Menu() 
        {
            InitializeComponent();
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            Hide();
            var editorForm = new Editor();
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
            using (var studentData = new StudentDataDialog())
            {
                if (studentData.ShowDialog() == DialogResult.OK)
                {
                    string fileName;
                    var test = FileProcessor.LoadTestFile(out fileName);
                    if(test != null)
                    {
                        using (var passing = new TestPassing(studentData.FIO, studentData.Class, test))
                        {
                            Hide();
                            passing.ShowDialog();
                            Show();
                        }
                    }
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using(var connectionForm = new ConnectToServer())
            {
                if (connectionForm.ShowDialog() == DialogResult.OK)
                    connection = connectionForm.Connection;
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection != null)
                connection.Disconnect();
        }
    }
}
