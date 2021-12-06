
namespace Bai02
{
    partial class Form_Clock
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox_Clock = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox_Clock
            // 
            this.textBox_Clock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Clock.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Clock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Clock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Clock.Location = new System.Drawing.Point(0, 76);
            this.textBox_Clock.Name = "textBox_Clock";
            this.textBox_Clock.ReadOnly = true;
            this.textBox_Clock.Size = new System.Drawing.Size(499, 20);
            this.textBox_Clock.TabIndex = 0;
            this.textBox_Clock.TabStop = false;
            this.textBox_Clock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 183);
            this.Controls.Add(this.textBox_Clock);
            this.MaximizeBox = false;
            this.Name = "Form_Clock";
            this.Text = "Clock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Clock_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox_Clock;
    }
}

