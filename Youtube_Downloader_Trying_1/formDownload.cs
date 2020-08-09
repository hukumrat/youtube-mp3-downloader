using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;


namespace Youtube_Downloader_Trying_1
{
    public partial class formDownload : Form
    {
        public formDownload()
        {
            InitializeComponent();
        }
        public void alert(string msg, formAlert.enmType type)
        {
            formAlert frmalrt = new formAlert();
            frmalrt.showAlert(msg, type);
        }

        public void test()
        {
            var inputFile = new MediaFile { Filename = @"C:\Users\hukumrat\Desktop\Yeni klasör\Evil Techno - Shotgun.mp3" };
            var outputFile = new MediaFile { Filename = @"C:\Users\hukumrat\Desktop\Yeni klasör\output-file.mp3" };
            string ffmpeg = @"C:\Users\hukumrat\Desktop\f\f\bin\ffmpeg.exe";
            string command = $"-i {inputFile} -ab 320k {outputFile}";

            using (var engine = new Engine(ffmpeg))
            {
                engine.GetMetadata(inputFile);
                engine.CustomCommand(string.Format(command));
            }
        }
        public void convert()
        {
            var inputFile = new MediaFile { Filename = lblaudioPath.Text };
            var outputFile = new MediaFile { Filename = lblOutputFilename.Text };

            //var inputFile = new MediaFile { Filename = @"C:\Users\hukumrat\Desktop\Yeni klasör\Evil Techno - Shotgun.mp3" };
            //var outputFile = new MediaFile { Filename = @"C:\Users\hukumrat\Desktop\Yeni klasör\out.mp3" };
            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);
                var options = new ConversionOptions();
                options.AudioSampleRate = AudioSampleRate.Default;
                engine.Convert(inputFile, outputFile, options);

                // engine.CustomCommand("ffmpeg - i C:\Users\hukumrat\Desktop\Yeni klasör\Evil Techno - Shotgun.mp3 -ab 320k outputfile.mp3");
                //engine.ConvertProgressEvent(); PROCESSING... ****************************************************************
            }
        }

        public async void proccess()
        {

            try
            {
                #region DEFINING    
                string url = urlQueue.Dequeue();
                string path = Properties.Settings.Default.pathFolder;
                var client = new YoutubeClient();
                var streamInfo = await client.Videos.Streams.GetManifestAsync(url);
                #endregion

                #region GET VIDEO INFO
                var video = await client.Videos.GetAsync(url);
                string videoTitle = video.Title;
                string videoDuration = video.Duration.ToString();
                #endregion

                #region GET AUDIO INFOS
                var audio = streamInfo.GetAudioOnly().WithHighestBitrate();
                string audioWebaUrl = audio.Url.ToString();
                string audioExt = audio.Container.Name;
                var audioFileName = $"DO-NOT-DELETE-{videoTitle}.{audioExt}";
                double audioSize = audio.Size.TotalBytes; //as bytes
                string audioPath = Path.Combine(path, audioFileName);

                lblaudioPath.Text = audioPath;
                lblOutputFilename.Text = path + "\\" + videoTitle + ".mp3";
                #endregion

                #region ADD ROW
                metroGrid.Rows[q].Cells[0].Value = videoTitle;
                metroGrid.Rows[q].Cells[1].Value = audioSize / 1000000 + " Mb";
                metroGrid.Rows[q].Cells[2].Value = "download starting...";
                metroGrid.Rows[q].Cells[3].Value = videoDuration;
                alert("Connected! Download Starting...", formAlert.enmType.info);
                #endregion

                #region DOWNLOADING
                WebClient webClient = new WebClient();
                webClient.DownloadFileAsync(new Uri(audioWebaUrl), audioPath);
                webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
                webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
                #endregion
            }
            catch (Exception ex)
            {
                q++;
                z++;
                timer.Start();
                MessageBox.Show(ex.Message);
            }
        }

        public void light_theme()
        {
            #region this light theme settings
            panelFooter.BackColor = Color.FromArgb(240, 240, 240);
            panelHeader.BackColor = Color.FromArgb(240, 240, 240);
            circleProgressbar2.BackColor = Color.FromArgb(240, 240, 240);
            circleProgressbar2.ForeColor = Color.Black;
            circleProgressbar2.ProgressBackColor = Color.FromArgb(42, 42, 42);
            bnfbtnAddDownload2.Image = Properties.Resources.link_dark;
            bnfbtnAddDownload2.BackColor = Color.FromArgb(240, 240, 240);
            bnfbtnAddDownload2.color = Color.FromArgb(240, 240, 240);
            bnfbtnAddDownload2.colorActive = Color.FromArgb(224, 224, 224);
            metroGrid.BackgroundColor = Color.FromArgb(250, 250, 250);
            metroGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(222, 222, 222);
            metroGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            metroGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(194, 194, 194);
            metroGrid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            metroGrid.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            metroGrid.DefaultCellStyle.ForeColor = Color.Black;
            metroGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(208, 208, 208);
            metroGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            metroGrid.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            metroGrid.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            metroGrid.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(208, 208, 208);
            metroGrid.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            #endregion
        }
        public void dark_theme()
        {
            #region this dark theme settings
            panelFooter.BackColor = Color.FromArgb(42, 42, 42);
            panelHeader.BackColor = Color.FromArgb(42, 42, 42);
            circleProgressbar2.BackColor = Color.FromArgb(42, 42, 42);
            circleProgressbar2.ForeColor = Color.White;
            circleProgressbar2.ProgressBackColor = Color.Gainsboro;
            bnfbtnAddDownload2.Image = Properties.Resources.link_light;
            bnfbtnAddDownload2.BackColor = Color.FromArgb(42, 42, 42);
            bnfbtnAddDownload2.color = Color.FromArgb(42, 42, 42);
            bnfbtnAddDownload2.colorActive = Color.FromArgb(61, 61, 61);
            metroGrid.BackgroundColor = Color.FromArgb(61, 61, 61);
            metroGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 33, 33);
            metroGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            metroGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(61, 61, 61);
            metroGrid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            metroGrid.DefaultCellStyle.BackColor = Color.White;
            metroGrid.DefaultCellStyle.ForeColor = Color.Black;
            metroGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(42, 42, 42);
            metroGrid.DefaultCellStyle.SelectionForeColor = Color.White;
            metroGrid.RowHeadersDefaultCellStyle.BackColor = Color.White;
            metroGrid.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            metroGrid.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(42, 42, 42);
            metroGrid.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            #endregion
        }
        public void formaddurl_darktheme()
        {
            #region formAddUrl dark theme settings
            Properties.Settings.Default.color1 = Color.FromArgb(42, 42, 42);
            Properties.Settings.Default.color2 = Color.FromArgb(61, 61, 61);
            Properties.Settings.Default.color5 = Color.White;
            Properties.Settings.Default.color6 = Color.Black;
            Properties.Settings.Default.color7 = Color.Gray;
            Properties.Settings.Default.color9 = Color.Gray;
            Properties.Settings.Default.color10 = Color.FromArgb(61, 61, 61);
            Properties.Settings.Default.color11 = Color.White;
            Properties.Settings.Default.color12 = Color.Gray;
            Properties.Settings.Default.Save();
            #endregion

        }
        Queue<string> urlQueue = new Queue<string>();
        int q = 0;
        byte z = 1;

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            #region DOWNLOAD PROGRESS CHANGED
            try
            {
                float bytesReceived = e.BytesReceived;
                float totalBytesToReceive = e.TotalBytesToReceive;
                //Invoke(new MethodInvoker(delegate ()
                //  {
                //      circleProgressbar.Value = (int)e.ProgressPercentage;
                //      circleProgressbar.Update();
                //  }));

                circleProgressbar2.Value = e.ProgressPercentage;
                metroGrid.Rows[q].Cells[2].Value = bytesReceived / 1000000 + " Mb / " + totalBytesToReceive / 1000000 + " Mb";
            }
            catch (Exception)// when (ex.Status == WebExceptionStatus.RequestCanceled)
            {
                throw;
            }

            #endregion
        }

        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            #region DOWNLOAD COMPLETED
            if (e.Cancelled)
            {
                MessageBox.Show("completede geçti");
                metroGrid.Rows[q].Cells[2].Value = "cancelled";
                File.Delete(lblOutputFilename.Text);
                circleProgressbar2.Value = 0;
                q++;
                z++;
                timer.Start();
            }
            else
            {
                metroGrid.Rows[q].Cells[2].Value = "processing...";
                convert();
                metroGrid.Rows[q].Cells[2].Value = "completed!";
                metroGrid.Rows[q].DefaultCellStyle.ForeColor = Color.SeaGreen;
                metroGrid.Rows[q].DefaultCellStyle.SelectionForeColor = Color.SeaGreen;
                File.Delete(lblaudioPath.Text);
                alert("Success! " + metroGrid.Rows[q].Cells[0].Value + " downloaded!", formAlert.enmType.success);
                q++;
                z++;
                timer.Start();
            }
            #endregion
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            #region CHECK & RUN
            if (urlQueue.Count != 0 && z == 1)
            {
                z--;
                proccess();
            }
            #endregion
        }

        private void metroGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            #region OPEN EXPLORER
            try
            {
                if (metroGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    string openPath = metroGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                    System.Diagnostics.Process.Start("explorer.exe", openPath);
                }
            }
            catch (Exception)
            {
                throw;
            }
            #endregion//indirilen dosya da seçilsin
        }

        private void formDownload_Load(object sender, EventArgs e)
        {
            formaddurl_darktheme();
        }

        private void bnfbtnAddDownload2_Click(object sender, EventArgs e)
        {
            // test();
            // MessageBox.Show("hele bekle");
            /* alert("Success", formAlert.enmType.success);
            alert("Info", formAlert.enmType.info);
            alert("Error!", formAlert.enmType.error);           //Popup Notifications
            alert("Warning!", formAlert.enmType.warning);*/
            using (formAddUrl f = new formAddUrl())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        #region GETURL & ENQUEUE & START PROCCESS
                        urlQueue.Enqueue(f.getUrl);
                        string url = f.getUrl;
                        string path = Properties.Settings.Default.pathFolder;
                        metroGrid.Rows.Add(url, "-", "connecting...", "-", path);
                        timer.Start();
                        #endregion
                    }
                    catch (Exception)
                    {
                        z++;
                        q++;
                        timer.Start();
                        throw;
                    }

                }
            }
        }




        /*string statusCheck = "";
int countdown = 0;
private void timerStatusCheck_Tick(object sender, EventArgs e)
{
   countdown++;
   statusCheck = metroGrid.Rows[q].Cells[2].Value.ToString();
   if (countdown == 15 && statusCheck == metroGrid.Rows[q].Cells[2].Value.ToString())
   {
       countdown = 0;
       alert("timeout error trying again...", formAlert.enmType.error);
       //indirilen işlem iptal
       proccess();//url dequeue olduğu için farklı bi yerden almam lazım
   }

}*/
    }
}
