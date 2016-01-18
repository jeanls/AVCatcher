using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;

namespace AVCatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (videoRadio.Checked)
                {
                    new Thread(DownloaderVideo).Start();
                }
                else if (audioRadio.Checked)
                {
                    new Thread(DownloaderAudio).Start();
                }
                
            }
            else
            {
                MessageBox.Show("Texto Vazio");
            }
        }

        private void DownloaderVideo()
        {
            try
            {
                addItemToList("Iniciando Download...");
                string link = textBox1.Text;
                IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(link);
                VideoInfo video = videoInfos.First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);
                if (video.RequiresDecryption)
                {
                    DownloadUrlResolver.DecryptDownloadUrl(video);
                }
                addItemToList("Baixando " + video.Title);
                string outputTitle = video.Title;
                foreach (char c in System.IO.Path.GetInvalidFileNameChars())
                {
                    outputTitle = outputTitle.Replace(c, '_');
                }
                var videoDownloader = new VideoDownloader(video, Path.Combine("C:/Downloads", outputTitle + video.VideoExtension));
                videoDownloader.DownloadProgressChanged += (sender2, args) => this.Invoke((MethodInvoker)delegate {
                    progressBar.Value = (int)(Math.Round(args.ProgressPercentage, 2));
                    rateLabel.Text = Math.Round(args.ProgressPercentage, 2) + "%";
                });
                videoDownloader.DownloadFinished += (sender2, args) => this.Invoke((MethodInvoker)delegate {
                    progressBar.Value = 0;
                    listVideos.Items.Add("Download Finalizado!");
                    rateLabel.Text = "";
                });
                videoDownloader.Execute();
            }
            catch(Exception e)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show("Falha ao Baixar o vídeo " + e.Message);
                });
            }
        }

        private void addItemToList(string text)
        {
            this.Invoke((MethodInvoker)delegate {
                listVideos.Items.Add(text);
            });
        }
        private void DownloaderAudio()
        {
            try
            {
                string link = textBox1.Text;
                addItemToList("Iniciando Download...");
                IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(link);
                VideoInfo video = videoInfos
                    .Where(info => info.CanExtractAudio)
                    .OrderByDescending(info => info.AudioBitrate)
                    .First();

                if (video.RequiresDecryption)
                {
                    DownloadUrlResolver.DecryptDownloadUrl(video);
                }
                addItemToList("Baixando " + video.Title);
                string outputTitle = video.Title;
                foreach (char c in System.IO.Path.GetInvalidFileNameChars())
                {
                    outputTitle = outputTitle.Replace(c, '_');
                }
                var audioDownloader = new AudioDownloader(video, Path.Combine("C:/Downloads", outputTitle + video.AudioExtension));
                audioDownloader.DownloadProgressChanged += (sender, args) => this.Invoke((MethodInvoker)delegate {
                    progressBar.Value = (int)(args.ProgressPercentage * 0.85);
                    rateLabel.Text = Math.Round(args.ProgressPercentage * 0.85, 2).ToString() + "%";
                });
                audioDownloader.AudioExtractionProgressChanged += (sender, args) => this.Invoke((MethodInvoker)delegate {
                    progressBar.Value = (int)(85 + args.ProgressPercentage * 0.15);
                    rateLabel.Text = Math.Round(85 + args.ProgressPercentage * 0.15, 2).ToString() + "%";
                });
                audioDownloader.DownloadFinished += (sender, args) => this.Invoke((MethodInvoker)delegate {
                    progressBar.Value = 0;
                    listVideos.Items.Add("Download Finalizado!");
                    rateLabel.Text = "";
                });
                
                audioDownloader.Execute();
            }
            catch(Exception e)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show("Falha ao Baixar o audio " + e.Message);
                });
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
