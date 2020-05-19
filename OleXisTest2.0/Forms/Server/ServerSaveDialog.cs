using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace OleXisTest
{
    public partial class ServerSaveDialog : Form
    {
        public string TestName
        {
            get
            {
                return _testName;
            }
        }
        ITest test;
        NetConnection connection;
        string _testName = null;
        Dictionary<int, string> subjects;
        public ServerSaveDialog(NetConnection connection, ITest test, string testName = null)
        {
            InitializeComponent();
            if(testName != null)
                textBoxTestName.Text = testName;
            if (test == null)
                throw new ArgumentNullException("Значение test не может быть null");
            this.test = test;
            if (connection == null || !connection.IsConnected)
                throw new ArgumentNullException("Для сохранения теста необходимо подключение к серверу");
            this.connection = connection;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(comboBoxSubject.SelectedIndex < 0)
            {
                MessageBox.Show("Необходимо выбрать предмет/дисциплину теста. Если в списке нет вашего предмета/дисциплины воспользуйтесь кнопкой \"Добавить предмет\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxTestName.Text == "")
            {
                MessageBox.Show("Поле \"Название теста\" должно быть заполнено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var saver = new ServerTestSaveProvider(connection);
            if (saver.Save(test, textBoxTestName.Text, subjects.FirstOrDefault(x => x.Value == (string)comboBoxSubject.SelectedItem).Key))
            {
                _testName = textBoxTestName.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                if(saver.Error != null)
                    MessageBox.Show(saver.Error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ServerSaveDialog_Shown(object sender, EventArgs e)
        {
            UpdateSubjectsList();
        }

        private void onSubjectsRecive(string data)
        {
            var response = ResponseInfo.FromJson(data);
            if(response.Error != null)
            {
                MessageBox.Show(response.Error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                subjects = JsonConvert.DeserializeObject<Dictionary<int, string>>(SequrityUtils.DecryptString(response.Data, connection.User.SecretKey));
                comboBoxSubject.Items.Clear();
                if (subjects.Count == 0)
                {
                    comboBoxSubject.SelectedIndex = -1;
                }
                else
                {
                    foreach (var keyValue in subjects)
                        comboBoxSubject.Items.Add(keyValue.Value);
                    comboBoxSubject.SelectedIndex = 0;
                }
            }
        }

        private void UpdateSubjectsList()
        {
            connection.SendCommand(new RequestInfo("GetSubjectList", null, connection.User.UserToken), onSubjectsRecive);
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            using(var addDialog = new AddSubject(connection))
            {
                if (addDialog.ShowDialog() == DialogResult.OK)
                    UpdateSubjectsList();
            }
        }
    }
}
