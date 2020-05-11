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
    public partial class Menu : Form
    {
        ILog textlog;
        Listener listener;
        ServerFindBroadcaster broadcaster;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            comboBoxRegParams.SelectedIndex = 0;

            textlog = new TextBoxLog(textBoxLog);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                textlog.LogMessage("Запуск сервера");
                listener = new Listener(textlog);
                broadcaster = new ServerFindBroadcaster(27020, 27021);
                //TODO: ввод с ввода
                DBConnection.Connect("server=127.0.0.1;uid=root;pwd=12345;database=TestsServer");
                textlog.LogMessage("Выполнено подключение к БД");
                listener.ListenStart("http://*:27020/");
                textlog.LogMessage("Сервер запущен");
                broadcaster.StartBroadcast();
                textlog.LogMessage("Система поиска серверов запущена");
                buttonStop.Enabled = true;
                buttonStart.Enabled = false;
            }
            catch(Exception exception)
            {
                textlog.LogError(exception.ToString());
                buttonStart.Enabled = true;
                listener.ListenStop();
                DBConnection.Disconnect();
                broadcaster.StopBroadcast();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            try
            {
                broadcaster.StopBroadcast();
                textlog.LogMessage("Система поиска серверов остановлена");
                listener.ListenStop();
                textlog.LogMessage("Сервер остановлен");
                DBConnection.Disconnect();
                textlog.LogMessage("Соединение с БД закрыто");
            }
            catch (Exception exception)
            {
                textlog.LogError(exception.ToString());
            }
            buttonStop.Enabled = false;
            buttonStart.Enabled = true;
        }
    }
}
