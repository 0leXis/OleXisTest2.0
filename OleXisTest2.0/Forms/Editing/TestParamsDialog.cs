﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OleXisTest
{
    public partial class TestParamsDialog : Form
    {
        //Время на прохождение
        public TestParams TestParams
        {
            get
            {
                return _TestParams;
            }
        }

        private TestParams _TestParams;

        public TestParamsDialog()
        {
            InitializeComponent();
            comboBoxTime.SelectedIndex = 0;
        }

        //Загрузить данные на форму
        public TestParamsDialog(TestParams testParams, int testQuestionCount)
        {
            InitializeComponent();
            if (testParams.TimeForTest == 0)
                comboBoxTime.Text = "Не ограничено";
            else
                comboBoxTime.Text = testParams.TimeForTest.ToString();

            if (testParams.QuestionAllocation == QuestionAllocation.One_Variant)
                radioButton1Variant.Checked = true;
            else
                if (testParams.QuestionAllocation == QuestionAllocation.Section_Variant)
                radioButtonEachSection.Checked = true;
            else
            {
                numericUpDownCount.Enabled = true;
                radioButtonRandom.Checked = true;
            }

            if (testQuestionCount < 1)
            {
                radioButton1Variant.Checked = true;
                radioButtonRandom.Enabled = false;
                numericUpDownCount.Enabled = false;
                testParams.CountForGenerate = 1;
            }
            else
                numericUpDownCount.Maximum = testQuestionCount;
            if (testParams.QuestionAllocation == QuestionAllocation.Generate)
                numericUpDownCount.Value = testParams.CountForGenerate;
            else
                numericUpDownCount.Value = 1;

            textBoxPassword.Text = testParams.Password;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            _TestParams = new TestParams();

            if (comboBoxTime.Text == "Не ограничено")
                _TestParams.TimeForTest = 0;
            else
                _TestParams.TimeForTest = Convert.ToInt32(comboBoxTime.Text);

            if (radioButton1Variant.Checked)
                _TestParams.QuestionAllocation = QuestionAllocation.One_Variant;
            else
            if (radioButtonEachSection.Checked)
                _TestParams.QuestionAllocation = QuestionAllocation.Section_Variant;
            else
                _TestParams.QuestionAllocation = QuestionAllocation.Generate;

            _TestParams.CountForGenerate = Convert.ToInt32(numericUpDownCount.Value);

            _TestParams.Password = textBoxPassword.Text;
        }
        //Генерация пароля
        private void buttonGeneratePass_Click(object sender, EventArgs e)
        {
            textBoxPassword.Text = "";
            var rndforPassword = new Random();
            for (var i = 0; i < 10; i++)
            {
                textBoxPassword.Text += Convert.ToChar(rndforPassword.Next(48, 90));
            }
        }

        private void radioButtonRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRandom.Checked)
                numericUpDownCount.Enabled = true;
            else
                numericUpDownCount.Enabled = false;
        }
    }
}
