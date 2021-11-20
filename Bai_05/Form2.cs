using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_05
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
                FormMain.students.Add(new Student(textBoxID.Text, textBoxName.Text, comboBoxDepartment.SelectedItem.ToString(), value));
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
                MessageBox.Show("Diem trung binh khong hop le!", "Loi");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
            FormMain.instance.Show();
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
    }
}
