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
    public partial class PasswordDialog : Form
    {
        public string Password
        {
            get
            {
                return _password;
            }
        }

        private string _password = "";

        public PasswordDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _password = textBoxPassword.Text;
        }
    }
}
