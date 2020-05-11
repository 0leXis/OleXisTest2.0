using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OleXisTest
{
    public partial class SequenceVariantPassControl : UserControl, IVariantPassingControl
    {
        SequenceQuestionAnswer answer;
        public SequenceVariantPassControl(SequenceQuestionAnswer sequenceQuestionAnswer, bool isPreviewState)
        {
            InitializeComponent();
            answer = sequenceQuestionAnswer;
            var added_indexes = new HashSet<int>();
            var rnd = new Random();
            //Добавление вариантов в случайном порядке
            for(var i = 0; i < sequenceQuestionAnswer.Variants.Count; i++)
            {
                int index;
                do
                    index = rnd.Next(0, sequenceQuestionAnswer.Variants.Count);
                while (added_indexes.Contains(index));
                added_indexes.Add(index);
                listBoxSequence.Items.Add(sequenceQuestionAnswer.Variants[index]);
            }
            if (!isPreviewState)
            {
                listBoxSequence.AllowDrop = true;
                listBoxSequence.DragEnter += listBox_DragEnter;
                listBoxSequence.DragDrop += listBox_DragDrop;
                listBoxSequence.MouseMove += listBox_MouseMove;
            }
        }

        public bool CheckAnswer()
        {
            for (var i = 0; i < answer.Variants.Count; i++)
                if (answer.Variants[i] != (string)listBoxSequence.Items[i])
                    return false;
            return true;
        }

        public IAnswerListItem GetAnswerListItem(string short_question_desc = null)
        {
            var answerListItem = new AnswerListItem();
            answerListItem.IsRight = true;
            //TODO: Система баллов
            answerListItem.Question_score = 1;
            if (short_question_desc != null)
                answerListItem.QuestionDescription = short_question_desc;
            for (var i = 0; i < answer.Variants.Count; i++)
                if (answer.Variants[i] == (string)listBoxSequence.Items[i])
                    answerListItem.Variants.Add(new AnswerListVariant(AnswerVariations.RightAnswerChoosed, answer.Variants[i]));
                else
                {
                    answerListItem.IsRight = false;
                    answerListItem.Variants.Add(new AnswerListVariant(AnswerVariations.WrongAnswerChoosed, answer.Variants[i]));
                }
            return answerListItem;
        }

        public void SetDefaultDockStyle()
        {
            Dock = DockStyle.None;
        }

        //индекс перемещаемого элемента
        int indexToMove;

        private void listBox_DragDrop(object sender, DragEventArgs e)
        {
            var listBox = sender as ListBox;
            //индекс, куда перемещаем
            int newIndex = listBox.IndexFromPoint(listBox.PointToClient(new Point(e.X, e.Y)));
            //если вставка происходит в начало списка
            if (newIndex == -1)
            {
                //получаем перетаскиваемый элемент
                object itemToMove = listBox.Items[indexToMove];
                //удаляем элемент
                listBox.Items.RemoveAt(indexToMove);
                //добавляем в конец списка
                listBox.Items.Add(itemToMove);
            }
            //вставляем где-то в середину списка
            else if (indexToMove != newIndex)
            {
                //получаем перетаскиваемый элемент
                object itemToMove = listBox.Items[indexToMove];
                //удаляем элемент
                listBox.Items.RemoveAt(indexToMove);
                //вставляем в конкретную позицию
                listBox.Items.Insert(newIndex, itemToMove);
            }
        }

        private void listBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBox_MouseMove(object sender, MouseEventArgs e)
        {
            var listBox = sender as ListBox;
            //если нажата левая кнопка мыши, начинаем Drag&Drop
            if (e.Button == MouseButtons.Left)
            {
                //индекс элемента, который мы перемещаем
                indexToMove = listBox.IndexFromPoint(e.X, e.Y);
                listBox.DoDragDrop(indexToMove, DragDropEffects.Move);
            }
        }
    }
}
