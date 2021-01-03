using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Film_BD_V4
{
    public partial class frmSettings : Form
    {
        string oneDrivePath;
        string csvPath;
        string csvName;
        string imagePath;
        bool unsaved=false;
        DateTime lastSync = DateTime.MinValue;
        public frmSettings(string picturePath, string csvPath, string fileName)
        {
            InitializeComponent();
            this.imagePath = picturePath;
            this.csvName = fileName;
            this.csvPath = csvPath;
        }

        private void btnCopyOneDrive_Click(object sender, EventArgs e)
        {

            if(oneDrivePath!=null&&oneDrivePath !="")
            {
                try
                {
                    if(!Directory.Exists(oneDrivePath+"\\images"))
                    {
                        Directory.CreateDirectory(oneDrivePath + "\\images");
                    }
                    Cursor.Current = Cursors.WaitCursor;
                    File.Copy(csvPath, oneDrivePath + "\\" + csvName,true);
                    foreach (string image in Directory.GetFiles(imagePath))
                    {
                        FileInfo fi = new FileInfo(image);
                        File.Copy(image, oneDrivePath + "\\images\\" + fi.Name,true);
     
                    }
                    lastSync = DateTime.Now;
                    lblLastSync.Text = "letzter Sync: " + lastSync.ToString();
                    Properties.Settings.Default.lastSync = lastSync;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Du machst was falsch! Folgender Fehler ist aufgetreten:" + Environment.NewLine + ex.Message);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            else
            {
                MessageBox.Show("Der Onedrive Pfad wurde nicht ausgewählt!");
            }
            
        }

        private void pbxSelectOneDrive_Click(object sender, EventArgs e)
        {
            
            DialogResult res = fbdSelectOnedrive.ShowDialog();
            if (res== DialogResult.OK)
            {
                oneDrivePath = fbdSelectOnedrive.SelectedPath;
                unsaved = true;
            }

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            cbxLogging.Checked = Properties.Settings.Default.Logging;
            cbxPerformance.Checked = Properties.Settings.Default.Booster;
            if(Properties.Settings.Default.lastSync!=null&& Properties.Settings.Default.lastSync !=DateTime.MinValue)
            {
                lblLastSync.Text = "Letzer Sync: " + Properties.Settings.Default.lastSync.ToString();
            }
            else
            {
                lblLastSync.Text = "Letzer Sync: Nie";
            }
            if(Properties.Settings.Default.oneDrivePath!="")
            {
                oneDrivePath = Properties.Settings.Default.oneDrivePath;
            }
            else
            {
                oneDrivePath = Environment.GetEnvironmentVariable("OneDriveConsumer");
                fbdSelectOnedrive.SelectedPath = oneDrivePath;
            }
            unsaved = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Logging = cbxLogging.Checked;
            Properties.Settings.Default.Booster = cbxPerformance.Checked;
            Properties.Settings.Default.oneDrivePath = oneDrivePath;
            Properties.Settings.Default.Save();
            unsaved = false;
            this.Hide();
        }

        private void cbxPerformance_CheckedChanged(object sender, EventArgs e)
        {
            unsaved = true;
        }

        private void cbxLogging_CheckedChanged(object sender, EventArgs e)
        {
            unsaved = true;
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(unsaved)
            {
                DialogResult res = MessageBox.Show("Es gibt ungespeicherte Änderungen. Fortfahren?", "ungespeicherte Änderungen", MessageBoxButtons.YesNo);
                if(res == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void pbxSelectOneDrive_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
