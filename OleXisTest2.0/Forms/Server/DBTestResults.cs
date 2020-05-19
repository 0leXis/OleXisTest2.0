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
    public partial class DBTestResults : Form
    {
        public int TestId { get; }

        NetConnection connection;
        public DBTestResults(int TestId, NetConnection connection)
        {
            InitializeComponent();
            this.TestId = TestId;
            this.connection = connection;
        }

        private void ClearFilters()
        {
            textBoxTestNameSurname.Text = "";
            checkBoxUseData.Checked = false;
        }

        private void UpdateData()
        {
            connection.SendCommand(
            new RequestInfo(
                "GetTestResults",
                    SequrityUtils.Encrypt(
                        new ServerTestResultGetParams(
                            TestId,
                            textBoxTestNameSurname.Text,
                            checkBoxUseData.Checked ? (DateTime?)dateTimePicker1.Value : null)
                        .ToJson(),
                        connection.User.SecretKey),
                    connection.User.UserToken),
                onResultsRecive);
        }

        private void onResultsRecive(string data)
        {
            var response = ResponseInfo.FromJson(data);
            if (response.Error != null)
            {
                MessageBox.Show(response.Error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var resultslist = JsonConvert.DeserializeObject<List<ResultSheetItem>>(SequrityUtils.DecryptString(response.Data, connection.User.SecretKey));

                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();

                dataGridView.Columns.Add("Id", "Id");
                dataGridView.Columns.Add("NameSurname", "Имя/Фамилия учащегося");
                dataGridView.Columns.Add("Mark", "Оценка");
                dataGridView.Columns.Add("PassDate", "Дата выполнения");
                dataGridView.Columns.Add("PassingTime", "Время выполнения");
                dataGridView.Columns.Add("ExtendedResults", "Расширенные результаты");

                foreach (var item in resultslist)
                {
                    var row = new DataGridViewRow();
                    row.Cells.Add(DataGridViewComponents.GetDataGridViewRowTextBoxCell(item.id.ToString()));
                    row.Cells.Add(DataGridViewComponents.GetDataGridViewRowTextBoxCell(item.NameSurname));
                    row.Cells.Add(DataGridViewComponents.GetDataGridViewRowTextBoxCell(item.Mark.ToString()));
                    row.Cells.Add(DataGridViewComponents.GetDataGridViewRowTextBoxCell(item.PassDate.ToString("dd.MM.yyyy")));
                    row.Cells.Add(DataGridViewComponents.GetDataGridViewRowTextBoxCell(item.PassingTime.ToString("hh:mm:ss")));
                    row.Cells.Add(DataGridViewComponents.GetDataGridViewRowButtonCell("Расширенные результаты"));
                    dataGridView.Rows.Add(row);
                }
            }
        }

        private void buttonClearFilters_Click(object sender, EventArgs e)
        {
            ClearFilters();
            UpdateData();
        }

        private void DBTestResults_Shown(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void textBoxTestNameSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                buttonClearFilters.Focus();
            else
            if (!(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == 8 || e.KeyChar == 127))
                e.Handled = true;
        }

        private void textBoxTestNameSurname_Leave(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            if(checkBoxUseData.Checked)
                UpdateData();
        }

        private void checkBoxUseData_CheckedChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void GetExtendedResults(int resultId)
        {
            connection.SendCommand(
                new RequestInfo(
                    "GetExtendedResult",
                    SequrityUtils.Encrypt(
                        resultId.ToString(),
                        connection.User.SecretKey),
                    connection.User.UserToken),
                onExtendedResultsRecive);
        }

        private void onExtendedResultsRecive(string data)
        {
            var response = ResponseInfo.FromJson(data);
            if (response.Error != null)
            {
                MessageBox.Show(response.Error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var result = JsonConvert.DeserializeObject<List<AnswerListItem>>(SequrityUtils.DecryptString(response.Data, connection.User.SecretKey));
                using(var resultDialog = new AnswerListDialog(result))
                {
                    resultDialog.ShowDialog();
                }
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
            {
                GetExtendedResults(Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].Value));
            }
        }
    }
}
