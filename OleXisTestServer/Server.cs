using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;

namespace OleXisTestServer
{
    public partial class Server : Form
    {
        ILog multilog;
        Listener listener;
        ConfigContainer.Config config;
        public Server()
        {
            InitializeComponent();
            config = ConfigContainer.GetConfig();
            checkBoxAllowRegister.Checked = config.AllowRegistrationRequests;
            checkBoxAllowStudRegister.Checked = config.AllowStudentsRegistration;
            checkBoxAllowTeachRegister.Checked = config.AllowTeacherRegistration;
            checkBoxAllowSubjectAdd.Checked = config.AllowSubjectsAdding;
            checkBoxAllowGroupAdd.Checked = config.AllowGroupsAdding;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            var textlog = new TextBoxLog(textBoxLog);
            var filelog = new FileLog();
            multilog = new MultiLogger(textlog, filelog);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                multilog.LogMessage("Запуск сервера");
                listener = new Listener(multilog);
                DBConnection.Connect("server=" + config.DBIP + ";uid=" + config.DBUser + ";pwd=" + config.DBPassword, "TestsServer");//;database=TestsServer
                multilog.LogMessage("Выполнено подключение к БД");
                listener.ListenStart("http://*:27020/");
                multilog.LogMessage("Сервер запущен");
                buttonStop.Enabled = true;
                buttonStart.Enabled = false;
                buttonOptions.Enabled = false;
            }
            catch(Exception exception)
            {
                multilog.LogError(exception.ToString());
                buttonStart.Enabled = true;
                buttonOptions.Enabled = true;
                listener.ListenStop();
                DBConnection.Disconnect();
                //broadcaster.StopBroadcast();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            try
            {
                listener.ListenStop();
                multilog.LogMessage("Сервер остановлен");
                DBConnection.Disconnect();
                multilog.LogMessage("Соединение с БД закрыто");
            }
            catch (Exception exception)
            {
                multilog.LogError(exception.ToString());
            }
            buttonStop.Enabled = false;
            buttonStart.Enabled = true;
            buttonOptions.Enabled = true;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConfigContainer.Save();
        }

        private void checkBoxAllowRegister_CheckedChanged(object sender, EventArgs e)
        {
            config.AllowRegistrationRequests = checkBoxAllowRegister.Checked;
        }

        private void checkBoxAllowStudRegister_CheckedChanged(object sender, EventArgs e)
        {
            config.AllowStudentsRegistration = checkBoxAllowStudRegister.Checked;
        }

        private void checkBoxAllowTeachRegister_CheckedChanged(object sender, EventArgs e)
        {
            config.AllowTeacherRegistration = checkBoxAllowTeachRegister.Checked;
        }

        private void checkBoxAllowSubjectAdd_CheckedChanged(object sender, EventArgs e)
        {
            config.AllowSubjectsAdding = checkBoxAllowSubjectAdd.Checked;
        }

        private void checkBoxAllowGroupAdd_CheckedChanged(object sender, EventArgs e)
        {
            config.AllowGroupsAdding = checkBoxAllowGroupAdd.Checked;
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            using(var settingsDialog = new ServerSettings(config))
            {
                settingsDialog.ShowDialog();
            }
        }
    }
}
