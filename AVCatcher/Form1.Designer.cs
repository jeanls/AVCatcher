namespace AVCatcher
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
            this.baixarBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoRadio = new System.Windows.Forms.RadioButton();
            this.audioRadio = new System.Windows.Forms.RadioButton();
            this.listVideos = new System.Windows.Forms.ListBox();
            this.rateLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // baixarBtn
            // 
            this.baixarBtn.Location = new System.Drawing.Point(415, 53);
            this.baixarBtn.Name = "baixarBtn";
            this.baixarBtn.Size = new System.Drawing.Size(75, 23);
            this.baixarBtn.TabIndex = 0;
            this.baixarBtn.Text = "Baixar";
            this.baixarBtn.UseVisualStyleBackColor = true;
            this.baixarBtn.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(178, 298);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(312, 15);
            this.progressBar.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // videoRadio
            // 
            this.videoRadio.AutoSize = true;
            this.videoRadio.Checked = true;
            this.videoRadio.Location = new System.Drawing.Point(178, 56);
            this.videoRadio.Name = "videoRadio";
            this.videoRadio.Size = new System.Drawing.Size(54, 17);
            this.videoRadio.TabIndex = 5;
            this.videoRadio.TabStop = true;
            this.videoRadio.Text = "Vídeo";
            this.videoRadio.UseVisualStyleBackColor = true;
            // 
            // audioRadio
            // 
            this.audioRadio.AutoSize = true;
            this.audioRadio.Location = new System.Drawing.Point(178, 79);
            this.audioRadio.Name = "audioRadio";
            this.audioRadio.Size = new System.Drawing.Size(52, 17);
            this.audioRadio.TabIndex = 6;
            this.audioRadio.Text = "Audio";
            this.audioRadio.UseVisualStyleBackColor = true;
            // 
            // listVideos
            // 
            this.listVideos.FormattingEnabled = true;
            this.listVideos.Location = new System.Drawing.Point(0, 27);
            this.listVideos.Name = "listVideos";
            this.listVideos.Size = new System.Drawing.Size(172, 290);
            this.listVideos.TabIndex = 7;
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Location = new System.Drawing.Point(239, 53);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(0, 13);
            this.rateLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(502, 325);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.listVideos);
            this.Controls.Add(this.audioRadio);
            this.Controls.Add(this.videoRadio);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.baixarBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button baixarBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.RadioButton videoRadio;
        private System.Windows.Forms.RadioButton audioRadio;
        private System.Windows.Forms.ListBox listVideos;
        private System.Windows.Forms.Label rateLabel;
    }
}

