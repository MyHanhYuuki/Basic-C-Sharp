
namespace Bai11
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdEllipse = new System.Windows.Forms.RadioButton();
            this.rdRectangle = new System.Windows.Forms.RadioButton();
            this.rdLine = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdLGB = new System.Windows.Forms.RadioButton();
            this.rdTB = new System.Windows.Forms.RadioButton();
            this.rdHB = new System.Windows.Forms.RadioButton();
            this.rdSB = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(160, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 378);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdEllipse);
            this.groupBox1.Controls.Add(this.rdRectangle);
            this.groupBox1.Controls.Add(this.rdLine);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shape";
            // 
            // rdEllipse
            // 
            this.rdEllipse.AutoSize = true;
            this.rdEllipse.ForeColor = System.Drawing.Color.Black;
            this.rdEllipse.Location = new System.Drawing.Point(6, 62);
            this.rdEllipse.Name = "rdEllipse";
            this.rdEllipse.Size = new System.Drawing.Size(55, 17);
            this.rdEllipse.TabIndex = 2;
            this.rdEllipse.Text = "Ellipse";
            this.rdEllipse.UseVisualStyleBackColor = true;
            // 
            // rdRectangle
            // 
            this.rdRectangle.AutoSize = true;
            this.rdRectangle.ForeColor = System.Drawing.Color.Black;
            this.rdRectangle.Location = new System.Drawing.Point(6, 39);
            this.rdRectangle.Name = "rdRectangle";
            this.rdRectangle.Size = new System.Drawing.Size(74, 17);
            this.rdRectangle.TabIndex = 1;
            this.rdRectangle.Text = "Rectangle";
            this.rdRectangle.UseVisualStyleBackColor = true;
            // 
            // rdLine
            // 
            this.rdLine.AutoSize = true;
            this.rdLine.Checked = true;
            this.rdLine.ForeColor = System.Drawing.Color.Black;
            this.rdLine.Location = new System.Drawing.Point(6, 16);
            this.rdLine.Name = "rdLine";
            this.rdLine.Size = new System.Drawing.Size(45, 17);
            this.rdLine.TabIndex = 0;
            this.rdLine.TabStop = true;
            this.rdLine.Text = "Line";
            this.rdLine.UseVisualStyleBackColor = true;
            this.rdLine.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(8, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 85);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pen";
            // 
            // btnColor
            // 
            this.btnColor.ForeColor = System.Drawing.Color.Black;
            this.btnColor.Location = new System.Drawing.Point(32, 52);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdLGB);
            this.groupBox3.Controls.Add(this.rdTB);
            this.groupBox3.Controls.Add(this.rdHB);
            this.groupBox3.Controls.Add(this.rdSB);
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(8, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 172);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Brushes";
            // 
            // rdLGB
            // 
            this.rdLGB.AutoSize = true;
            this.rdLGB.ForeColor = System.Drawing.Color.Black;
            this.rdLGB.Location = new System.Drawing.Point(7, 142);
            this.rdLGB.Name = "rdLGB";
            this.rdLGB.Size = new System.Drawing.Size(121, 17);
            this.rdLGB.TabIndex = 6;
            this.rdLGB.Text = "LinearGradientBrush";
            this.rdLGB.UseVisualStyleBackColor = true;
            // 
            // rdTB
            // 
            this.rdTB.AutoSize = true;
            this.rdTB.ForeColor = System.Drawing.Color.Black;
            this.rdTB.Location = new System.Drawing.Point(7, 106);
            this.rdTB.Name = "rdTB";
            this.rdTB.Size = new System.Drawing.Size(88, 17);
            this.rdTB.TabIndex = 5;
            this.rdTB.Text = "TextureBrush";
            this.rdTB.UseVisualStyleBackColor = true;
            // 
            // rdHB
            // 
            this.rdHB.AutoSize = true;
            this.rdHB.ForeColor = System.Drawing.Color.Black;
            this.rdHB.Location = new System.Drawing.Point(6, 70);
            this.rdHB.Name = "rdHB";
            this.rdHB.Size = new System.Drawing.Size(81, 17);
            this.rdHB.TabIndex = 4;
            this.rdHB.Text = "HatchBrush";
            this.rdHB.UseVisualStyleBackColor = true;
            // 
            // rdSB
            // 
            this.rdSB.AutoSize = true;
            this.rdSB.Checked = true;
            this.rdSB.ForeColor = System.Drawing.Color.Black;
            this.rdSB.Location = new System.Drawing.Point(6, 35);
            this.rdSB.Name = "rdSB";
            this.rdSB.Size = new System.Drawing.Size(75, 17);
            this.rdSB.TabIndex = 3;
            this.rdSB.TabStop = true;
            this.rdSB.Text = "SolidBrush";
            this.rdSB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(624, 378);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài thi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdEllipse;
        private System.Windows.Forms.RadioButton rdRectangle;
        private System.Windows.Forms.RadioButton rdLine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdLGB;
        private System.Windows.Forms.RadioButton rdTB;
        private System.Windows.Forms.RadioButton rdHB;
        private System.Windows.Forms.RadioButton rdSB;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

