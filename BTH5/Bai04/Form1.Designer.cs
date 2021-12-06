
namespace Bai04
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
            this.cbFont = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdRight = new System.Windows.Forms.RadioButton();
            this.rdCenter = new System.Windows.Forms.RadioButton();
            this.rdLeft = new System.Windows.Forms.RadioButton();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxU = new System.Windows.Forms.CheckBox();
            this.checkBoxI = new System.Windows.Forms.CheckBox();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font";
            // 
            // cbFont
            // 
            this.cbFont.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbFont.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFont.FormattingEnabled = true;
            this.cbFont.Location = new System.Drawing.Point(92, 41);
            this.cbFont.Name = "cbFont";
            this.cbFont.Size = new System.Drawing.Size(178, 28);
            this.cbFont.TabIndex = 1;
            this.cbFont.SelectedValueChanged += new System.EventHandler(this.cbFont_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // cbSize
            // 
            this.cbSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.cbSize.Location = new System.Drawing.Point(348, 41);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(78, 28);
            this.cbSize.TabIndex = 3;
            this.cbSize.SelectedValueChanged += new System.EventHandler(this.cbSize_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdRight);
            this.groupBox1.Controls.Add(this.rdCenter);
            this.groupBox1.Controls.Add(this.rdLeft);
            this.groupBox1.Location = new System.Drawing.Point(39, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 95);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Allign Text";
            // 
            // rdRight
            // 
            this.rdRight.AutoSize = true;
            this.rdRight.Location = new System.Drawing.Point(13, 65);
            this.rdRight.Name = "rdRight";
            this.rdRight.Size = new System.Drawing.Size(50, 17);
            this.rdRight.TabIndex = 2;
            this.rdRight.TabStop = true;
            this.rdRight.Text = "Right";
            this.rdRight.UseVisualStyleBackColor = true;
            this.rdRight.Click += new System.EventHandler(this.rdRight_Click);
            // 
            // rdCenter
            // 
            this.rdCenter.AutoSize = true;
            this.rdCenter.Location = new System.Drawing.Point(13, 42);
            this.rdCenter.Name = "rdCenter";
            this.rdCenter.Size = new System.Drawing.Size(56, 17);
            this.rdCenter.TabIndex = 1;
            this.rdCenter.TabStop = true;
            this.rdCenter.Text = "Center";
            this.rdCenter.UseVisualStyleBackColor = true;
            this.rdCenter.Click += new System.EventHandler(this.rdCenter_Click);
            // 
            // rdLeft
            // 
            this.rdLeft.AutoSize = true;
            this.rdLeft.Location = new System.Drawing.Point(13, 19);
            this.rdLeft.Name = "rdLeft";
            this.rdLeft.Size = new System.Drawing.Size(43, 17);
            this.rdLeft.TabIndex = 0;
            this.rdLeft.TabStop = true;
            this.rdLeft.Text = "Left";
            this.rdLeft.UseVisualStyleBackColor = true;
            this.rdLeft.Click += new System.EventHandler(this.rdLeft_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.White;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.Black;
            this.textBox.Location = new System.Drawing.Point(229, 146);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(237, 29);
            this.textBox.TabIndex = 8;
            this.textBox.Text = "Hello";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Color";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 30);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxU
            // 
            this.checkBoxU.Image = global::Bai04.Properties.Resources.u;
            this.checkBoxU.Location = new System.Drawing.Point(208, 98);
            this.checkBoxU.Name = "checkBoxU";
            this.checkBoxU.Size = new System.Drawing.Size(31, 20);
            this.checkBoxU.TabIndex = 6;
            this.checkBoxU.UseVisualStyleBackColor = true;
            this.checkBoxU.Click += new System.EventHandler(this.checkBoxU_Click);
            // 
            // checkBoxI
            // 
            this.checkBoxI.Image = global::Bai04.Properties.Resources.i;
            this.checkBoxI.Location = new System.Drawing.Point(122, 98);
            this.checkBoxI.Name = "checkBoxI";
            this.checkBoxI.Size = new System.Drawing.Size(31, 20);
            this.checkBoxI.TabIndex = 5;
            this.checkBoxI.UseVisualStyleBackColor = true;
            this.checkBoxI.Click += new System.EventHandler(this.checkBoxI_Click);
            // 
            // checkBoxB
            // 
            this.checkBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxB.Image = global::Bai04.Properties.Resources.b;
            this.checkBoxB.Location = new System.Drawing.Point(37, 98);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(31, 20);
            this.checkBoxB.TabIndex = 4;
            this.checkBoxB.UseVisualStyleBackColor = true;
            this.checkBoxB.Click += new System.EventHandler(this.checkBoxB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 287);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxU);
            this.Controls.Add(this.checkBoxI);
            this.Controls.Add(this.checkBoxB);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFont);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.CheckBox checkBoxI;
        private System.Windows.Forms.CheckBox checkBoxU;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdRight;
        private System.Windows.Forms.RadioButton rdCenter;
        private System.Windows.Forms.RadioButton rdLeft;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

