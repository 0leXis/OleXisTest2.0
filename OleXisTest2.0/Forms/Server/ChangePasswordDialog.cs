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
    public partial class ChangePasswordDialog : Form
    {
        NetConnection connection;
        public ChangePasswordDialog(NetConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Поля \"Пароль\" и \"Подтверждение пароля\" должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(textBoxPassword.Text != textBoxPassConfirm.Text)
            {
                MessageBox.Show("Пароли не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection.SendCommand(
                new RequestInfo(
                    "ChangePassword",
                    SequrityUtils.Encrypt(
                        textBoxPassword.Text,
                        connection.User.SecretKey),
                    connection.User.UserToken),
                onRecive);
        }

        private void onRecive(string data)
        {
            var response = ResponseInfo.FromJson(data);
            if (response.Error != null)
            {
                MessageBox.Show(CommandErrors.GetErrorMessage(response.Error), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
