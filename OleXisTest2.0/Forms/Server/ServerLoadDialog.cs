using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using NetClasses;

namespace OleXisTest
{
    public partial class ServerLoadDialog : Form
    {
        public ITest Test
        {
            get
            {
                return _test;
            }
        }
        public string TestName
        {
            get
            {
                return _testName;
            }
        }

        NetConnection connection;
        bool isPassing;
        ITest _test = null;
        string _testName = null;
        public ServerLoadDialog(NetConnection connection, bool isPassing)
        {
            InitializeComponent();
            this.connection = connection;
            this.isPassing = isPassing;
        }

        private void listBoxTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxTests.SelectedIndex != -1)
                buttonLoad.Enabled = true;
        }

        private void ServerLoadDialog_Shown(object sender, EventArgs e)
        {
            if (isPassing)
            {
                connection.SendCommand(new RequestInfo("GetAvailableTests", null, connection.User.UserToken), onTestsRecive);
            }
            else
            {
                connection.SendCommand(new RequestInfo("GetMyTests", null, connection.User.UserToken), onTestsRecive);
            }
        }

        private void onTestsRecive(string data)
        {
            var response = ResponseInfo.FromJson(data);
            if (response.Error != null)
            {
                MessageBox.Show(CommandErrors.GetErrorMessage(response.Error), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var tests = JsonConvert.DeserializeObject<List<string>>(SequrityUtils.DecryptString(response.Data, connection.User.SecretKey));
                listBoxTests.Items.Clear();
                foreach (var testName in tests)
                    listBoxTests.Items.Add(testName);
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            var saver = new ServerTestSaveProvider(connection);
            if (isPassing)
            {
                _test = saver.LoadForPass((string)listBoxTests.SelectedItem);
                if(_test == null)
                {
                    if (saver.Error != null)
                        MessageBox.Show(saver.Error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Неизвестная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _testName = (string)listBoxTests.SelectedItem;
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                _test = saver.LoadForEdit((string)listBoxTests.SelectedItem);
                if (_test == null)
                {
                    if (saver.Error != null)
                        MessageBox.Show(saver.Error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Неизвестная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _testName = (string)listBoxTests.SelectedItem;
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
