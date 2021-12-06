namespace Bai01
{
    partial class FormMove
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
            this.SuspendLayout();
            // 
            // FormMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 536);
            this.Name = "FormMove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Use the arrow keys to move the string";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMove_FormClosed);
            this.Load += new System.EventHandler(this.FormMove_Load);
            this.Shown += new System.EventHandler(this.FormMove_Shown);
            this.SizeChanged += new System.EventHandler(this.FormMove_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMove_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
    }
}