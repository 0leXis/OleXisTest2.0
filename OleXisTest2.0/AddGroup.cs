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
    public partial class AddGroup : Form
    {
        NetConnection connection;
        public AddGroup(NetConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            connection.SendCommand(new RequestInfo("AddGroup", SequrityUtils.Encrypt(textBoxGroupName.Text, connection.User.SecretKey), connection.User.UserToken), onRecive);
        }

        private void onRecive(string data)
        {
            var response = ResponseInfo.FromJson(data);
            if (response.Error != null)
            {
                MessageBox.Show(response.Error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (SequrityUtils.DecryptString(response.Data, connection.User.SecretKey) != "OK")
                    MessageBox.Show("Неизвестная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    DialogResult = DialogResult.OK;
            }
        }
    }
}
