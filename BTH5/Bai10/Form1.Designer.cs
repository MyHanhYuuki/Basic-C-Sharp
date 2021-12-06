
namespace Bai10
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDS = new System.Windows.Forms.ComboBox();
            this.cbW = new System.Windows.Forms.ComboBox();
            this.cbLJ = new System.Windows.Forms.ComboBox();
            this.cbDC = new System.Windows.Forms.ComboBox();
            this.cbSC = new System.Windows.Forms.ComboBox();
            this.cbEC = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dash style:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Line join: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dash cap:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start cap:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "End cap:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbDS
            // 
            this.cbDS.FormattingEnabled = true;
            this.cbDS.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDotDot",
            "DashDot"});
            this.cbDS.Location = new System.Drawing.Point(95, 7);
            this.cbDS.Name = "cbDS";
            this.cbDS.Size = new System.Drawing.Size(121, 21);
            this.cbDS.TabIndex = 6;
            this.cbDS.SelectedIndexChanged += new System.EventHandler(this.cbDS_SelectedIndexChanged);
            // 
            // cbW
            // 
            this.cbW.FormattingEnabled = true;
            this.cbW.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbW.Location = new System.Drawing.Point(95, 48);
            this.cbW.Name = "cbW";
            this.cbW.Size = new System.Drawing.Size(121, 21);
            this.cbW.TabIndex = 7;
            this.cbW.SelectedIndexChanged += new System.EventHandler(this.cbW_SelectedIndexChanged);
            // 
            // cbLJ
            // 
            this.cbLJ.FormattingEnabled = true;
            this.cbLJ.Items.AddRange(new object[] {
            "Miter",
            "Bevel",
            "Round",
            "MiterClipped"});
            this.cbLJ.Location = new System.Drawing.Point(95, 92);
            this.cbLJ.Name = "cbLJ";
            this.cbLJ.Size = new System.Drawing.Size(121, 21);
            this.cbLJ.TabIndex = 8;
            this.cbLJ.SelectedIndexChanged += new System.EventHandler(this.cbLJ_SelectedIndexChanged);
            // 
            // cbDC
            // 
            this.cbDC.FormattingEnabled = true;
            this.cbDC.Items.AddRange(new object[] {
            "Flat",
            "Round",
            "Triangle"});
            this.cbDC.Location = new System.Drawing.Point(95, 139);
            this.cbDC.Name = "cbDC";
            this.cbDC.Size = new System.Drawing.Size(121, 21);
            this.cbDC.TabIndex = 9;
            this.cbDC.SelectedIndexChanged += new System.EventHandler(this.cbDC_SelectedIndexChanged);
            // 
            // cbSC
            // 
            this.cbSC.BackColor = System.Drawing.SystemColors.Window;
            this.cbSC.FormattingEnabled = true;
            this.cbSC.Items.AddRange(new object[] {
            "Flat",
            "Square",
            "Round",
            "Triangle",
            "NoAnchor",
            "SquareAnchor",
            "RoundAnchor",
            "DiamondAnchor",
            "ArrowAnchor",
            "AnchorMask"});
            this.cbSC.Location = new System.Drawing.Point(95, 187);
            this.cbSC.Name = "cbSC";
            this.cbSC.Size = new System.Drawing.Size(121, 21);
            this.cbSC.TabIndex = 10;
            this.cbSC.SelectedIndexChanged += new System.EventHandler(this.cbSC_SelectedIndexChanged);
            // 
            // cbEC
            // 
            this.cbEC.FormattingEnabled = true;
            this.cbEC.Items.AddRange(new object[] {
            "Flat",
            "Square",
            "Round",
            "Triangle",
            "NoAnchor",
            "SquareAnchor",
            "RoundAnchor",
            "DiamondAnchor",
            "ArrowAnchor",
            "AnchorMask"});
            this.cbEC.Location = new System.Drawing.Point(95, 231);
            this.cbEC.Name = "cbEC";
            this.cbEC.Size = new System.Drawing.Size(121, 21);
            this.cbEC.TabIndex = 11;
            this.cbEC.SelectedIndexChanged += new System.EventHandler(this.cbEC_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(222, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 265);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(578, 264);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbEC);
            this.Controls.Add(this.cbSC);
            this.Controls.Add(this.cbDC);
            this.Controls.Add(this.cbLJ);
            this.Controls.Add(this.cbW);
            this.Controls.Add(this.cbDS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pen Demo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDS;
        private System.Windows.Forms.ComboBox cbW;
        private System.Windows.Forms.ComboBox cbLJ;
        private System.Windows.Forms.ComboBox cbDC;
        private System.Windows.Forms.ComboBox cbSC;
        private System.Windows.Forms.ComboBox cbEC;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

