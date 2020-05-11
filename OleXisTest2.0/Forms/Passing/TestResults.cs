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
    public partial class TestResults : Form
    {
        List<IAnswerListItem> answers;
        public TestResults(string FIO, string Class, string time, List<IAnswerListItem> answers)
        {
            InitializeComponent();
            if (answers == null)
                throw new ArgumentNullException("Значение answers не может быть null");
            else
                this.answers = new List<IAnswerListItem>(answers);
            labelFIO.Text += FIO;
            labelClass.Text += Class;
            var mark = Math.Round((double)this.answers.Sum((x) => { return x.IsRight ? x.Question_score : 0; }) / this.answers.Sum((x) => { return x.Question_score; }) * 10);
            labelOcenka.Text += mark.ToString();
            if (mark < 4)
                labelOcenka.ForeColor = Color.Red;
            labelProcPrav.Text += string.Format("{0:0.00}", ((double)this.answers.Sum((x) => { return x.IsRight ? 1 : 0; }) / this.answers.Count * 100));
            labelTime.Text += time;
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
