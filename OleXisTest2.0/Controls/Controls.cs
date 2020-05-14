using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace OleXisTest
{
    static class Controls
    {
        //Constants
        public const int INDENT_X = 5;
        public const int INDENT_Y = 34;
        public const int TEXT_BOX_WIDTH = 330;
        public const int VARIANTNUMBER_LABEL_WIDTH = 40;
        public const int RADIOBUTTON_WIDTH = 200;
        public const int PASSING_RADIOBUTTON_INDENT_Y = 20;
        static public readonly Point ARROW_BUTTON_SIZE = new Point(40, 28);
        static public readonly Point DELETE_BUTTON_SIZE = new Point(90, 28);
        public const int PANEL_YLOCATION = 68;

        //Style
        static private readonly Font defaultFont = new Font("Microsoft Sans Serif", 12);

        static public TextBox GetTextBox(int width, int top, Control parent, Control lastControlInSequence = null)
        {
            return new TextBox()
            {
                Parent = parent,
                Top = top,
                Left = (lastControlInSequence == null) ? INDENT_X : lastControlInSequence.Left + lastControlInSequence.Width + INDENT_X,
                Width = width,
                Font = defaultFont
            };
        }

        static public Button GetButton(string text, Point size, int top, Control parent, Control lastControlInSequence = null)
        {
            return new Button()
            {
                Parent = parent,
                Top = top,
                Left = (lastControlInSequence == null) ? INDENT_X : lastControlInSequence.Left + lastControlInSequence.Width + INDENT_X,
                Text = text,
                Width = size.X,
                Height = size.Y,
                Font = defaultFont
            };
        }

        static public Label GetLabel(string text, int width, int top, Control parent, Control lastControlInSequence = null)
        {
            return new Label()
            {
                Parent = parent,
                Top = top,
                Left = (lastControlInSequence == null) ? INDENT_X : lastControlInSequence.Left + lastControlInSequence.Width + INDENT_X,
                Width = width,
                Text = text,
                Font = defaultFont
            };
        }

        static public Label GetLabelYSequence(string text, int left, int width, int height, Control parent, Control lastControlInSequence = null)
        {
            return new Label()
            {
                Parent = parent,
                Top = (lastControlInSequence == null) ? 10 : lastControlInSequence.Top + lastControlInSequence.Height,
                Left = left,
                Width = width,
                Height = height,
                Text = text,
                Font = defaultFont
            };
        }

        static public RadioButton GetRadioButton(string text, int width, int top, Control parent, Control lastControlInSequence = null)
        {
            return new RadioButton()
            {
                Parent = parent,
                Top = top,
                Left = (lastControlInSequence == null) ? INDENT_X : lastControlInSequence.Left + lastControlInSequence.Width + INDENT_X,
                Width = width,
                Text = text,
                Font = defaultFont
            };
        }

        static public CheckBox GetCheckBox(string text, int width, int top, Control parent, Control lastControlInSequence = null)
        {
            return new CheckBox()
            {
                Parent = parent,
                Top = top,
                Left = (lastControlInSequence == null) ? INDENT_X : lastControlInSequence.Left + lastControlInSequence.Width + INDENT_X,
                Width = width,
                Text = text,
                Font = defaultFont
            };
        }

        static public int GetStringWidth(string str, Graphics componentGraphics)
        {
            return (int)componentGraphics.MeasureString(str, defaultFont).Width + 1;
        }

        static public int GetStringHeight(string str, Graphics componentGraphics)
        {
            return (int)componentGraphics.MeasureString(str, defaultFont).Height + 1;
        }
    }
}
