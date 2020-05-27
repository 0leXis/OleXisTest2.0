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
    public partial class Editor : Form
    {
        private UserControl previewAnswerControl;
        private UserControl previewInfoControl;

        private ITest testForEdit;
        private IQuestion currentQuestionPreview;
        private string currentSection;

        private NetConnection connection;
        public Editor(NetConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            if (connection != null && connection.IsConnected)
            {
                загрузитьССервераToolStripMenuItem.Enabled = true;
            }
        }

        private void CreateTest()
        {
            if (testForEdit != null)
                if (MessageBox.Show("Вы уверены?" + Environment.NewLine + "Все несохраненные данные текущего теста будут потеряны", "Создание теста", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            testForEdit = new Test();
            InitTestControls();
            Text = "OleXis Test: Редактор тестов - Безимянный.test";
            //TODO: перенести
            //Program.testParams.GetInfoFromTest(TestForEdit);
        }

        private void CreateQuestion()
        {
            var sectionsList = new List<string>();
            foreach (TreeNode node in tvQuestions.Nodes)
                sectionsList.Add(node.Text);
            using (var createQuestionForm = new CreateEditQuestion(this, sectionsList))
            {
                createQuestionForm.ShowDialog();
                if (createQuestionForm.Question != null)
                {
                    var question = createQuestionForm.Question;
                    testForEdit.Questions.Add(question);
                    if (question.Section == null)
                        tvQuestions.Nodes[0].Nodes.Add(question.Name, question.Name);
                    else
                        tvQuestions.Nodes.Find(question.Section, false)[0].Nodes.Add(question.Name, question.Name);
                    SetQuestionPreview(question.Name);
                }
            }
        }

        private void ChangeQuestion()
        {
            var sectionsList = new List<string>();
            foreach (TreeNode node in tvQuestions.Nodes)
                sectionsList.Add(node.Text);
            using (var createQuestionForm = new CreateEditQuestion(this, sectionsList, currentQuestionPreview))
            {
                createQuestionForm.ShowDialog();
                if (createQuestionForm.Question != null)
                {
                    tvQuestions.Nodes.Remove(tvQuestions.Nodes.Find(currentQuestionPreview.Name, true)[0]);
                    testForEdit.Questions.Remove(currentQuestionPreview);

                    var question = createQuestionForm.Question;
                    testForEdit.Questions.Add(question);
                    if (question.Section == null)
                        tvQuestions.Nodes[0].Nodes.Add(question.Name, question.Name);
                    else
                        tvQuestions.Nodes.Find(question.Section, false)[0].Nodes.Add(question.Name, question.Name);
                    SetQuestionPreview(question.Name);
                }
            }
        }

        private void CreateSection()
        {
            using (var sectionName = new SectionNameDialog(this))
            {
                sectionName.ShowDialog();
                if (sectionName.SectionName != null)
                {
                    testForEdit.Sections.Add(sectionName.SectionName);
                    tvQuestions.Nodes.Add(sectionName.SectionName, sectionName.SectionName);
                    buttonDeleteVopr.Enabled = false;
                    buttonDeleteSection.Enabled = false;
                    ResetQuestionPreview();
                }
            }
        }

        private void ChangeSection()
        {
            using (var sectionName = new SectionNameDialog(this, currentSection))
            {
                sectionName.ShowDialog();
                if (sectionName.SectionName != null)
                {
                    testForEdit.Sections.Remove(currentSection);
                    testForEdit.Sections.Add(sectionName.SectionName);

                    foreach (var question in testForEdit.Questions)
                        if (question.Section == currentSection)
                            question.Section = sectionName.SectionName;
                    InitTestControls();
                    //buttonDeleteVopr.Enabled = false;
                    //buttonDeleteSection.Enabled = false;
                    //ResetQuestionPreview();
                }
            }
        }

        private void ChangeTestParams()
        {
            using(var testParamsDialog = new TestParamsDialog(testForEdit.Params, testForEdit.Questions.Count))
            {
                if (testParamsDialog.ShowDialog() == DialogResult.OK)
                {
                    testForEdit.Params.SetParams(testParamsDialog.TestParams);
                }
            }
        }

        private void DeleteQuestion()
        {
            if (MessageBox.Show("Вы уверены?", "Удаление вопроса", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tvQuestions.Nodes.Remove(tvQuestions.Nodes.Find(currentQuestionPreview.Name, true)[0]);
                testForEdit.Questions.Remove(currentQuestionPreview);
                buttonDeleteVopr.Enabled = false;
                buttonDeleteSection.Enabled = false;
                ResetQuestionPreview();
            }
        }

        private void DeleteSection()
        {
            if (MessageBox.Show("Вы уверены? Все вопросы в разделе будут удалены", "Удаление раздела", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (var i = 0; i < testForEdit.Questions.Count; i++)
                    if (testForEdit.Questions[i].Section == currentSection)
                    {
                        tvQuestions.Nodes.Remove(tvQuestions.Nodes.Find(testForEdit.Questions[i].Name, true)[0]);
                        testForEdit.Questions.RemoveAt(i);
                        i--;
                    }
                testForEdit.Sections.Remove(currentSection);
                tvQuestions.Nodes.Remove(tvQuestions.Nodes.Find(currentSection, false)[0]);
                buttonDeleteVopr.Enabled = false;
                buttonDeleteSection.Enabled = false;
            }
        }

        private void DisableButtons()
        {
            тестToolStripMenuItem.Enabled = false;
            сохранитьТестToolStripMenuItem.Enabled = false;
            buttonCreateSection.Enabled = false;
            buttonCreateVopr.Enabled = false;
            сохранитьНаСервереToolStripMenuItem.Enabled = false;
        }

        private void EnableButtons()
        {
            тестToolStripMenuItem.Enabled = true;
            сохранитьТестToolStripMenuItem.Enabled = true;
            buttonCreateSection.Enabled = true;
            buttonCreateVopr.Enabled = true;
            if (connection != null && connection.IsConnected)
            {
                сохранитьНаСервереToolStripMenuItem.Enabled = true;
            }
        }

        private void InitTestControls()
        {
            tvQuestions.Nodes.Clear();
            tvQuestions.Nodes.Add("Без раздела", "Без раздела");
            foreach (var section in testForEdit.Sections)
                tvQuestions.Nodes.Add(section, section);
            foreach (var question in testForEdit.Questions)
            {
                if (question.Section == null)
                    tvQuestions.Nodes[0].Nodes.Add(question.Name, question.Name);
                else
                    tvQuestions.Nodes.Find(question.Section, false)[0].Nodes.Add(question.Name, question.Name);
            }
            ResetQuestionPreview();
            EnableButtons();
        }

        public bool CheckQuestionOrSectionName(string name)
        {
            if (testForEdit.Questions.Find((question) => question.Name == name) == null &&
                testForEdit.Sections.Find((section) => section == name) == null)
                return false;
            else
                return true;
        }

        private void SetQuestionPreview(string questionOrSectionName)
        {
            ResetQuestionPreview();
            currentQuestionPreview = testForEdit.Questions.Find((item) => item.Name == questionOrSectionName);
            if (currentQuestionPreview != null)
            {
                buttonDeleteVopr.Enabled = true;
                buttonChangeVopr.Enabled = true;

                previewInfoControl = InfoViewFactory.GetInfoViewControl(currentQuestionPreview.QuestionInfo) as UserControl;
                previewInfoControl.Location = new Point(3, 25);
                groupBoxInfo.Controls.Add(previewInfoControl);

                previewAnswerControl = PassingControlFactory.GetPassingControl(currentQuestionPreview.QuestionAnswer, true) as UserControl;
                (previewAnswerControl as IVariantPassingControl).SetDefaultDockStyle();
                previewAnswerControl.Location = new Point(3, 25);
                groupBoxAnswers.Controls.Add(previewAnswerControl);
                groupBoxAnswers.Text = "Ответы (" + currentQuestionPreview.QuestionAnswer.QuestionScore + " баллов за правильный ответ)";
            }
            else
            {
                if (questionOrSectionName != "Без раздела")
                {
                    buttonDeleteSection.Enabled = true;
                    buttonChangeSection.Enabled = true;
                }
                currentSection = questionOrSectionName;
            }
        }

        private void ResetQuestionPreview()
        {
            buttonDeleteVopr.Enabled = false;
            buttonDeleteSection.Enabled = false;
            buttonChangeVopr.Enabled = false;
            buttonChangeSection.Enabled = false;
            foreach (Control control in groupBoxInfo.Controls)
            {
                control.Dispose();
            }
            groupBoxInfo.Controls.Clear();

            foreach (Control control in groupBoxAnswers.Controls)
            {
                control.Dispose();
            }
            groupBoxAnswers.Controls.Clear();
            groupBoxAnswers.Text = "Ответы";
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTest();
        }

        private void buttonCreateVopr_Click(object sender, EventArgs e)
        {
            CreateQuestion();
        }

        private void tvQuestions_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SetQuestionPreview(e.Node.Text);
            }
        }

        private void buttonDeleteVopr_Click(object sender, EventArgs e)
        {
            DeleteQuestion();
        }

        private void buttonDeleteSection_Click(object sender, EventArgs e)
        {
            DeleteSection();
        }

        private void buttonCreateSection_Click(object sender, EventArgs e)
        {
            CreateSection();
        }

        private void buttonChangeVopr_Click(object sender, EventArgs e)
        {
            ChangeQuestion();
        }

        private void Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (testForEdit != null)
                if (MessageBox.Show("Вы уверены?" + Environment.NewLine + "Все несохраненные данные текущего теста будут потеряны", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    e.Cancel = true;
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName;
            var test = FileProcessor.LoadTestFile(out fileName);
            if(test != null)
            {
                testForEdit = test;
                Text = "OleXis Test: Редактор тестов - " + fileName;
                InitTestControls();
            }
        }

        private void сохранитьТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename;
            if (!FileProcessor.SaveTestFile(testForEdit, out filename))
                MessageBox.Show("При сохранении теста произошла ошибка", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Text = "OleXis Test: Редактор тестов - " + filename;
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (testForEdit != null)
                if (MessageBox.Show("Вы уверены?" + Environment.NewLine + "Все несохраненные данные текущего теста будут потеряны", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            tvQuestions.Nodes.Clear();
            testForEdit = null;
            ResetQuestionPreview();
            DisableButtons();
        }

        private void создатьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateQuestion();
        }

        private void редактироватьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeQuestion();
        }

        private void создатьРазделToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateSection();
        }

        private void редактироватьРазделToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSection();
        }

        private void параметрыТестаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTestParams();
        }

        private void buttonChangeSection_Click(object sender, EventArgs e)
        {
            ChangeSection();
        }

        private void сохранитьНаСервереToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(var saveDialog = new ServerSaveDialog(connection, testForEdit))
            {
                saveDialog.ShowDialog();
                if(saveDialog.TestName != null)
                    Text = "OleXis Test: Редактор тестов - " + saveDialog.TestName;
            }
        }

        private void загрузитьССервераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var loadDialog = new ServerLoadDialog(connection, false))
            {
                if(loadDialog.ShowDialog() == DialogResult.OK)
                    if(loadDialog.Test != null)
                    {
                        Text = "OleXis Test: Редактор тестов - " + loadDialog.TestName;
                        testForEdit = loadDialog.Test;
                        InitTestControls();
                    }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
