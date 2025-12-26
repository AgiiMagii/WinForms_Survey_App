using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey.Lib
{
    public class Helper
    {
        public void ReloadGrid<T>(DataGridView grid, List<T> items, bool IsDelete) where T : class
        {
            if (grid.Columns.Contains("btnDelete"))
            {
                grid.Columns.Remove("btnDelete");
            }
            grid.DataSource = null;
            grid.DataSource = items;
            grid.AutoResizeColumns();

            if (IsDelete)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn
                {
                    HeaderText = "Actions",
                    Name = "btnDelete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };

                grid.Columns.Add(btnDelete);
                btnDelete.DisplayIndex = grid.Columns.GetColumnCount(DataGridViewElementStates.Visible) - 1;
            }
        }
        public void ClearForm(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = 1;
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                else if (control is RichTextBox)
                {
                    ((RichTextBox)control).Clear();
                }
                if (control.HasChildren)
                {
                    ClearForm(control.Controls);
                }
            }
        }
    }
}
