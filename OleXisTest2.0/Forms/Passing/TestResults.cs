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
    public partial class TestResults : Form
    {
        List<AnswerListItem> answers;
        NetConnection connection;
        public TestResults(string FIO, string Class, int passMinutes, int passSeconds, List<AnswerListItem> answers, bool isServerTest, NetConnection connection)
        {
            InitializeComponent();
            if (answers == null)
                throw new ArgumentNullException("Значение answers не может быть null");
            else
                this.answers = new List<AnswerListItem>(answers);
            labelFIO.Text += FIO;
            labelClass.Text += Class;
            var mark = Math.Round((double)this.answers.Sum((x) => { return x.IsRight ? x.Question_score : 0; }) / this.answers.Sum((x) => { return x.Question_score; }) * 10);
            labelOcenka.Text += mark.ToString();
            if (mark < 4)
                labelOcenka.ForeColor = Color.Red;
            labelProcPrav.Text += string.Format("{0:0.00}", ((double)this.answers.Sum((x) => { return x.IsRight ? 1 : 0; }) / this.answers.Count * 100));
            labelTime.Text += passMinutes + ":" + passSeconds;

            this.connection = connection;
            if (isServerTest && connection != null && connection.IsConnected)
                connection.SendCommand(
                    new RequestInfo(
                        "SaveResult",
                        SequrityUtils.Encrypt(
                            new TestResult(
                                Convert.ToInt32(mark),
                                new DateTime(1, 1, 1, passMinutes / 60 > 23 ? 23 : passMinutes / 60, passMinutes % 60, passSeconds),
                                answers).ToJson(),
                            connection.User.SecretKey),
                        connection.User.UserToken),
                    onRecive);
        }

        private void onRecive(string data)
        {
            var response = ResponseInfo.FromJson(data);
            if (response.Error != null)
            {
                if(response.Error != "USER_NOT_STUDENT")
                    MessageBox.Show(CommandErrors.GetErrorMessage(response.Error), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (SequrityUtils.DecryptString(response.Data, connection.User.SecretKey) != "OK")
                    MessageBox.Show("Неизвестная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var answerListDialog = new AnswerListDialog(answers))
            {
                answerListDialog.ShowDialog();
            }
        }
    }
}
