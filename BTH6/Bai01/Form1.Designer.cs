
namespace Bai01
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
            this.labelurl = new System.Windows.Forms.Label();
            this.labelsave = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.btnfile = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelurl
            // 
            this.labelurl.AutoSize = true;
            this.labelurl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelurl.Location = new System.Drawing.Point(28, 34);
            this.labelurl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelurl.Name = "labelurl";
            this.labelurl.Size = new System.Drawing.Size(44, 21);
            this.labelurl.TabIndex = 0;
            this.labelurl.Text = "URL:";
            // 
            // labelsave
            // 
            this.labelsave.AutoSize = true;
            this.labelsave.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsave.Location = new System.Drawing.Point(11, 88);
            this.labelsave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelsave.Name = "labelsave";
            this.labelsave.Size = new System.Drawing.Size(79, 21);
            this.labelsave.TabIndex = 1;
            this.labelsave.Text = "SAVE TO:";
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(104, 29);
            this.txtURL.Margin = new System.Windows.Forms.Padding(2);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(411, 26);
            this.txtURL.TabIndex = 2;
            // 
            // txtSave
            // 
            this.txtSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSave.Location = new System.Drawing.Point(104, 84);
            this.txtSave.Margin = new System.Windows.Forms.Padding(2);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(411, 26);
            this.txtSave.TabIndex = 3;
            // 
            // btnfile
            // 
            this.btnfile.Location = new System.Drawing.Point(532, 84);
            this.btnfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnfile.Name = "btnfile";
            this.btnfile.Size = new System.Drawing.Size(45, 24);
            this.btnfile.TabIndex = 4;
            this.btnfile.Text = "...";
            this.btnfile.UseVisualStyleBackColor = true;
            this.btnfile.Click += new System.EventHandler(this.btnfile_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.LightGray;
            this.btnDownload.Location = new System.Drawing.Point(381, 139);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(134, 27);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(607, 189);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnfile);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.labelsave);
            this.Controls.Add(this.labelurl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelurl;
        private System.Windows.Forms.Label labelsave;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.Button btnfile;
        private System.Windows.Forms.Button btnDownload;
    }
}

