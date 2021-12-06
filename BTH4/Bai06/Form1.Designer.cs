
namespace Bai05
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
            this.GruopBoxInfo = new System.Windows.Forms.GroupBox();
            this.ButtonCopy = new System.Windows.Forms.Button();
            this.ButtonBrowseDestination = new System.Windows.Forms.Button();
            this.ButtonBrowseSource = new System.Windows.Forms.Button();
            this.TextBoxDestination = new System.Windows.Forms.TextBox();
            this.TextBoxSource = new System.Windows.Forms.TextBox();
            this.LabelDestination = new System.Windows.Forms.Label();
            this.LabelSource = new System.Windows.Forms.Label();
            this.GruopBoxProgress = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.StatusStripProgress = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCopying = new System.Windows.Forms.ToolStripStatusLabel();
            this.GruopBoxInfo.SuspendLayout();
            this.GruopBoxProgress.SuspendLayout();
            this.StatusStripProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // GruopBoxInfo
            // 
            this.GruopBoxInfo.Controls.Add(this.ButtonCopy);
            this.GruopBoxInfo.Controls.Add(this.ButtonBrowseDestination);
            this.GruopBoxInfo.Controls.Add(this.ButtonBrowseSource);
            this.GruopBoxInfo.Controls.Add(this.TextBoxDestination);
            this.GruopBoxInfo.Controls.Add(this.TextBoxSource);
            this.GruopBoxInfo.Controls.Add(this.LabelDestination);
            this.GruopBoxInfo.Controls.Add(this.LabelSource);
            this.GruopBoxInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GruopBoxInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.GruopBoxInfo.Location = new System.Drawing.Point(27, 12);
            this.GruopBoxInfo.Name = "GruopBoxInfo";
            this.GruopBoxInfo.Size = new System.Drawing.Size(466, 127);
            this.GruopBoxInfo.TabIndex = 0;
            this.GruopBoxInfo.TabStop = false;
            this.GruopBoxInfo.Text = "Sao chép tập tin";
            // 
            // ButtonCopy
            // 
            this.ButtonCopy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCopy.ForeColor = System.Drawing.Color.Black;
            this.ButtonCopy.Location = new System.Drawing.Point(179, 94);
            this.ButtonCopy.Name = "ButtonCopy";
            this.ButtonCopy.Size = new System.Drawing.Size(116, 27);
            this.ButtonCopy.TabIndex = 6;
            this.ButtonCopy.Text = "Sao chép";
            this.ButtonCopy.UseVisualStyleBackColor = true;
            this.ButtonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
            // 
            // ButtonBrowseDestination
            // 
            this.ButtonBrowseDestination.Location = new System.Drawing.Point(423, 54);
            this.ButtonBrowseDestination.Name = "ButtonBrowseDestination";
            this.ButtonBrowseDestination.Size = new System.Drawing.Size(37, 22);
            this.ButtonBrowseDestination.TabIndex = 5;
            this.ButtonBrowseDestination.Text = "...";
            this.ButtonBrowseDestination.UseVisualStyleBackColor = true;
            this.ButtonBrowseDestination.Click += new System.EventHandler(this.ButtonBrowseDestination_Click);
            // 
            // ButtonBrowseSource
            // 
            this.ButtonBrowseSource.Location = new System.Drawing.Point(423, 17);
            this.ButtonBrowseSource.Name = "ButtonBrowseSource";
            this.ButtonBrowseSource.Size = new System.Drawing.Size(37, 22);
            this.ButtonBrowseSource.TabIndex = 4;
            this.ButtonBrowseSource.Text = "...";
            this.ButtonBrowseSource.UseVisualStyleBackColor = true;
            this.ButtonBrowseSource.Click += new System.EventHandler(this.ButtonBrowseSource_Click);
            // 
            // TextBoxDestination
            // 
            this.TextBoxDestination.Location = new System.Drawing.Point(149, 56);
            this.TextBoxDestination.Name = "TextBoxDestination";
            this.TextBoxDestination.Size = new System.Drawing.Size(268, 20);
            this.TextBoxDestination.TabIndex = 3;
            // 
            // TextBoxSource
            // 
            this.TextBoxSource.Location = new System.Drawing.Point(149, 19);
            this.TextBoxSource.Name = "TextBoxSource";
            this.TextBoxSource.Size = new System.Drawing.Size(268, 20);
            this.TextBoxSource.TabIndex = 2;
            // 
            // LabelDestination
            // 
            this.LabelDestination.AutoSize = true;
            this.LabelDestination.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDestination.ForeColor = System.Drawing.Color.Black;
            this.LabelDestination.Location = new System.Drawing.Point(6, 63);
            this.LabelDestination.Name = "LabelDestination";
            this.LabelDestination.Size = new System.Drawing.Size(130, 14);
            this.LabelDestination.TabIndex = 1;
            this.LabelDestination.Text = "Đường dẫn thư mục đích:";
            // 
            // LabelSource
            // 
            this.LabelSource.AutoSize = true;
            this.LabelSource.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSource.ForeColor = System.Drawing.Color.Black;
            this.LabelSource.Location = new System.Drawing.Point(6, 26);
            this.LabelSource.Name = "LabelSource";
            this.LabelSource.Size = new System.Drawing.Size(140, 14);
            this.LabelSource.TabIndex = 0;
            this.LabelSource.Text = "Đường dẫn thư mục nguồn:";
            // 
            // GruopBoxProgress
            // 
            this.GruopBoxProgress.Controls.Add(this.label3);
            this.GruopBoxProgress.Controls.Add(this.progressBar1);
            this.GruopBoxProgress.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GruopBoxProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.GruopBoxProgress.Location = new System.Drawing.Point(27, 159);
            this.GruopBoxProgress.Name = "GruopBoxProgress";
            this.GruopBoxProgress.Size = new System.Drawing.Size(466, 58);
            this.GruopBoxProgress.TabIndex = 1;
            this.GruopBoxProgress.TabStop = false;
            this.GruopBoxProgress.Text = "Tiến trình sao chép";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(425, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 29);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(451, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // worker
            // 
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // StatusStripProgress
            // 
            this.StatusStripProgress.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCopying});
            this.StatusStripProgress.Location = new System.Drawing.Point(0, 247);
            this.StatusStripProgress.Name = "StatusStripProgress";
            this.StatusStripProgress.Size = new System.Drawing.Size(507, 22);
            this.StatusStripProgress.TabIndex = 2;
            this.StatusStripProgress.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCopying
            // 
            this.toolStripStatusLabelCopying.Name = "toolStripStatusLabelCopying";
            this.toolStripStatusLabelCopying.Size = new System.Drawing.Size(91, 17);
            this.toolStripStatusLabelCopying.Text = "Đang sao chép: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 269);
            this.Controls.Add(this.StatusStripProgress);
            this.Controls.Add(this.GruopBoxProgress);
            this.Controls.Add(this.GruopBoxInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sao chép tập tin";
            this.GruopBoxInfo.ResumeLayout(false);
            this.GruopBoxInfo.PerformLayout();
            this.GruopBoxProgress.ResumeLayout(false);
            this.GruopBoxProgress.PerformLayout();
            this.StatusStripProgress.ResumeLayout(false);
            this.StatusStripProgress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GruopBoxInfo;
        private System.Windows.Forms.Button ButtonCopy;
        private System.Windows.Forms.Button ButtonBrowseDestination;
        private System.Windows.Forms.Button ButtonBrowseSource;
        private System.Windows.Forms.TextBox TextBoxDestination;
        private System.Windows.Forms.TextBox TextBoxSource;
        private System.Windows.Forms.Label LabelDestination;
        private System.Windows.Forms.Label LabelSource;
        private System.Windows.Forms.GroupBox GruopBoxProgress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.StatusStrip StatusStripProgress;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCopying;
    }
}

