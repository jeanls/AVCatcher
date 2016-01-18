namespace AVCatcher
{
    partial class DownloadForm
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
            this.progressFile = new MetroFramework.Controls.MetroProgressBar();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.radioVideo = new MetroFramework.Controls.MetroRadioButton();
            this.radioAudio = new MetroFramework.Controls.MetroRadioButton();
            this.btnDownload = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.txtLink = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.lblMediaInfo = new MetroFramework.Controls.MetroLabel();
            this.lblprogress = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressFile
            // 
            this.progressFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressFile.Location = new System.Drawing.Point(20, 333);
            this.progressFile.Name = "progressFile";
            this.progressFile.Size = new System.Drawing.Size(521, 10);
            this.progressFile.Style = MetroFramework.MetroColorStyle.Red;
            this.progressFile.TabIndex = 1;
            this.progressFile.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.radioVideo);
            this.metroPanel1.Controls.Add(this.radioAudio);
            this.metroPanel1.Controls.Add(this.btnDownload);
            this.metroPanel1.Controls.Add(this.txtLink);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(521, 273);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // radioVideo
            // 
            this.radioVideo.AutoSize = true;
            this.radioVideo.Location = new System.Drawing.Point(6, 61);
            this.radioVideo.Name = "radioVideo";
            this.radioVideo.Size = new System.Drawing.Size(53, 15);
            this.radioVideo.Style = MetroFramework.MetroColorStyle.Red;
            this.radioVideo.TabIndex = 8;
            this.radioVideo.Text = "Video";
            this.radioVideo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.radioVideo.UseSelectable = true;
            // 
            // radioAudio
            // 
            this.radioAudio.AutoSize = true;
            this.radioAudio.Checked = true;
            this.radioAudio.Location = new System.Drawing.Point(6, 40);
            this.radioAudio.Name = "radioAudio";
            this.radioAudio.Size = new System.Drawing.Size(55, 15);
            this.radioAudio.Style = MetroFramework.MetroColorStyle.Red;
            this.radioAudio.TabIndex = 7;
            this.radioAudio.TabStop = true;
            this.radioAudio.Text = "Audio";
            this.radioAudio.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.radioAudio.UseSelectable = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Image = null;
            this.btnDownload.Location = new System.Drawing.Point(243, 40);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.Style = MetroFramework.MetroColorStyle.Red;
            this.btnDownload.TabIndex = 6;
            this.btnDownload.Text = "Download";
            this.btnDownload.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDownload.UseSelectable = true;
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtLink
            // 
            // 
            // 
            // 
            this.txtLink.CustomButton.Image = null;
            this.txtLink.CustomButton.Location = new System.Drawing.Point(290, 1);
            this.txtLink.CustomButton.Name = "";
            this.txtLink.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLink.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLink.CustomButton.TabIndex = 1;
            this.txtLink.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLink.CustomButton.UseSelectable = true;
            this.txtLink.CustomButton.Visible = false;
            this.txtLink.Lines = new string[0];
            this.txtLink.Location = new System.Drawing.Point(6, 3);
            this.txtLink.MaxLength = 32767;
            this.txtLink.Name = "txtLink";
            this.txtLink.PasswordChar = '\0';
            this.txtLink.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLink.SelectedText = "";
            this.txtLink.SelectionLength = 0;
            this.txtLink.SelectionStart = 0;
            this.txtLink.Size = new System.Drawing.Size(312, 23);
            this.txtLink.Style = MetroFramework.MetroColorStyle.Red;
            this.txtLink.TabIndex = 5;
            this.txtLink.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtLink.UseSelectable = true;
            this.txtLink.WaterMark = "Youtube link";
            this.txtLink.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLink.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.lblprogress);
            this.metroPanel2.Controls.Add(this.lblMediaInfo);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(321, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(200, 273);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroPanel2.TabIndex = 9;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // lblMediaInfo
            // 
            this.lblMediaInfo.AutoSize = true;
            this.lblMediaInfo.Location = new System.Drawing.Point(3, 7);
            this.lblMediaInfo.Name = "lblMediaInfo";
            this.lblMediaInfo.Size = new System.Drawing.Size(12, 19);
            this.lblMediaInfo.Style = MetroFramework.MetroColorStyle.Red;
            this.lblMediaInfo.TabIndex = 2;
            this.lblMediaInfo.Text = ".";
            this.lblMediaInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblprogress
            // 
            this.lblprogress.AutoSize = true;
            this.lblprogress.Location = new System.Drawing.Point(3, 36);
            this.lblprogress.Name = "lblprogress";
            this.lblprogress.Size = new System.Drawing.Size(12, 19);
            this.lblprogress.Style = MetroFramework.MetroColorStyle.Red;
            this.lblprogress.TabIndex = 3;
            this.lblprogress.Text = ".";
            this.lblprogress.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // DownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 363);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.progressFile);
            this.Name = "DownloadForm";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "AVCatcher";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroProgressBar progressFile;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroRadioButton radioVideo;
        private MetroFramework.Controls.MetroRadioButton radioAudio;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnDownload;
        private MetroFramework.Controls.MetroTextBox txtLink;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel lblprogress;
        private MetroFramework.Controls.MetroLabel lblMediaInfo;
    }
}