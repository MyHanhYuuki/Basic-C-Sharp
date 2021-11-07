using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bai4
{
    public partial class Form1 : Form
    {
        List<Button> DanhSachChon = new List<Button>();
        int money = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnketthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Vé ở vị trí này đã được bán");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Vé ở vị trí này đã được bán");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Vé ở vị trí này đã được bán");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Vé ở vị trí này đã được bán");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Vé ở vị trí này đã được bán");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Vé ở vị trí này đã được bán");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Vé ở vị trí này đã được bán");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Vé ở vị trí này đã được bán");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Vé ở vị trí này đã được bán");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Vé ở vị trí này đã được bán");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Vé ở vị trí này đã được bán");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Vé ở vị trí này đã được bán");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Vé ở vị trí này đã được bán");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Vé ở vị trí này đã được bán");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Vé ở vị trí này đã được bán");
            }
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            foreach (Button b in DanhSachChon)
            {
                int a = int.Parse(b.Text);
                if (a <= 5)
                {
                    b.BackColor = Color.Yellow;
                    money += 5000;
                }
                else if (a > 5 && a <= 10)
                {
                    b.BackColor = Color.Yellow;
                    money += 6500;
                }
                else if (a > 10 && a <= 15)
                {
                    b.BackColor = Color.Yellow;
                    money += 8000;
                }
            }
            textBox1.Text = money.ToString();
            DanhSachChon = new List<Button>();

        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            foreach (Button b in DanhSachChon)
            {
                b.BackColor = Color.White;
            }
            textBox1.Text = "";
            DanhSachChon = new List<Button>();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
