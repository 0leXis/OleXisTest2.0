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
    public partial class AddStudentTeacherDialog : Form
    {
        NetConnection connection;
        bool isStudent;
        public AddStudentTeacherDialog(NetConnection connection, bool isStudent)
        {
            InitializeComponent();
            this.connection = connection;
            if (isStudent)
            {
                labelGroup.Visible = true;
                textBoxGroup.Visible = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (isStudent)
            {
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
                MessageBox.Show(response.Error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
