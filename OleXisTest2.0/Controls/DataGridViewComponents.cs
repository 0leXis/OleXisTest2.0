using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OleXisTest
{
    static class DataGridViewComponents
    {
        static public DataGridViewTextBoxCell GetDataGridViewRowTextBoxCell(string Text)
        {
            var cell = new DataGridViewTextBoxCell();
            cell.Value = Text;
            return cell;
        }

        static public DataGridViewButtonCell GetDataGridViewRowButtonCell(string Text)
        {
            var cell = new DataGridViewButtonCell();
            cell.Value = Text;
            return cell;
        }

        static public DataGridViewColumnHeaderCell GetDataGridViewColumnHeaderCell(string Text)
        {
            var cell = new DataGridViewColumnHeaderCell();
            cell.Value = Text;
            return cell;
        }

    }
}
