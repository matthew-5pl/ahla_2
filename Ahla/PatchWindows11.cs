using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscUtils;
using System.IO;
using DiscUtils.Iso9660;
using DiscUtils.Udf;

namespace Ahla
{
    public partial class PatchWindows11 : Form
    {
        public PatchWindows11()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            
        }

        private void WimSelectOkButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream isoStr = File.Open(Path.Combine(Environment.CurrentDirectory, "tmp", "windows10.iso"), FileMode.Open))
                {
                    UdfReader reader = new UdfReader(isoStr);
                    Stream wimReadFileStream = reader.OpenFile(@"sources\install.wim", FileMode.Open);
                    CDBuilder builder = new CDBuilder();
                    builder.UseJoliet = true;
                    builder.VolumeIdentifier = "WINDOWS11_PATCHED";
                    Stream currentFile;
                    foreach (string dir in reader.GetDirectories(@"\").ToList())
                    {
                        builder.AddDirectory(dir);
                    }
                    foreach (string fil in reader.GetFiles(@"").ToList())
                    {
                        currentFile = reader.OpenFile(fil, FileMode.Open);
                        builder.AddFile(fil, currentFile);
                    }
                    foreach (string fil in reader.GetFiles(@"boot").ToList())
                    {
                        currentFile = reader.OpenFile(fil, FileMode.Open);
                        builder.AddFile(fil, currentFile);
                    }
                    foreach (string fil in reader.GetFiles(@"efi").ToList())
                    {
                        currentFile = reader.OpenFile(fil, FileMode.Open);
                        builder.AddFile(fil, currentFile);
                    }
                    foreach (string fil in reader.GetFiles(@"sources").ToList())
                    {
                        currentFile = reader.OpenFile(fil, FileMode.Open);
                        builder.AddFile(fil, currentFile);
                    }
                    foreach (string fil in reader.GetFiles(@"support").ToList())
                    {
                        currentFile = reader.OpenFile(fil, FileMode.Open);
                        builder.AddFile(fil, currentFile);
                    }
                    FileStream wimFileStream = new FileStream(InstallWimTextBox.Text, FileMode.Open);
                    builder.AddFile(@"sources\install.wim", wimFileStream);
                    builder.Build(Path.Combine(Environment.CurrentDirectory, "tmp", "windows11_patched.iso"));
                    MessageBox.Show("Done.");
                    Application.Restart();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at " + ex + " Please Report to devs!");
            }
        }

        private void SelectWIMButton_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Install.WIM (*.wim)|*.wim|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    InstallWimTextBox.Text = filePath;
                }
            }
        }
    }
}
