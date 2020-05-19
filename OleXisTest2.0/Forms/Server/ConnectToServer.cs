using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using NetClasses;

namespace OleXisTest
{
    public partial class ConnectToServer : Form
    {
        public NetConnection Connection
        {
            get
            {
                return _connection;
            }
        }

        public AccountInfo LoginInfo
        {
            get
            {
                return _loginInfo;
            }
        }

        public string Login
        {
            get
            {
                return _login;
            }
        }

        private NetConnection _connection = null;
        private AccountInfo _loginInfo = null;
        private bool isRegState = false;
        private string _login;
        private Config config;
        public ConnectToServer(Config config)
        {
            InitializeComponent();
            this.config = config;
            if (config.ServerIP != null)
                textBoxIP.Text = config.ServerIP;
            if (config.ServerPort != null)
                numericUpDownPort.Value = config.ServerPort.Value;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (checkBoxSaveData.Checked)
            {
                config.ServerIP = textBoxIP.Text;
                config.ServerPort = Convert.ToInt32(numericUpDownPort.Value);
            }
            if (textBoxIP.Text == "")
            {
                MessageBox.Show("Поле \"IP\" должно быть заполнено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            if (isRegState)
            {
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
                if (textBoxGroup.Text == "")
                {
                    MessageBox.Show("Поле \"Группа\" должно быть заполнено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //192.168.100.232
            Regex regex = new Regex(@"^[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\z");
            var IP = textBoxIP.Text.Trim();
            if(regex.IsMatch(IP))
                _connection = new NetConnection(IP, Convert.ToInt32(numericUpDownPort.Value));
            else
                _connection = new NetConnection(IP);
            _login = textBoxLogin.Text;
            if (isRegState)
                _connection.Register(new RegisterData(textBoxLogin.Text, textBoxPassword.Text, textBoxFirstname.Text, textBoxSurname.Text, textBoxGroup.Text), onRegister);
            else
                _connection.Login(new LoginData(textBoxLogin.Text, textBoxPassword.Text), onLogin);
        }

        private void onLogin(string error, AccountInfo info)
        {
            if (error != null)
            {
                MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _loginInfo = info;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void onRegister(string error)
        {
            if (error != null)
            {
                MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Регистрация завершена успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonToRegistration_Click(object sender, EventArgs e)
        {
            if (isRegState)
            {
                panelRegistration.Visible = false;
                buttonToRegistration.Text = "Перейти к регистрации";
                buttonConnect.Text = "Вход";

                isRegState = false;
            }
            else
            {
                panelRegistration.Visible = true;
                buttonToRegistration.Text = "Перейти к авторизации";
                buttonConnect.Text = "Регистрация";

                isRegState = true;
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
