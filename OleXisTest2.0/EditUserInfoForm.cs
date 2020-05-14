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
    public partial class EditUserInfoForm : Form
    {
        int userId;
        NetConnection connection;
        public EditUserInfoForm(NetConnection connection, int userId, string login, string name, string surname, string group, UserRoles role)
        {
            InitializeComponent();
            this.connection = connection;
            this.userId = userId;
            labelLogin.Text = "Логин: " + login;
            textBoxSurname.Text = surname;
            textBoxFirstname.Text = name;
            textBoxGroup.Text = group;
            if(role == UserRoles.Student)
            {
                textBoxGroup.Visible = true;
                labelGroup.Visible = true;
            }
        }

        private void checkBoxChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChangePassword.Checked)
            {
                textBoxPassword.Enabled = true;
                textBoxPassConfirm.Enabled = true;
            }
            else
            {
                textBoxPassword.Enabled = false;
                textBoxPassConfirm.Enabled = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            connection.SendCommand(
                new RequestInfo(
                    "EditUser",
                    SequrityUtils.Encrypt(
                        new EditUserData(
                            userId,
                            checkBoxChangePassword.Checked ? textBoxPassword.Text : null,
                            textBoxFirstname.Text,
                            textBoxSurname.Text,
                            textBoxGroup.Text).ToJson(),
                        connection.User.SecretKey),
                    connection.User.UserToken),
                onRecive);
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
