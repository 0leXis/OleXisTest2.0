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
        public ConnectToServer()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            _connection = new NetConnection("192.168.100.232", "27020");
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
    }
}
