using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void StartDLBtn_Click(object sender, EventArgs e)
        {
            DownloadForm downloadForm = new DownloadForm();
            downloadForm.ShowDialog();
        }

        private void PatchStartBtn_Click(object sender, EventArgs e)
        {
            PatchWindows11 patchWindows11 = new PatchWindows11();
            patchWindows11.ShowDialog();
        }
    }
}
