using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;

namespace YoutubeVideoPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src='https://www.youtube.com/embed/{0}' width='600' height='300' frameborder='0' allowfullscreen></iframe>";
            html += "</head></html>";
            this.webBrowser1.DocumentText = string.Format(html, txtVideoLink.Text.Split('=')[1]);

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                var excutingPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                var youtubeDL = Path.Combine(Path.GetDirectoryName(excutingPath), @"Tool\youtube-dl.exe");
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = youtubeDL;
                startInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardError = true;
                //var songName = "chung ta khong thuoc ve nhau";
                //var artists = "Son tung";
                var command = "-x --no-continue " + "\"" + "ytsearch1: " + txtSongName.Text + " " + txtSongArtist.Text + "\"" + "--audio-format mp3 --audio-quality 0 -o " + "/Downloads/" + "\"" + txtSongName.Text + " - " + txtSongArtist.Text + "\"" + "." + "%(ext)s";
                using (var _process = new Process())
                {
                    startInfo.Arguments = command;
                    _process.StartInfo = startInfo;
                    
                    _process.Start();
                    _process.WaitForExit();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
