
namespace Bai5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Add_Update = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvCount = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UVN Anh Hai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(84, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(60, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa chỉ khách hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(8, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số tiền trong tài khoản:";
            // 
            // btn_Add_Update
            // 
            this.btn_Add_Update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Add_Update.Location = new System.Drawing.Point(282, 200);
            this.btn_Add_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add_Update.Name = "btn_Add_Update";
            this.btn_Add_Update.Size = new System.Drawing.Size(133, 33);
            this.btn_Add_Update.TabIndex = 10;
            this.btn_Add_Update.Text = "Thêm/Cập nhật";
            this.btn_Add_Update.UseVisualStyleBackColor = true;
            this.btn_Add_Update.Click += new System.EventHandler(this.btn_Add_Update_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDel.Location = new System.Drawing.Point(431, 200);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(104, 33);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(273, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tổng tiền:";
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(372, 416);
            this.tb5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(284, 23);
            this.tb5.TabIndex = 14;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(195, 57);
            this.tb1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(462, 23);
            this.tb1.TabIndex = 15;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(195, 95);
            this.tb2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(462, 23);
            this.tb2.TabIndex = 16;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(195, 133);
            this.tb3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(462, 23);
            this.tb3.TabIndex = 17;
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(195, 166);
            this.tb4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(462, 23);
            this.tb4.TabIndex = 18;
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKetThuc.Location = new System.Drawing.Point(552, 200);
            this.btnKetThuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(104, 33);
            this.btnKetThuc.TabIndex = 19;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvCount);
            this.panel1.Location = new System.Drawing.Point(105, 250);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 150);
            this.panel1.TabIndex = 20;
            // 
            // dtgvCount
            // 
            this.dtgvCount.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtgvCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCount.Location = new System.Drawing.Point(0, 0);
            this.dtgvCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvCount.Name = "dtgvCount";
            this.dtgvCount.RowHeadersWidth = 51;
            this.dtgvCount.RowTemplate.Height = 29;
            this.dtgvCount.Size = new System.Drawing.Size(551, 148);
            this.dtgvCount.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btn_Add_Update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Add_Update;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvCount;
    }
}

