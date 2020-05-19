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
    public partial class TestPassing : Form
    {
        private NetConnection connection;

        private UserControl answerControl;
        private UserControl infoControl;

        private ITest test;
        private List<IQuestion> questions;
        private List<AnswerListItem> answers;
        private int minutes;
        private int seconds;
        private int seconds_passed;
        private int current_question;
        private string FIO;
        private string Class;

        private bool isTimeLimited = false;
        private bool isServerTest = false;
        public TestPassing(string FIO, string Class, ITest test, NetConnection connection, bool isServerTest)
        {
            InitializeComponent();
            this.connection = connection;
            this.isServerTest = isServerTest;

            this.test = test;
            this.FIO = FIO;
            this.Class = Class;
            answers = new List<AnswerListItem>();
            //Определение вопросов теста
            var rnd = new Random();
            switch (test.Params.QuestionAllocation)
            {
                case QuestionAllocation.One_Variant:
                    questions = new List<IQuestion>(test.Questions);
                    break;
                case QuestionAllocation.Section_Variant:
                    var Variant = test.Sections[rnd.Next(0, test.Sections.Count)];
                    questions = new List<IQuestion>(from elem in test.Questions where elem.Section == Variant select elem);
                    break;
                case QuestionAllocation.Generate:
                    for (var i = 0; i < test.Sections.Count; i++)
                    {
                        Variant = test.Sections[i];
                        var TmpLst = new List<IQuestion>(from elem in test.Questions where elem.Section == Variant select elem);
                        var TmpVoprList = new List<IQuestion>();
                        var Set = new HashSet<int>();
                        while (TmpVoprList.Count < test.Params.CountForGenerate)
                        {
                            var rndnum = rnd.Next(0, TmpLst.Count);
                            if (!Set.Contains(rndnum))
                            {
                                TmpVoprList.Add(TmpLst[rndnum]);
                                Set.Add(rndnum);
                            }
                        }
                        questions.AddRange(TmpVoprList);
                    }
                    break;
            }
            //Запуск теста
            if(test.Params.TimeForTest != 0)
            {
                isTimeLimited = true;
                minutes = test.Params.TimeForTest;
            }
            seconds_passed = 0;
            timerTestTime.Start();
            current_question = -1;
            NextQuestion();
        }

        private void NextQuestion()
        {
            //Удаление элементов для предидущего вопроса
            foreach (Control control in groupBoxInfo.Controls)
            {
                control.Dispose();
            }
            groupBoxInfo.Controls.Clear();

            foreach (Control control in groupBoxAnswer.Controls)
            {
                control.Dispose();
            }
            groupBoxAnswer.Controls.Clear();

            //Индекс следующего вопроса
            current_question++;
            if (current_question == questions.Count)
            {
                StopTest();
                return;
            }

            infoControl = InfoViewFactory.GetInfoViewControl(questions[current_question].QuestionInfo) as UserControl;
            infoControl.Location = new Point(3, 25);
            groupBoxInfo.Controls.Add(infoControl);

            answerControl = PassingControlFactory.GetPassingControl(questions[current_question].QuestionAnswer, false) as UserControl;
            (answerControl as IVariantPassingControl).SetDefaultDockStyle();
            answerControl.Location = new Point(3, 25);
            groupBoxAnswer.Controls.Add(answerControl);
        }

        private void GetAnswer()
        {
            answers.Add((answerControl as IVariantPassingControl).GetAnswerListItem(questions[current_question].Name, questions[current_question].QuestionInfo.GetShortDescription()));
        }

        private void StopTest()
        {
            timerTestTime.Stop();
            using (var resultDialog = new TestResults(FIO, Class, seconds_passed % 60, seconds_passed / 60, answers, isServerTest, connection))
            {
                resultDialog.ShowDialog();
            }
            DialogResult = DialogResult.OK;
        }

        private void FailLastQuestions()
        {
            for(var i = current_question; i < questions.Count; i++)
            {
                var answer = new AnswerListItem();
                answer.IsRight = false;
                answer.QuestionName = questions[current_question].Name;
                answer.Question_score = questions[current_question].QuestionAnswer.QuestionScore;
                answer.Variants.Add(new AnswerListVariant(AnswerVariations.NoAnswer, "Нет ответа"));
                answers.Add(answer);
            }
        }

        private void timerTestTime_Tick(object sender, EventArgs e)
        {
            seconds_passed++;
            if (isTimeLimited)
            {
                if (seconds == 0)
                {
                    minutes -= 1;
                    seconds = 60;
                }
                if (minutes == 0)
                {
                    FailLastQuestions();
                    StopTest();
                    return;
                }
                seconds -= 1;
                labelTime.Text = "Времени осталось: " + minutes + ":" + seconds;
            }
        }

        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            if (!(answerControl as IVariantPassingControl).ValidateAnswer())
                return;
            GetAnswer();
            NextQuestion();
        }

        private void buttonStopTest_Click(object sender, EventArgs e)
        {
            FailLastQuestions();
            StopTest();
            return;
        }
    }
}
