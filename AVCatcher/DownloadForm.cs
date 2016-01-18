using MetroFramework;
using MetroFramework.Forms;
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
    public partial class DownloadForm : MetroForm
    {
        public DownloadForm()
        {
            InitializeComponent();
        }

        private void setTextProgress(string txt)
        {
            this.Invoke((MethodInvoker)delegate {
                lblprogress.Text = txt;
            });
        }

        private void setTextMediaInfo(string txt)
        {
            this.Invoke((MethodInvoker)delegate {
                lblMediaInfo.Text = txt;
            });
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if(txtLink.Text.Length > 0)
            {
                new Thread(DownloadFile).Start();
            }
        }

        private void DownloadFile()
        {
            if (radioAudio.Checked)
            {
                try
                {
                    setTextProgress("Iniciando Download...");
                    IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(txtLink.Text);
                    VideoInfo video = videoInfos
                        .Where(info => info.CanExtractAudio)
                        .OrderByDescending(info => info.AudioBitrate)
                        .First();
                    

                    if (video.RequiresDecryption)
                    {
                        DownloadUrlResolver.DecryptDownloadUrl(video);
                    }
                    setTextMediaInfo(video.Title);
                    setTextProgress("Baixando " + video.Title);
                    string outputTitle = video.Title;
                    foreach (char c in System.IO.Path.GetInvalidFileNameChars())
                    {
                        outputTitle = outputTitle.Replace(c, '_');
                    }
                    var audioDownloader = new AudioDownloader(video, Path.Combine("C:/Downloads", outputTitle + video.AudioExtension));
                    audioDownloader.DownloadProgressChanged += (sender, args) => this.Invoke((MethodInvoker)delegate {
                        progressFile.Value = (int)(args.ProgressPercentage * 0.85);
                        lblprogress.Text = Math.Round(args.ProgressPercentage * 0.85, 2).ToString() + "%";
                    });
                    audioDownloader.AudioExtractionProgressChanged += (sender, args) => this.Invoke((MethodInvoker)delegate {
                        progressFile.Value = (int)(85 + args.ProgressPercentage * 0.15);
                        lblprogress.Text = Math.Round(85 + args.ProgressPercentage * 0.15, 2).ToString() + "%";
                    });
                    audioDownloader.DownloadFinished += (sender, args) => this.Invoke((MethodInvoker)delegate {
                        progressFile.Value = 0;
                        lblprogress.Text = ("Download Finalizado!");
                    });
                    audioDownloader.Execute();
                }
                catch (Exception e)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        MetroMessageBox.Show(this,"Falha ao Baixar o audio " + e.Message);
                    });
                }
            }
            else
            {
                try {
                setTextProgress("Iniciando Download...");
                IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(txtLink.Text);
                VideoInfo video = videoInfos.First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);
                if (video.RequiresDecryption)
                {
                    DownloadUrlResolver.DecryptDownloadUrl(video);
                }
                setTextProgress("Baixando " + video.Title);
                setTextMediaInfo(video.Title);
                string outputTitle = video.Title;
                foreach (char c in System.IO.Path.GetInvalidFileNameChars())
                {
                    outputTitle = outputTitle.Replace(c, '_');
                }
                var videoDownloader = new VideoDownloader(video, Path.Combine("C:/Downloads", outputTitle + video.VideoExtension));
                videoDownloader.DownloadProgressChanged += (sender2, args) => this.Invoke((MethodInvoker)delegate {
                    progressFile.Value = (int)(Math.Round(args.ProgressPercentage, 2));
                    lblprogress.Text = Math.Round(args.ProgressPercentage, 2) + "%";
                });
                videoDownloader.DownloadFinished += (sender2, args) => this.Invoke((MethodInvoker)delegate {
                    progressFile.Value = 0;
                    lblprogress.Text = ("Download Finalizado!");
                });
                videoDownloader.Execute();
            }
            catch (Exception e)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    MetroMessageBox.Show(this,"Falha ao Baixar o vídeo " + e.Message);
                });
            }
        }
        }
    }
}
