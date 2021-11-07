using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        static DataTable dt = new DataTable();
        int i = 1;
        int money = 0;

        public Form1()
        {
            InitializeComponent();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("Mã Tài khoản", typeof(string));
            dt.Columns.Add("Tên khách hàng", typeof(string));
            dt.Columns.Add("Địa chỉ", typeof(string));
            dt.Columns.Add("Số tiền", typeof(int));
            dtgvCount.DataSource = dt;
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tb1.Text != "")
            {
                MessageBox.Show("Cảnh báo", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                dtgvCount.Rows.Remove(dtgvCount.CurrentRow);
                int a = int.Parse(tb4.Text);
                money -= a;
                tb5.Text = money.ToString();
                MessageBox.Show("Xoá tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản cần xóa");
                return;
            }

        }

        private void btn_Add_Update_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "" || tb2.Text == "" || tb3.Text == "" || tb4.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                int a = int.Parse(tb4.Text);
                dt.Rows.Add(i++, Convert.ToInt32(tb1.Text), tb2.Text, tb3.Text, Convert.ToInt32(tb4.Text));
                dtgvCount.DataSource = dt;
                money += a;
                tb5.Text = money.ToString();
                MessageBox.Show("Thêm mới dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
