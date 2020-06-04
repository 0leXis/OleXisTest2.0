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
    public partial class AddStudentTeacherDialog : Form
    {
        NetConnection connection;
        bool isStudent;
        public AddStudentTeacherDialog(NetConnection connection, bool isStudent)
        {
            InitializeComponent();
            this.connection = connection;
            this.isStudent = isStudent;
            if (isStudent)
            {
                labelGroup.Visible = true;
                textBoxGroup.Visible = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "")
            {
                MessageBox.Show("Поле \"Логин\" должно быть заполнено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            if (isStudent)
            {
                if (textBoxGroup.Text == "")
                {
                    MessageBox.Show("Поле \"Группа\" должно быть заполнено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                connection.SendCommand(
                    new RequestInfo(
                        "RegisterStudent", 
                        SequrityUtils.Encrypt(
                            new RegisterData(
                                textBoxLogin.Text, 
                                textBoxPassword.Text, 
                                textBoxFirstname.Text, 
                                textBoxSurname.Text, 
                                textBoxGroup.Text
                             ).ToJson(), 
                            connection.User.SecretKey
                         ), 
                        connection.User.UserToken
                     ),
                     onRecive
                 );
            }
            else
            {
                connection.SendCommand(
                    new RequestInfo(
                        "RegisterTeacher",
                        SequrityUtils.Encrypt(
                            new RegisterData(
                                textBoxLogin.Text,
                                textBoxPassword.Text,
                                textBoxFirstname.Text,
                                textBoxSurname.Text,
                                null
                             ).ToJson(),
                            connection.User.SecretKey
                         ),
                        connection.User.UserToken
                     ),
                     onRecive
                 );
            }
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
                if (SequrityUtils.DecryptString(response.Data, connection.User.SecretKey) == "OK")
                {
                    MessageBox.Show("Регистрация завершена успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Непредвиденная ошибка регистрации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
