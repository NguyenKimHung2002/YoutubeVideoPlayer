namespace YoutubeVideoPlayer
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
            this.lblVideoLink = new System.Windows.Forms.Label();
            this.txtVideoLink = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.txtSongArtist = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblVideoLink
            // 
            this.lblVideoLink.AutoSize = true;
            this.lblVideoLink.Location = new System.Drawing.Point(18, 47);
            this.lblVideoLink.Name = "lblVideoLink";
            this.lblVideoLink.Size = new System.Drawing.Size(56, 13);
            this.lblVideoLink.TabIndex = 0;
            this.lblVideoLink.Text = "Video link:";
            // 
            // txtVideoLink
            // 
            this.txtVideoLink.Location = new System.Drawing.Point(80, 45);
            this.txtVideoLink.Name = "txtVideoLink";
            this.txtVideoLink.Size = new System.Drawing.Size(532, 20);
            this.txtVideoLink.TabIndex = 1;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(626, 43);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(55, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(21, 112);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(660, 302);
            this.webBrowser1.TabIndex = 3;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(410, 81);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(21, 83);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(277, 20);
            this.txtSongName.TabIndex = 5;
            // 
            // txtSongArtist
            // 
            this.txtSongArtist.Location = new System.Drawing.Point(304, 83);
            this.txtSongArtist.Name = "txtSongArtist";
            this.txtSongArtist.Size = new System.Drawing.Size(100, 20);
            this.txtSongArtist.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.txtSongArtist);
            this.Controls.Add(this.txtSongName);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtVideoLink);
            this.Controls.Add(this.lblVideoLink);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVideoLink;
        private System.Windows.Forms.TextBox txtVideoLink;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.TextBox txtSongArtist;
    }
}

