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
    public partial class AccordanceVariantPassControl : UserControl, IVariantPassingControl
    {
        AccordanceQuestionAnswer answer;
        public AccordanceVariantPassControl(AccordanceQuestionAnswer accordanceQuestionAnswer, bool isPreviewState)
        {
            InitializeComponent();
            answer = accordanceQuestionAnswer;
            //Добавление вариантов в случайном порядке
            var added_variants_indexes = new HashSet<int>();
            var added_accordanses_indexes = new HashSet<int>();
            var rnd = new Random();
            for(var i = 0; i < answer.Accordances.Count; i++)
            {
                int index;
                do
                    index = rnd.Next(0, answer.Accordances.Count);
                while (added_variants_indexes.Contains(index));
                added_variants_indexes.Add(index);
                listBoxAcc1.Items.Add(answer.Variants[index]);

                do
                    index = rnd.Next(0, answer.Accordances.Count);
                while (added_accordanses_indexes.Contains(index));
                added_accordanses_indexes.Add(index);
                listBoxAcc2.Items.Add(answer.Accordances[index]);
            }
            if (!isPreviewState)
            {
                listBoxAcc1.DragEnter += listBox_DragEnter;
                listBoxAcc1.DragDrop += listBox_DragDrop;
                listBoxAcc1.MouseMove += listBox_MouseMove;

                listBoxAcc2.DragEnter += listBox_DragEnter;
                listBoxAcc2.DragDrop += listBox_DragDrop;
                listBoxAcc2.MouseMove += listBox_MouseMove;
            }
        }

        public bool CheckAnswer()
        {
            for(var i = 0; i < answer.Accordances.Count; i++) 
            {
                if (listBoxAcc1.Items.IndexOf(answer.Accordances[i]) != listBoxAcc2.Items.IndexOf(answer.Variants[i]))
                    return false;
            }
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
            for (var i = 0; i < answer.Accordances.Count; i++)
            {
                if (listBoxAcc1.Items.IndexOf(answer.Accordances[i]) != listBoxAcc2.Items.IndexOf(answer.Variants[i]))
                {
                    answerListItem.Variants.Add(new AnswerListVariant(AnswerVariations.WrongAnswerChoosed, answer.Variants[i] + " - " + answer.Accordances[i]));
                    answerListItem.IsRight = false;
                }
                else
                {
                    answerListItem.Variants.Add(new AnswerListVariant(AnswerVariations.RightAnswerChoosed, answer.Variants[i] + " - " + answer.Accordances[i]));
                }
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
            var listbox = sender as ListBox;
            //индекс, куда перемещаем
            int newIndex = listbox.IndexFromPoint(listbox.PointToClient(new Point(e.X, e.Y)));
            //если вставка происходит в начало списка
            if (newIndex == -1)
            {
                //получаем перетаскиваемый элемент
                object itemToMove = listbox.Items[indexToMove];
                //удаляем элемент
                listbox.Items.RemoveAt(indexToMove);
                //добавляем в конец списка
                listbox.Items.Add(itemToMove);
            }
            //вставляем где-то в середину списка
            else if (indexToMove != newIndex)
            {
                //получаем перетаскиваемый элемент
                object itemToMove = listbox.Items[indexToMove];
                //удаляем элемент
                listbox.Items.RemoveAt(indexToMove);
                //вставляем в конкретную позицию
                listbox.Items.Insert(newIndex, itemToMove);
            }
        }

        private void listBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBox_MouseMove(object sender, MouseEventArgs e)
        {
            var listbox = sender as ListBox;
            //если нажата левая кнопка мыши, начинаем Drag&Drop
            if (e.Button == MouseButtons.Left)
            {
                //индекс элемента, который мы перемещаем
                indexToMove = listbox.IndexFromPoint(e.X, e.Y);
                listbox.DoDragDrop(indexToMove, DragDropEffects.Move);
            }
        }
    }
}
