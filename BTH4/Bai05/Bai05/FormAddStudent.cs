using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class FormAddStudent : Form
    {
        public FormAddStudent()
        {
            InitializeComponent();
            textBoxID.Select();
            textBoxID.Focus();
            comboBoxDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDepartment.SelectedIndex = 0;
        }

        private bool AreControlsValid(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (c is TextBox tb && c.Visible)
                {
                    if (string.IsNullOrEmpty(tb.Text))
                        return false;
                }

                if (c.HasChildren)
                    AreControlsValid(c.Controls);
            }
            return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool valid = double.TryParse(textBoxGPA.Text, out double value);
            if (valid)
            {
                double GPA = double.Parse(textBoxGPA.Text);
                if (GPA < 0 || GPA > 10)
                {
                    MessageBox.Show("Điểm trung bình không hợp lệ", "Lỗi");
                    return;
                }
                FormMain.students.Add(new Student(textBoxID.Text, textBoxName.Text, comboBoxDepartment.SelectedItem.ToString(), value));
                
                if (FormMain.dgv.Rows.Count > 1)
                {
                    for (int i = 0; i < FormMain.dgv.RowCount; i++)
                    {
                        if (FormMain.dgv.Rows[i].Cells[1].Value == null)
                            break;
                        if (FormMain.dgv.Rows[i].Cells[1].Value.ToString() == textBoxID.Text)
                        {
                            MessageBox.Show("Mã số sinh viên đã tồn tại", "Lỗi");
                            return;
                        }
                    }
                }

                FormMain.dgv.Rows.Clear();
                for (int i = 0; i < FormMain.students.Count; i++)
                {
                    FormMain.dgv.Rows.Add((i + 1).ToString(), FormMain.students[i].ID, FormMain.students[i].Name, FormMain.students[i].Department, FormMain.students[i].GPA);
                }
                Close();
                FormMain.instance.Show();
            }
            else
            {
                MessageBox.Show("Điểm trung bình không hợp lệ", "Lỗi");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();            
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = AreControlsValid(Controls);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = AreControlsValid(Controls);
        }

        private void textBoxGPA_TextChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = AreControlsValid(Controls);
        }

        private void FormAddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.instance.Show();
        }
    }
}
