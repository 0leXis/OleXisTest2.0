using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OleXisTestServer
{
    public partial class ServerSettings : Form
    {
        ConfigContainer.Config config;
        public ServerSettings(ConfigContainer.Config config)
        {
            InitializeComponent();
            this.config = config;
            textBoxIP.Text = config.DBIP;
            textBoxName.Text = config.DBUser;
            textBoxPassword.Text = config.DBPassword;
            numericUpDownPort.Value = config.ServerPort;
        }

        private void buttonSetThis_Click(object sender, EventArgs e)
        {
            textBoxIP.Text = "127.0.0.1";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\z");
            var IP = textBoxIP.Text.Trim();
            if (!regex.IsMatch(IP))
            {
                MessageBox.Show("Введен некорректный IP адрес", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Поле \"Имя пользователя\" должно быть заполнено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Поле \"Пароль\" должно быть заполнено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            config.DBIP = IP;
            config.DBPassword = textBoxPassword.Text;
            config.DBUser = textBoxName.Text;
            config.ServerPort = (int)numericUpDownPort.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
