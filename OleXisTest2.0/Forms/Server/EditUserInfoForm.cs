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
            if (textBoxSurname.Text == "")
            {
                MessageBox.Show("Поле \"Фамилия\" должно быть заполнено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxFirstname.Text == "")
            {
                MessageBox.Show("Поле \"Имя\" должно быть заполнено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkBoxChangePassword.Checked)
            {
                if (textBoxPassword.Text == "")
                {
                    MessageBox.Show("Поле \"Пароль\" должно быть заполнено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBoxPassConfirm.Text != textBoxPassword.Text)
                {
                    MessageBox.Show("Пароли не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if(textBoxGroup.Visible)
                if (textBoxGroup.Text == "")
                {
                    MessageBox.Show("Поле \"Группа\" должно быть заполнено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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

        private void textBoxSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == 8 || e.KeyChar == 127))
                e.Handled = true;
        }

        private void textBoxGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == 8 || e.KeyChar == 127))
                e.Handled = true;
        }
    }
}
