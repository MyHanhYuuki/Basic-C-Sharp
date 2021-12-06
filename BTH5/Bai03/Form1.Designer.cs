
namespace Bai03
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
            this.btn_zIn = new System.Windows.Forms.Button();
            this.btn_zOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_zIn
            // 
            this.btn_zIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zIn.Location = new System.Drawing.Point(0, 0);
            this.btn_zIn.Name = "btn_zIn";
            this.btn_zIn.Size = new System.Drawing.Size(50, 50);
            this.btn_zIn.TabIndex = 0;
            this.btn_zIn.Text = "+";
            this.btn_zIn.UseVisualStyleBackColor = true;
            this.btn_zIn.Click += new System.EventHandler(this.btn_zIn_Click);
            // 
            // btn_zOut
            // 
            this.btn_zOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zOut.Location = new System.Drawing.Point(56, 0);
            this.btn_zOut.Name = "btn_zOut";
            this.btn_zOut.Size = new System.Drawing.Size(50, 50);
            this.btn_zOut.TabIndex = 1;
            this.btn_zOut.Text = "-";
            this.btn_zOut.UseVisualStyleBackColor = true;
            this.btn_zOut.Click += new System.EventHandler(this.btn_zOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btn_zOut);
            this.Controls.Add(this.btn_zIn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoom In and Zoom Out";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_zIn;
        private System.Windows.Forms.Button btn_zOut;
    }
}

