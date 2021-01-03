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
using commonLibraries;
using log4net;
namespace Film_BD_V4
{
    public partial class frmSettings : Form
    {
        string oneDrivePath;
        string csvPath;
        string csvName;
        string imagePath;
        bool unsaved=false;
        Logging l = new Logging();
        DateTime lastSync = DateTime.MinValue;
        private static readonly log4net.ILog logging = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
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
                    logging.Error("Fehler beim Kopieren der Dateien in Onedrive", ex);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            else
            {
                MessageBox.Show("Der Onedrive Pfad wurde nicht ausgewählt!");
                logging.Warn("Der Onedrive Pfad wurde nicht ausgewählt");
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
            try
            {
                cbxLogging.Checked = Properties.Settings.Default.Logging;
                cbxPerformance.Checked = Properties.Settings.Default.Booster;
                if (Properties.Settings.Default.lastSync != null && Properties.Settings.Default.lastSync != DateTime.MinValue)
                {
                    lblLastSync.Text = "Letzer Sync: " + Properties.Settings.Default.lastSync.ToString();
                }
                else
                {
                    lblLastSync.Text = "Letzer Sync: Nie";
                }
                if (Properties.Settings.Default.oneDrivePath != "")
                {
                    oneDrivePath = Properties.Settings.Default.oneDrivePath;
                }
                else
                {
                    oneDrivePath = Environment.GetEnvironmentVariable("OneDriveConsumer");
                    fbdSelectOnedrive.SelectedPath = oneDrivePath;
                }
                cbxLogLevel.Enabled = cbxLogging.Checked;
                cbxLogLevel.SelectedValue = l.getLoglevel();
                unsaved = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Du machst was falsch! Es ist folgender Fehler aufgetreten:" + Environment.NewLine + ex.Message);
                logging.Error(ex.Message + Environment.NewLine + ex.StackTrace,ex);
            }
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Logging = cbxLogging.Checked;
            Properties.Settings.Default.Booster = cbxPerformance.Checked;
            Properties.Settings.Default.oneDrivePath = oneDrivePath;
            Properties.Settings.Default.Loglevel = cbxLogLevel.SelectedItem.ToString();
            
            l.changeLogLevel(cbxLogLevel.SelectedItem.ToString());
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
            cbxLogLevel.Enabled = cbxLogging.Checked;
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

        private void btnDefaults_Click(object sender, EventArgs e)
        {
            cbxLogging.Checked = true;
            Properties.Settings.Default.Logging = true;
            Properties.Settings.Default.Loglevel = "Warn";
            cbxLogLevel.SelectedItem = "Warn";
            cbxPerformance.Checked = false;
            Properties.Settings.Default.Booster = false;
            Properties.Settings.Default.oneDrivePath = "";
            Properties.Settings.Default.Save();
            unsaved = false;
        }
    }
}
