using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NetClasses;

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
            if (textBoxGroupName.Text == "")
            {
                MessageBox.Show("Поле \"Название класса\\группы\" должно быть заполнено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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

        private void textBoxGroupName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == 8 || e.KeyChar == 127))
                e.Handled = true;
        }
    }
}
