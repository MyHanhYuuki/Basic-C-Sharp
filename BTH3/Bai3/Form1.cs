using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void tbnum1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = 0, num2 = 0;

            if (txtNum1.Text != "")
            {
                num1 = int.Parse(txtNum1.Text);
            }
            else
            {
                MessageBox.Show("Vui long nhap so thu 1", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtNum2.Text != "")
            {
                num2 = int.Parse(txtNum2.Text);
            }
            else
            {
                MessageBox.Show("Vui long nhap so thu 2", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            switch (comboBox1.SelectedItem.ToString())
            {
                case "+":
                    txtResult.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    txtResult.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    txtResult.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    txtResult.Text = (num1 / num2).ToString();
                    break;
            }
        }
    }
}
