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
    public partial class DatabaseForm : Form
    {
        NetConnection connection;
        Dictionary<int, string> subjectsRoles;
        public DatabaseForm(NetConnection connection)
        {
            InitializeComponent();
            dataGridView.ReadOnly = true;
            this.connection = connection;
            switch (connection.User.UserRole)
            {
                case UserRoles.Admin:
                case UserRoles.Teacher:
                    btnAddGroup.Enabled = true;
                    btnAddStudent.Enabled = true;
                    btnAddSubject.Enabled = true;
                    btnAddTeacher.Enabled = true;
                    break;
            }
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            using (var addUserDialog = new AddStudentTeacherDialog(connection, false))
            {
                addUserDialog.ShowDialog();
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            using (var addUserDialog = new AddStudentTeacherDialog(connection, true))
            {
                addUserDialog.ShowDialog();
            }
        }

        private void DatabaseForm_Shown(object sender, EventArgs e)
        {
            comboBoxData.SelectedIndex = 0;
        }

        private void GetUsersList()
        {
            connection.SendCommand(
                new RequestInfo(
                    "GetUsersSheet",
                    SequrityUtils.Encrypt(
                        new UserSheetGetParams(
                            textBoxTestNameSurname.Text,
                            subjectsRoles.FirstOrDefault(
                                x => x.Value == (string)comboBoxSubjectRole.SelectedItem)
                            .Key)
                        .ToJson(),
                        connection.User.SecretKey),
                    connection.User.UserToken),
                onUserListRecive);
        }

        private void GetTestsList(bool isCreatorTests)
        {
            if (isCreatorTests && connection.User.UserRole != UserRoles.Teacher)
            {
                MessageBox.Show("Вы должны иметь права Преподавателя для просмотра данного списка", "Права доступа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxData.SelectedIndex = 0;
            }
            else
            {
                connection.SendCommand(
                    new RequestInfo(
                        "GetTestsSheet",
                        SequrityUtils.Encrypt(
                            new TestSheetGetParams(
                                isCreatorTests,
                                textBoxTestNameSurname.Text,
                                subjectsRoles.FirstOrDefault(
                                    x => x.Value == (string)comboBoxSubjectRole.SelectedItem)
                                .Key)
                            .ToJson(),
                            connection.User.SecretKey),
                        connection.User.UserToken),
                    onTestListRecive);
            }
        }

        private void GetCurrentSheet()
        {
            switch (comboBoxData.SelectedIndex)
            {
                case 0:
                    GetTestsList(false);
                    break;
                case 1:
                    GetTestsList(true);
                    break;
                case 2:
                    GetUsersList();
                    break;
            }
        }

        private void ClearFilters()
        {
            textBoxTestNameSurname.Text = "";
            checkBoxDate.Checked = false;
            comboBoxSubjectRole.SelectedIndex = -1;
        }

        private void SetSubjects()
        {
            connection.SendCommand(new RequestInfo("GetSubjectList", null, connection.User.UserToken), onSubjectsRolesRecive);
        }

        private void SetRoles()
        {
            connection.SendCommand(new RequestInfo("GetRolesList", null, connection.User.UserToken), onSubjectsRolesRecive);
        }

        private void onSubjectsRolesRecive(string data)
        {
            var response = ResponseInfo.FromJson(data);
            if (response.Error != null)
            {
                MessageBox.Show(response.Error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                subjectsRoles = JsonConvert.DeserializeObject<Dictionary<int, string>>(SequrityUtils.DecryptString(response.Data, connection.User.SecretKey));
                comboBoxSubjectRole.Items.Clear();
                if (subjectsRoles.Count != 0)
                {
                    foreach (var keyValue in subjectsRoles)
                        comboBoxSubjectRole.Items.Add(keyValue.Value);
                }
            }
        }

        private void onTestListRecive(string data)
        {
            var response = ResponseInfo.FromJson(data);
            if (response.Error != null)
            {
                MessageBox.Show(response.Error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var itemlist = JsonConvert.DeserializeObject<List<TestSheetItem>>(SequrityUtils.DecryptString(response.Data, connection.User.SecretKey));

                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();

                dataGridView.Columns.Add("Id", "Id");
                dataGridView.Columns.Add("Name", "Название");
                dataGridView.Columns.Add("Creator", "Создатель");
                dataGridView.Columns.Add("EditDate", "Дата изменения");
                dataGridView.Columns.Add("Subject", "Предмет/Дисциплина");
                dataGridView.Columns.Add("PassAvailable", "Доступен для прохождения");
                dataGridView.Columns.Add("ShowResults", "Просмотреть результат");
                if (comboBoxData.SelectedIndex == 1)
                {
                    dataGridView.Columns.Add("OpenClosePassing", "Разрешить/Запретить прохождение");
                    dataGridView.Columns.Add("Delete", "Удалить");
                }

                foreach (var item in itemlist)
                {
                    var row = new DataGridViewRow();
                    row.Cells.Add(DataGridViewComponents.GetDataGridViewRowTextBoxCell(item.id.ToString()));
                    row.Cells.Add(DataGridViewComponents.GetDataGridViewRowTextBoxCell(item.Name));
                    row.Cells.Add(DataGridViewComponents.GetDataGridViewRowTextBoxCell(item.Creator));
                    row.Cells.Add(DataGridViewComponents.GetDataGridViewRowTextBoxCell(item.EditDate.ToString()));
                    row.Cells.Add(DataGridViewComponents.GetDataGridViewRowTextBoxCell(subjectsRoles[item.Subject]));
                    row.Cells.Add(DataGridViewComponents.GetDataGridViewRowTextBoxCell(item.PassAvailable ? "Да" : "Нет"));
                    row.Cells.Add(DataGridViewComponents.GetDataGridViewRowButtonCell("Просмотреть результаты"));
                    if (comboBoxData.SelectedIndex == 1)
                    {
                        row.Cells.Add(DataGridViewComponents.GetDataGridViewRowButtonCell("Разрешить/Запретить прохождение"));
                        row.Cells.Add(DataGridViewComponents.GetDataGridViewRowButtonCell("Удалить"));
                    }
                    dataGridView.Rows.Add(row);
                }
                if (checkBoxDate.Checked)
                    dataGridView.Sort(dataGridView.Columns[3], ListSortDirection.Ascending);
            }
        }

        private void onUserListRecive(string data)
        {
            var response = ResponseInfo.FromJson(data);
            if (response.Error != null)
            {
                MessageBox.Show(response.Error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var userlist = JsonConvert.DeserializeObject<List<UserSheetItem>>(SequrityUtils.DecryptString(response.Data, connection.User.SecretKey));

                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();

                dataGridView.Columns.Add("Id", "Id");
                dataGridView.Columns.Add("Login", "Логин");
                dataGridView.Columns.Add("Name", "Имя");
                dataGridView.Columns.Add("Surname", "Фамилия");
                dataGridView.Columns.Add("Role", "Тип аккаунта");
                dataGridView.Columns.Add("Group", "Группа");
                if (connection.User.UserRole == UserRoles.Admin)
                {
                    dataGridView.Columns.Add("Edit", "Изменить");
                    dataGridView.Columns.Add("Delete", "Удалить");
                }

                foreach (var item in userlist)
                {
                    var row = new DataGridViewRow();
                    row.Cells.Add(DataGridViewComponents.GetDataGridViewRowTextBoxCell(item.id.ToString()));
                    row.Cells.Add(DataGridViewComponents.GetDataGridViewRowTextBoxCell(item.Login));
                    row.Cells.Add(DataGridViewComponents.GetDataGridViewRowTextBoxCell(item.Name));
                    row.Cells.Add(DataGridViewComponents.GetDataGridViewRowTextBoxCell(item.Surname));
                    row.Cells.Add(DataGridViewComponents.GetDataGridViewRowTextBoxCell(subjectsRoles[item.Role]));
                    row.Cells.Add(DataGridViewComponents.GetDataGridViewRowTextBoxCell(item.Group));
                    if (connection.User.UserRole == UserRoles.Admin)
                    {
                        row.Cells.Add(DataGridViewComponents.GetDataGridViewRowButtonCell("Изменить"));
                        if (item.Role != (int)UserRoles.Admin + 1)
                            row.Cells.Add(DataGridViewComponents.GetDataGridViewRowButtonCell("Удалить"));
                    }
                    dataGridView.Rows.Add(row);
                }
            }
        }

        private void DeleteUser(int id)
        {
            if(MessageBox.Show("Вы уверены?", "Удаление пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection.SendCommand(
                    new RequestInfo(
                        "DeleteUser",
                        SequrityUtils.Encrypt(
                            id.ToString(),
                            connection.User.SecretKey),
                        connection.User.UserToken),
                    onDeletePassToggleRecive);
            }
        }

        private void DeleteTest(int id)
        {
            if (MessageBox.Show("Вы уверены?", "Удаление пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection.SendCommand(
                    new RequestInfo(
                        "DeleteTest",
                        SequrityUtils.Encrypt(
                            id.ToString(),
                            connection.User.SecretKey),
                        connection.User.UserToken),
                    onDeletePassToggleRecive);
            }
        }

        private void PassToggleTest(int id)
        {
            connection.SendCommand(
                new RequestInfo(
                    "PassToggleTest",
                    SequrityUtils.Encrypt(
                        id.ToString(),
                        connection.User.SecretKey),
                    connection.User.UserToken),
                onDeletePassToggleRecive);
        }

        private void onDeletePassToggleRecive(string data)
        {
            var response = ResponseInfo.FromJson(data);
            if (response.Error != null)
            {
                MessageBox.Show(response.Error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (SequrityUtils.DecryptString(response.Data, connection.User.SecretKey) != "OK")
                    MessageBox.Show("Неизвестная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    GetCurrentSheet();
            }
        }

        private void comboBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxData.SelectedIndex == 2)
            {
                labelTestNameSurname.Text = "Фамилия:";
                labelSubjectRole.Text = "Тип аккаунта:";
                checkBoxDate.Visible = false;
                SetRoles();
            }
            else
            {
                labelTestNameSurname.Text = "Название:";
                labelSubjectRole.Text = "Дисциплина/Предмет:";
                checkBoxDate.Visible = true;
                SetSubjects();
            }
            ClearFilters();
            GetCurrentSheet();
        }

        private void buttonClearFilters_Click(object sender, EventArgs e)
        {
            ClearFilters();
            GetCurrentSheet();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if(senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
            {
                switch (comboBoxData.SelectedIndex)
                {
                    case 0:
                        using (var resultsDialog = new DBTestResults(Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].Value), connection))
                        {
                            resultsDialog.ShowDialog();
                        }
                        break;
                    case 1:
                        switch (e.ColumnIndex)
                        {
                            case 6:
                                using (var resultsDialog = new DBTestResults(Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].Value), connection))
                                {
                                    resultsDialog.ShowDialog();
                                }
                                break;
                            case 7:
                                PassToggleTest(Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].Value));
                                break;
                            case 8:
                                DeleteTest(Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].Value));
                                break;
                        }
                        break;
                    case 2:
                        switch (e.ColumnIndex)
                        {
                            case 6:
                                using(var editDialog = new EditUserInfoForm(
                                    connection, 
                                    Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].Value),
                                    (string)senderGrid.Rows[e.RowIndex].Cells[1].Value,
                                    (string)senderGrid.Rows[e.RowIndex].Cells[2].Value,
                                    (string)senderGrid.Rows[e.RowIndex].Cells[3].Value,
                                    (string)senderGrid.Rows[e.RowIndex].Cells[5].Value,
                                    (UserRoles)subjectsRoles.FirstOrDefault(
                                        x => x.Value == (string)senderGrid.Rows[e.RowIndex].Cells[4].Value)
                                    .Key - 1))
                                {
                                    editDialog.ShowDialog();
                                    GetCurrentSheet();
                                }
                                break;
                            case 7:
                                DeleteUser(Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].Value));
                                break;
                        }
                        break;
                }
            }
        }

        private void textBoxTestNameSurname_Leave(object sender, EventArgs e)
        {
            GetCurrentSheet();
        }

        private void DatabaseForm_Click(object sender, EventArgs e)
        {
            buttonClearFilters.Focus();
        }

        private void textBoxTestNameSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
                buttonClearFilters.Focus();
        }

        private void comboBoxSubjectRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCurrentSheet();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            GetCurrentSheet();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            using(var addSubjectDialog = new AddSubject(connection))
            {
                addSubjectDialog.ShowDialog();
            }
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            using (var addGroupDialog = new AddGroup(connection))
            {
                addGroupDialog.ShowDialog();
            }
        }

        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            GetCurrentSheet();
        }
    }
}
