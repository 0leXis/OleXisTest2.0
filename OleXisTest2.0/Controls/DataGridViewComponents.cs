using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace OleXisTest
{
    static class DataGridViewComponents
    {
        static public readonly Font defaultFont = new Font("Calibri", 12);
        static public DataGridViewTextBoxCell GetDataGridViewRowTextBoxCell(string Text)
        {
            var cell = new DataGridViewTextBoxCell();
            cell.Style.Font = defaultFont;
            cell.Value = Text;
            return cell;
        }

        static public DataGridViewButtonCell GetDataGridViewRowButtonCell(string Text)
        {
            var cell = new DataGridViewButtonCell();
            cell.Style.Font = defaultFont;
            cell.FlatStyle = FlatStyle.Flat;
            cell.Style.BackColor = Color.FromArgb(255, 219, 101);
            cell.Value = Text;
            return cell;
        }

        static public DataGridViewColumnHeaderCell GetDataGridViewColumnHeaderCell(string Text)
        {
            var cell = new DataGridViewColumnHeaderCell();
            cell.Style.Font = defaultFont;
            cell.Value = Text;
            return cell;
        }

    }
}
