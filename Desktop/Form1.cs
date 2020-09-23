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
using System.Diagnostics;
using System.Net;
using commonLibraries;
//using PresentationControls;
//todo:
//Datum zuletzt geschaut implementieren -->in Arbeit
//Bessere Infoanzeige 
//Forschrittsangabe (Staffel 1 von x geschaut)

namespace Film_BD_V4
{
    public partial class Form1 : Form
    {
        #region globale Variablen
        #region Listen
        List<Media> currentList = new List<Media>();
        List<string> selectedTypesList = new List<string>();
        #endregion

        #region Boolean
        bool delMode = false;
        bool editMode = false;
        bool infomode = false;
        bool nudPartsOK = false;
        bool isSuggest = false;
        bool wischListState = false;
        bool alreadyclicked = false;
        #endregion

        #region Strings
        string fileName = "";
        string pictureName = "";
        string picturePath;
        string backupFileName = "";
        string pictureSourcePath = "";
        string selectedGenresText = "";
        #endregion

        #region Farben
        Color colBack = Color.FromArgb(54, 57, 63);

        #endregion


        #region integer
        int currentid;
        #endregion
        #region Objekte
        mediaTools mt;
        Form2 f;
        #endregion

        #region DateTime
        DateTime lastWatch = DateTime.MinValue;
        #endregion
        #endregion
        public Form1()
        {
            InitializeComponent();
            
        }
        #region Allgemein
        private void Form1_Load(object sender, EventArgs e)
        {
            fileName = Application.StartupPath + "\\filme.csv";
            backupFileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\filme_backup.csv";
            picturePath = Application.StartupPath + @"\images\";
            if(Environment.UserName.ToLower()=="patrick")
            {
                picturePath = @"D:\Patrick\Bilder\kamera\Amsterdam August 2012\";
            }
            Point location = Properties.Settings.Default.Location;
            Size windowSize = Properties.Settings.Default.Size;

            this.Location = location;
            if(windowSize.Width!=0 && windowSize.Height !=0)
            {
                this.Height = windowSize.Height;
                this.Width = windowSize.Width;
            }


           
            try
            {
                mt = new mediaTools(fileName, picturePath, backupFileName);
                List<string> genres = mt.getGenreList();
                genres.Sort();
                foreach (string genre in genres)
                {
                    if (genre.Length > 0)
                    {
                        /*cbcGenre.Items.Add(genre);
                        cbcGenreAdd.Items.Add(genre);*/
                    }
                }
                currentList = mt.getFilteredList();
                fillGui(currentList);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Beim Einlesen der Datei ist folgender Fehler aufgetreten:" + Environment.NewLine + ex.Message);
            }
            
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Location = this.Location;
            Properties.Settings.Default.Size = this.Size;
            Properties.Settings.Default.Save();
        }
        
        
        #endregion
        #region "Neuer Eintrag"
        private void BtnSave_Click(object sender, EventArgs e)
        {
            List<string> selectedGenres = new List<string>();
            List<string> args = new List<string>();

            if (!tbxLink.Text.ToLower().StartsWith("http://") && !tbxLink.Text.ToLower().StartsWith("https://"))
            {
                tbxLink.Text = "http://" + tbxLink.Text;
            }
            //Media m;
            
            args.AddRange(new string[] { tbxName.Text,tbxLink.Text, dtpWatchdate.Value.ToShortDateString() });
            args.Add(nudRating.Value.ToString());
            if (rbnMovie.Checked)
            {
                args.Add("Film");
                args.Add("0");

            }
            else if (rbnSeries.Checked)
            {

                args.AddRange(new string[] { "Serie", nudParts.Value.ToString() });
            }
            else
            {

                args.AddRange(new string[] { "Anime", nudParts.Value.ToString() });
            }

                args.Add(pictureName);

            if (cbxAddWishList.Checked)
            {
                args.AddRange(new string[] { "True", DateTime.MinValue.ToString() });
            }
            else
            {
                args.Add("False");
            }
            /*if(cbcGenreAdd.Text.Length>0)
            {
                HashSet<string> hSelectecGenres = cbcGenreAdd.Text.Split(',').Select(s => s.Trim()).ToHashSet();
                selectedGenres = hSelectecGenres.ToList();

                if(selectedGenres.Count>1)
                {
                    foreach (string genre in selectedGenres)
                    {
                        selectedGenresText += genre.Trim() + "|";
                    }
                }
                else
                {
                    selectedGenresText = selectedGenres[0];
                }

            }*/
            args.Add(selectedGenresText);
            
            if(lastWatch !=DateTime.MinValue)
            { 
                args.Add(lastWatch.ToShortDateString());
            }
            else
            {
                args.Add(dtpWatchdate.Value.ToShortDateString());
            }

            try
            {
                if (mt.createNewEntry(args.ToArray(),pictureSourcePath,currentid))
                {
                    tmrHide.Start();
                    pbxOK.Visible = true;
                    fillGui(mt.getFilteredList());
                    changeEditMode();
                    alreadyclicked = false;
                }
                else
                {
                    MessageBox.Show("Datei konnte nicht gespeichert werden!","Fehler beim Speichern",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Du machst was falsch! Folgender Fehler ist aufgetreten: " + ex.Message);
            }
        }

        private void BtnImageSelect_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = ofdImageSelect.ShowDialog();
                if (res == DialogResult.OK)
                {
                    pbxPreview.ImageLocation = ofdImageSelect.FileName;
                    pictureName = Path.GetFileName(ofdImageSelect.FileName);
                    pictureSourcePath = ofdImageSelect.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Du machst was falsch! Folgender Fehler ist aufgetreten: " + ex.Message);
            }
        }

        private void TmrHide_Tick(object sender, EventArgs e)
        {
            tmrHide.Stop();
            pbxOK.Visible = false;
            tbxLink.Clear();
            dtpWatchdate.Value = DateTime.Today;
            tbxName.Clear();
            nudParts.Value = 0;
            nudPartsOK = false;
            cbxAddWishList.Checked = false;
            rbnAnime.Checked = false;
            rbnMovie.Checked = false;
            rbnSeries.Checked = false;
            nudParts.Enabled = false;
            btnSave.Enabled = false;
            tbxName.BackColor = Color.Red;
            rbnMovie.BackColor = Color.Red;
            rbnSeries.BackColor = Color.Red;
            rbnAnime.BackColor = Color.Red;
            pbxPreview.Image = null;
            pictureName = "";
        }

        private void NudParts_ValueChanged(object sender, EventArgs e)
        {
            if (nudParts.Value > 0)
            {
                nudParts.BackColor = colBack;
                nudPartsOK = true;
            }
            else
            {
                nudParts.BackColor = Color.Red;
                nudPartsOK = false;
            }
            checkRequirements();
        }
        private void checkRequirements()
        {
            btnSave.Enabled = false;
            if (tbxName.Text.Length > 0)
            {
                if (rbnAnime.Checked || rbnMovie.Checked || rbnSeries.Checked)
                {
                    if ((rbnSeries.Checked || rbnAnime.Checked) && nudPartsOK)
                    {
                        btnSave.Enabled = true;
                    }
                    else if (rbnSeries.Checked == false)
                    {
                        btnSave.Enabled = true;
                    }
                }
            }
        }

        private void TbxName_TextChanged(object sender, EventArgs e)
        {
            checkRequirements();
            if (tbxName.Text.Length > 0)
            {
                tbxName.BackColor = colBack;
            }
            else
            {
                tbxName.BackColor = Color.Red;
            }
        }

        private void RbnSeries_CheckedChanged(object sender, EventArgs e)
        {
            checkRequirements();
            rbnSeries.BackColor = colBack;
            rbnMovie.BackColor = colBack;
            rbnAnime.BackColor = colBack;
            if (rbnSeries.Checked == true)
            {
                nudParts.BackColor = Color.Red;
                nudParts.Enabled = true;
            }
        }

        private void RbnMovie_CheckedChanged(object sender, EventArgs e)
        {
            checkRequirements();
            rbnSeries.BackColor = colBack;
            rbnMovie.BackColor = colBack;
            rbnAnime.BackColor = colBack;
            if (rbnMovie.Checked == true)
            {
                nudParts.Enabled = false;
                nudParts.BackColor = colBack;
            }
            else
            {
                nudParts.BackColor = Color.Red;
                nudParts.Enabled = true;
            }
        }

        private void RbnAnime_CheckedChanged(object sender, EventArgs e)
        {
            checkRequirements();
            rbnSeries.BackColor = colBack;
            rbnMovie.BackColor = colBack;
            rbnAnime.BackColor = colBack;
            if (rbnAnime.Checked == true)
            {
                nudParts.BackColor = Color.Red;
                nudParts.Enabled = true;
            }
        }

        private void CbxAddWishList_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxAddWishList.Checked)
            {
                dtpWatchdate.Enabled = false;
                nudRating.Enabled = false;
            }
            else
            {
                dtpWatchdate.Enabled = true;
                nudRating.Enabled = true;
            }
        }
        private void dtpLastWatchDate_ValueChanged(object sender, EventArgs e)
        {
            lastWatch = dtpLastWatchDate.Value;
        }


        private void dtpWatchdate_ValueChanged(object sender, EventArgs e)
        {
            dtpLastWatchDate.MinDate = dtpWatchdate.Value;
        }
        private void TbpNew_Enter(object sender, EventArgs e)
        {
            tbxName.Focus();
            this.ActiveControl = tbxName;
        }

        private void NudRating_Enter(object sender, EventArgs e)
        {
            nudRating.Select(0, nudRating.Text.Length);
        }

        #endregion

        #region Ansicht vorhandener Elemente
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!delMode)
            {
                DialogResult res = MessageBox.Show("Soll der Löschmodus aktiviert werden?", "Löschmodus aktivieren?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    delMode = true;
                    livMedia.SelectedIndices.Clear();
                    lblDelmode.Visible = true;
                }
            }
            else
            {
                delMode = false;
                lblDelmode.Visible = false;
                MessageBox.Show("Löschmodus deaktivert");
            }
        }
        private void CbxWishList_CheckedChanged(object sender, EventArgs e)
        {
            cbxChanged();
        }
        private void BtnSuggest_Click(object sender, EventArgs e)
        {
            isSuggest = true;
            currentList = mt.getRandomList();
            if (currentList.Count > 0)
            {
                fillGui(currentList);
            }
            else
            {
                MessageBox.Show("Es gibt nix zum Vorschlagen");
            }
        }
        private void fillGui(List<Media> guiList)
        {

            int index = 0;
            livMedia.Clear();
            imlContentPics.Images.Clear();
            currentList = guiList;

            foreach (Media m in guiList)
            {
                if (m.pictureName != null)
                {
                    try
                    {
                        imlContentPics.Images.Add(Image.FromFile(picturePath + m.pictureName));
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = m.name;
                        lvi.ImageIndex = index;
                        lvi.SubItems.Add(m.name);
                        livMedia.Items.Add(lvi);
                        index++;
                    }
                    catch
                    {
                        MessageBox.Show("Das Bild zu Eintrag " + m.name + " konnte nicht gefunden werden! Der Eintrag wurde übersprungen");
                    }
                }
            }
        }

        private void LivMedia_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if(!alreadyclicked)
            //{
                alreadyclicked = true;
                if (livMedia.SelectedItems.Count == 1)
                {
                    Media selected = currentList[livMedia.SelectedItems[0].Index];
                    if (delMode)
                    {

                        deleteItem(selected, false);
                        
                    }
                    else if (editMode)
                    {
                        tbxLink.Text = selected.link;
                        tbxName.Text = selected.name;
                        currentid = selected.id;

                        nudRating.Value = selected.rating;
                        pbxPreview.ImageLocation = picturePath + selected.pictureName;
                        pictureName = selected.pictureName;
                        if (selected.dateAdded > DateTime.MinValue)
                        {
                            dtpWatchdate.Value = selected.dateAdded;
                        }
                        if (selected.parts > 0)
                        {
                            nudParts.Value = selected.parts;
                        }
                        if (selected.wishList)
                        {
                            cbxAddWishList.Checked = true;
                        }
                        if (selected.type == "Film")
                        {
                            rbnMovie.Checked = true;
                        }
                        else if (selected.type == "Serie")
                        {
                            rbnSeries.Checked = true;
                        }
                        else
                        {
                            rbnAnime.Checked = true;
                        }
                        List<string> usedGenres = selected.genre.Split('|').ToList();
                        // ListSelectionWrapper<Media> mediaSelection = new ListSelectionWrapper<Media>(mt.getAllEntrys(),"genre") ;
                        if (usedGenres.Count > 0)
                        {
                            foreach (string genre in usedGenres)
                            {

                                string genreT = genre.Trim();
                                if (genreT.Length > 0)
                                {
                                    //cbcGenreAdd.CheckBoxItems[genreT].Checked = true;
                                }

                            }
                        }
                        tbcMain.SelectedIndex = 1;
                        deleteItem(selected, true);
                    }
                    else if (infomode)
                    {
                        f = new Form2(selected);
                        f.MouseLeave += Form2_MouseLeave;
                        f.Opacity = 0.7;
                        f.ShowDialog();
                        f.BringToFront();
                    }
                    else
                    {
                        string link = selected.link;
                        if (link.Length > 0)
                        {
                            Process.Start(link);
                        }
                        alreadyclicked = false;
                    }
                }
           /* }
            else
            {
                alreadyclicked = false;
            }*/
            
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (tbxSearch.Text.Length>0)
            {

                currentList = mt.findEntrys(tbxSearch.Text);
            }
            else
            {
                currentList = mt.getFilteredList();
            }

            fillGui(currentList);
        }
        private void cbxChanged()
        {

            selectedTypesList.Clear();
            if (cbxWishList.Checked)
            {
                wischListState = true;
            }
            else
            {
                wischListState = false;
            }
            if (cbxFilterAnime.Checked)
            {
                selectedTypesList.Add("Anime");
            }

            if (cbxFilterMovie.Checked)
            {
                selectedTypesList.Add("Film");
            }

            if (cbxFilterSeries.Checked)
            {
                selectedTypesList.Add("Serie");
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            isSuggest = false;
            string[] selectedTypes = new string[3];
            selectedTypes = selectedTypesList.ToArray();
           List<string> selectedGenres = null;
            /* if (cbcGenre.Text.Length>0)
            {
                selectedGenres = cbcGenre.Text.Split(',').ToList();
            }*/
            mt.filterList(selectedTypes, wischListState,selectedGenres);
            fillGui(mt.getFilteredList());
        }
        private void PbxEdit_Click(object sender, EventArgs e)
        {

            changeEditMode();
        }

        private void changeEditMode()
        {
            if (editMode)
            {
                editMode = false;
                pbxEdit.BackColor = colBack;
                currentid = -1;
            }
            else
            {
                editMode = true;
                pbxEdit.BackColor = Color.Orange;
            }
        }

        private void deleteItem(Media delete,bool editmode)
        {
            mt.removeEntry(delete, editMode);
            if(!isSuggest)
            {
                fillGui(mt.getFilteredList());
            }
            else
            {
                fillGui(mt.getRandomList());
            }

        }

        private void LivMedia_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (livMedia.SelectedItems.Count == 1)
            {
               
            }
        }

        private void PbxInfo_Click(object sender, EventArgs e)
        {
            infomode = !infomode;
            if(infomode)
            {
                pbxInfo.BackColor = Color.Red;
            }
            else
            {
                pbxInfo.BackColor = colBack;
            }
            
        }
        private void Form2_MouseLeave(object sender, EventArgs e)
        {
            f.DialogResult = DialogResult.OK;
        }

        private void LivMedia_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            e.Graphics.DrawRectangle(Pens.Red, e.Bounds);
        }

        private void cbxFilterAnime_CheckedChanged(object sender, EventArgs e)
        {
            cbxChanged();
        }
        private void cbxFilterSeries_CheckedChanged(object sender, EventArgs e)
        {
            cbxChanged();
        }

        private void cbxFilterMovie_CheckedChanged(object sender, EventArgs e)
        {
            cbxChanged();
        }
    }
    #endregion
}
