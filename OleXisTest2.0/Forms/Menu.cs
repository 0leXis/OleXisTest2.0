﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace OleXisTest
{
    public partial class Menu : Form
    {
        private NetConnection connection;
        private AccountInfo loginInfo;
        public Menu() 
        {
            InitializeComponent();
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            using(var editorForm = new Editor(connection))
            {
                Hide();
                editorForm.ShowDialog();
                Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            using (var studentData = new StudentDataDialog())
            {
                if (studentData.ShowDialog() == DialogResult.OK)
                {
                    string fileName;
                    var test = FileProcessor.LoadTestFile(out fileName);
                    if(test != null)
                    {
                        using (var passing = new TestPassing(studentData.FIO, studentData.Class, test))
                        {
                            Hide();
                            passing.ShowDialog();
                            Show();
                        }
                    }
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.IsConnected)
            {
                labelLoginStatus.Text = "Соединение не установлено";
                labelLoginStatus.ForeColor = Color.Firebrick;
                connection.Disconnect();
                btnPassword.Enabled = false;
                buttonRunServer.Enabled = false;
                btnDB.Enabled = false;
                btnConnect.Text = "Подключится к серверу";
                labelName.Visible = false;
                labelSurname.Visible = false;
                labelLogin.Visible = false;
                labelGroup.Visible = false;
                labelRole.Visible = false;
            }
            else
            {
                using (var connectionForm = new ConnectToServer())
                {
                    if (connectionForm.ShowDialog() == DialogResult.OK)
                    {
                        connection = connectionForm.Connection;
                        loginInfo = connectionForm.LoginInfo;

                        labelLoginStatus.Text = "Соединение установлено";
                        labelLoginStatus.ForeColor = Color.LightGreen;
                        labelName.Text = connectionForm.LoginInfo.Firstname;
                        labelName.Visible = true;
                        labelSurname.Text = connectionForm.LoginInfo.Lastname;
                        labelSurname.Visible = true;
                        labelLogin.Text = "Логин: " + connectionForm.Login;
                        labelLogin.Visible = true;
                        switch (connectionForm.LoginInfo.Role)
                        {
                            case UserRoles.Admin:
                                labelRole.Text = "Администратор";
                                break;
                            case UserRoles.Student:
                                labelRole.Text = "Учащийся";
                                break;
                            case UserRoles.Teacher:
                                labelRole.Text = "Преподаватель";
                                break;
                        }
                        labelRole.Visible = true;
                        if (connectionForm.LoginInfo.Group != null)
                        {
                            labelGroup.Text = "Группа/класс: " + connectionForm.LoginInfo.Group;
                            labelGroup.Visible = true;
                        }
                        btnPassword.Enabled = true;
                        btnDB.Enabled = true;
                        buttonRunServer.Enabled = true;
                        btnConnect.Text = "Отключиться от сервера";
                    }
                }
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection != null)
                connection.Disconnect();
        }

        private void btnDB_Click(object sender, EventArgs e)
        {
            using(var dbForm = new DatabaseForm(connection, loginInfo.Role))
            {
                Hide();
                dbForm.ShowDialog();
                Show();
            }
        }

        private void buttonRunServer_Click(object sender, EventArgs e)
        {
            using (var serverTestLoader = new ServerLoadDialog(connection, true))
            {
                if(serverTestLoader.ShowDialog() == DialogResult.OK)
                    if(serverTestLoader.Test != null)
                    {
                        using (var passing = new TestPassing(labelSurname.Text + " " + labelName.Text, labelGroup.Text, serverTestLoader.Test))
                        {
                            Hide();
                            passing.ShowDialog();
                            Show();
                        }
                    }
            }
        }
    }
}
