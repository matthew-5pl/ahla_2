using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Ahla
{
    public partial class DownloadForm : Form
    {
        public static WebClient cl = new WebClient();
        WebRequest req;
        string txturl;
        public static ProgressBar prg;
        public DownloadForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            if(!Directory.Exists(Path.Combine(Environment.CurrentDirectory, "tmp")))
            {
                Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, "tmp"));
            }
            prg = DownloadingProgress;
            txturl = "https://raw.githubusercontent.com/matthew-5pl/ahla_2/main/url.txt";
            req = WebRequest.Create(txturl);
            Stream reqStream = req.GetResponse().GetResponseStream();
            StreamReader readReqStream = new StreamReader(reqStream);
            string readedReqStr = readReqStream.ReadToEnd();
            Uri readerUri = new Uri(readedReqStr);
            cl.DownloadFileAsync(readerUri, Path.Combine(Environment.CurrentDirectory, "tmp", "windows10.iso"));
            cl.DownloadProgressChanged += onProg;
            cl.DownloadFileCompleted += onEnd;
        }

        private void DownloadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            cl.CancelAsync();
        }

        public static void onProg(object sender, DownloadProgressChangedEventArgs e)
        {
            prg.Maximum = 100;
            prg.Value = e.ProgressPercentage;
        }

        public static void onEnd(object sender, AsyncCompletedEventArgs e)
        {
            cl.Dispose();
            MessageBox.Show("Download ended with result " + e.Error);
            DownloadForm rm = new DownloadForm();
            rm.Close();
            Application.Restart();
        }
    }
}
