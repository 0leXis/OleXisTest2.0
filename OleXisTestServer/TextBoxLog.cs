using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OleXisTestServer
{
    class TextBoxLog : ILog
    {
        private delegate void SafeCallDelegate(string text);
        TextBoxBase textBox;

        public TextBoxLog(TextBoxBase textBox)
        {
            this.textBox = textBox;
        }

        public void LogMessage(string message)
        {
            if (textBox == null)
                throw new ArgumentNullException("Значение textBox не может быть null");
            if (textBox.InvokeRequired)
            {
                textBox.BeginInvoke(new SafeCallDelegate(LogMessage), new object[] { message });
            }
            else
            {
                textBox.AppendText(DateTime.Now + " [СЕРВЕР]: " + message + Environment.NewLine);
            }
        }

        public void LogError(string message)
        {
            if (textBox == null)
                throw new ArgumentNullException("Значение textBox не может быть null");
            if (textBox.InvokeRequired)
            {
                textBox.BeginInvoke(new SafeCallDelegate(LogError), new object[] { message });
            }
            else
            {
                textBox.AppendText(DateTime.Now + " [ОШИБКА]: " + message + Environment.NewLine);
            }
        }

        public void LogWarning(string message)
        {
            if (textBox == null)
                throw new ArgumentNullException("Значение textBox не может быть null");
            if (textBox.InvokeRequired)
            {
                textBox.BeginInvoke(new SafeCallDelegate(LogWarning), new object[] { message });
            }
            else
            {
                textBox.AppendText(DateTime.Now + " [ПРЕДУПРЕЖДЕНИЕ]: " + message + Environment.NewLine);
            }
        }
    }
}
