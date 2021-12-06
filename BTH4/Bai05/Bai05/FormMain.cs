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
    public partial class FormMain : Form
    {
        public static List<Student> students = new List<Student>();
        public static FormMain instance;
        public static DataGridView dgv;
        public FormMain()
        {
            InitializeComponent();
            instance = this;
            dgv = dataGridView;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormAddStudent fas = new FormAddStudent();
            fas.Show();            
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            addToolStripMenuItem_Click(sender, e);
        }

        private void toolStripTextBoxName_TextChanged(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name.Contains(toolStripTextBoxFind.Text))
                    dataGridView.Rows.Add((i + 1).ToString(), students[i].ID, students[i].Name, students[i].Department, students[i].GPA);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
