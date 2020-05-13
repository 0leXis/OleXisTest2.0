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
    public partial class DatabaseForm : Form
    {
        NetConnection connection;
        UserRoles role;
        public DatabaseForm(NetConnection connection, UserRoles role)
        {
            InitializeComponent();
            this.role = role;
            this.connection = connection;
            switch (role)
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
    }
}
