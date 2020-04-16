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
    public partial class CreateEditQuestion : Form
    {
        public IQuestion Question 
        {
            get
            {
                return _question;
            }
        }
        IInfoEditControl infoEdit;
        IQuestionAnswer _answer;
        Editor parent;
        IQuestion _question = null;
        bool _isChangeQuestionState = false;
        public CreateEditQuestion(Editor parent, List<string> sections)
        {
            InitializeComponent();
            this.parent = parent;

            comboBoxType.SelectedIndex = 0;
            _answer = new SingleQuestionAnswer();

            foreach (var section in sections)
                comboBoxSection.Items.Add(section);
            comboBoxSection.SelectedIndex = 0;
            infoEdit = new SimpleInfoEditControl();
            panelInfo.Controls.Add(infoEdit as UserControl);
        }

        public CreateEditQuestion(Editor parent, List<string> sections, IQuestion questionToChange)
        {
            InitializeComponent();
            this.parent = parent;

            textBoxName.Enabled = false;
            _isChangeQuestionState = true;

            textBoxName.Text = questionToChange.Name;
            infoEdit = InfoEditableControlFactory.GetInfoEditableControl(questionToChange.QuestionInfo);
            panelInfo.Controls.Add(infoEdit as UserControl);

            if (questionToChange.QuestionAnswer is SingleQuestionAnswer)
            {
                comboBoxType.SelectedIndex = 0;
                _answer = new SingleQuestionAnswer(questionToChange.QuestionAnswer as SingleQuestionAnswer);
            }
            else
            if(questionToChange.QuestionAnswer is AlternativeQuestionAnswer)
            {
                comboBoxType.SelectedIndex = 1;
                _answer = new AlternativeQuestionAnswer(questionToChange.QuestionAnswer as AlternativeQuestionAnswer);
            }
            else
            if (questionToChange.QuestionAnswer is AccordanceQuestionAnswer)
            {
                comboBoxType.SelectedIndex = 2;
                _answer = new AccordanceQuestionAnswer(questionToChange.QuestionAnswer as AccordanceQuestionAnswer);
            }
            else
            if (questionToChange.QuestionAnswer is SequenceQuestionAnswer)
            {
                comboBoxType.SelectedIndex = 3;
                _answer = new SequenceQuestionAnswer(questionToChange.QuestionAnswer as SequenceQuestionAnswer);
            }
            else
            if (questionToChange.QuestionAnswer is FreeStatementQuestionAnswer)
            {
                comboBoxType.SelectedIndex = 4;
                _answer = new FreeStatementQuestionAnswer(questionToChange.QuestionAnswer as FreeStatementQuestionAnswer);
            }
            else
            if (questionToChange.QuestionAnswer is MultiQuestionAnswer)
            {
                comboBoxType.SelectedIndex = 5;
                _answer = new MultiQuestionAnswer(questionToChange.QuestionAnswer as MultiQuestionAnswer);
            }
            else
                throw new ArgumentException("Поле comboBoxType не содержит определения для данного типа QuestionAnswer");

            foreach (var section in sections)
                comboBoxSection.Items.Add(section);
            if (questionToChange.Section == null)
                comboBoxSection.SelectedIndex = 0;
            else
                comboBoxSection.SelectedIndex = comboBoxSection.Items.IndexOf(questionToChange.Section);
        }

        private void buttonRedaktVariants_Click(object sender, EventArgs e)
        {
            using (var editVariantsForm = new EditAnswerVariants(_answer))
            {
                if (editVariantsForm.ShowDialog() == DialogResult.OK)
                    _answer = editVariantsForm.QuestionAnswer;
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: предупреждение
            switch (comboBoxType.SelectedIndex)
            {
                case 0:
                    _answer = new SingleQuestionAnswer();
                    break;
                case 1:
                    _answer = new AlternativeQuestionAnswer();
                    break;
                case 2:
                    _answer = new AccordanceQuestionAnswer();
                    break;
                case 3:
                    _answer = new SequenceQuestionAnswer();
                    break;
                case 4:
                    _answer = new FreeStatementQuestionAnswer();
                    break;
                case 5:
                    _answer = new MultiQuestionAnswer();
                    break;
                default:
                    throw new ArgumentException("Поле comboBoxType содержит недопустимое значение");
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Поле \"Название\" должно быть заполнено", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!infoEdit.ValidateInfo())
                return;

            if (parent.CheckQuestionOrSectionName(textBoxName.Text) && !_isChangeQuestionState)
            {
                MessageBox.Show("Вопрос или раздел с таким именем уже существует", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_answer.ValidateAnswer())
                return;

            _question = new Question(textBoxName.Text, infoEdit.GetInfo(), _answer);
            if (comboBoxSection.SelectedIndex != 0)
                _question.Section = comboBoxSection.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
        }
    }
}
