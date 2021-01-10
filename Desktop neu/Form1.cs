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
using System.Collections;
using System.Configuration;


namespace Film_BD_V4
{
    public partial class Form1 : Form
    {
        private static readonly log4net.ILog logging = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public Form1()
        {
            InitializeComponent();
        }

        #region globale Variablen
        #region Listen
        List<Media> currentList = new List<Media>();
        List<Media> movies = new List<Media>();
        List<Media> series = new List<Media>();
        List<Media> anime = new List<Media>();
        List<string> selectedTypesList = new List<string>();
        List<string> newEntryGenreList = new List<string>();
        #endregion

        #region Boolean
        bool delMode = false;
        bool editMode = false;
        bool infomode = false;
        bool nudPartsOK = false;
        bool isSuggest = false;
        bool performaceBoost = false;
       
        #endregion

        #region Strings
        string fileName = "";
        string pictureName = "";
        string picturePath;
        string currentType;
        string pictureSourcePath = "";
        string selectedGenresText = "";
        #endregion

        #region Farben
        readonly Color colBack = Color.FromArgb(54, 57, 63); //Hintergrundfarbe für den unteren Bereich
        readonly Color colBackMiddle = Color.FromArgb(46, 48, 54); //Hintergrundgfarbe für den mittleren Bereich
        readonly Color colBackTop = Color.FromArgb(37, 39, 44); //Hintergrundfarbe für den oberen Bereich
        readonly Color colHighlightLV1 = Color.FromArgb(53, 91, 162); //Farbe für Film/Serie/Anime
        readonly Color colHighlightLV2 = Color.FromArgb(53, 91, 162); //Farbe für Angefangen/Abgeschlossen/Lesezeichen
        readonly Color colDefault = Color.FromArgb(36, 61, 106); //Farbe für nicht gehighlighte Knöpfe
        #endregion


        #region integer
        int currentid;
        int wishlistFilterState=-1;
        int progressFilterState = -1;
        #endregion
        #region Objekte
        mediaTools mt;
        Form2 f;
        frmSettings frm;
        #endregion

        #region DateTime
        DateTime lastWatch = DateTime.MinValue;
        #endregion
        #endregion


        #region Allgemein
        private void loadConfig()
        {
            performaceBoost = Properties.Settings.Default.Booster;
            Logging l = new Logging();
            if (Properties.Settings.Default.Logging==false)
            {
                l.changeLogLevel("Off");
            }
            else
            {
                l.changeLogLevel(Properties.Settings.Default.Loglevel);
            }
            logging.Info("Config geladen");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if ((ModifierKeys & Keys.Shift) != 0)
            {
                File.Delete(ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath);
            }
            fileName = Application.StartupPath + "\\filme.csv";

            picturePath = Application.StartupPath + @"\images\";
            
            if (Environment.UserName.ToLower() == "patrick")
            { 
                picturePath = @"Q:\Patrick\Bilder\kamera\Amsterdam August 2012\";
            }
            logging.Debug("Picturepath =" + picturePath);
            frm = new frmSettings(picturePath, fileName, "filme.csv");
            changeHighlighting(btnFilterAll, true);
            changeHighlighting(btnShowAll, false);
            try
            {
                mt = new mediaTools(fileName, picturePath, "");
                logging.Debug("mediatools Objekt erstellt");
                currentList = mt.getAllEntrys();
                movies = mt.getMovies();
                series = mt.getSeries();
                anime = mt.getAnimes();
                logging.Debug("Listen für Film,Serie, Anime erstellt");
                List<string> genreList = mt.getGenreList();
                logging.Debug("genreList erstellt, Einträge:"+ genreList.Count);
                foreach(string genre in genreList)
                {
                    
                    lbxGenre.Items.Add(genre);
                    lbxGenreAdd.Items.Add(genre);
                }
                logging.Info("Alle Listen erfolgreich erstellt");
                fillGui(currentList);
            }
            
            catch(FileNotFoundException)
            {
                MessageBox.Show("Die CSV Datei wurde nicht gefunden");
                logging.Error("Die CSV Datei wurde nicht gefunden");
            }
            catch(InvalidCastException ex)
            {
                MessageBox.Show("Die Datei enthält ungültige Werte. Der Fehler trat an folgender Stelle auf: " + ex.Data[0].ToString());
                logging.Error("Die Datei enthält ungültige Werte. Der Fehler trat an folgender Stelle auf: " + ex.Data[0].ToString());
            }
            catch(FormatException ex)
            {
                string exData = "";
                foreach (DictionaryEntry de in ex.Data)
                {
                    exData = de.Value.ToString();
                }
                    MessageBox.Show("Die Datei enthält ungültige Werte. Der Fehler trat an folgender Stelle auf: " + exData);
                    logging.Error("Die Datei enthält ungültige Werte. Der Fehler trat an folgender Stelle auf: " + exData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beim Laden des Programms trat folgender Fehler auf: " + ex.Message + Environment.NewLine + ex.StackTrace);
                logging.Error("Beim Programmstart trat ein Fehler auf", ex);
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Location = this.Location;
            Properties.Settings.Default.Size = this.Size;
            Properties.Settings.Default.Save();
        }
        private void changeHighlighting(Control trigger, bool filter)
        {
            logging.Debug("Highlighting wird geändert");
            try
            {
                string pnlNamePart = "";
                Color colToSet;
                string triggerPanelName = "";
                triggerPanelName = "pnl" + trigger.Name.Substring(3);
                if (filter)
                {
                    pnlNamePart = "pnlFilter";
                    colToSet = colHighlightLV1;
                }
                else
                {
                    pnlNamePart = "pnlShow";
                    colToSet = colHighlightLV2;
                }
                foreach (Control C in this.Controls)
                {
                    if (C.GetType() == typeof(System.Windows.Forms.Panel))
                    {

                        if (C.Name.Contains(pnlNamePart))
                        {
                            C.BackColor = colDefault;
                            
                        }
                    }
                }

                Control fittingPanel = this.Controls.Find(triggerPanelName, true)[0];

                fittingPanel.BackColor = colToSet;
                logging.Debug("Highlithing geändert");
            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("Die Farbe konnte nicht angepasst werden, es konnte kein Steuerelement gefunden werden");
                logging.Error("Die Farbe konnte nicht angepasst werden, es konnte kein Steuerelement gefunden werden");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Beim Setzen der Farbe trat folgender Fehler auf: " + ex.Message);
                logging.Error("Beim Setzen der Farbe trat ein Fehler auf", ex);
            }


        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            logging.Debug("Einstellungen werden aufgerufen");
            frm.ShowDialog();
        }
        #endregion
        #region vorhandes Anzeigen
        private void fillGui(List<Media> guiList,bool presorted=false)
        {
            logging.Debug("Starte Aktualisierung der GUI");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int index = 0;
            livMedia.Clear();
            imlContentPics.Images.Clear();
            if(!presorted)
            {
                guiList = guiList.OrderBy(x => x.id).ToList();
                lblSortInfo.Text = "";
            }
            currentList = guiList;

            if (!performaceBoost)
            {
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
                        catch(Exception ex)
                        {
                            if (!File.Exists(picturePath + m.pictureName))
                            {
                                MessageBox.Show("Das Bild zu Eintrag " + m.name + " (ID: " + m.id + ") konnte nicht gefunden werden! Der Eintrag wurde übersprungen");
                                logging.Warn("Das Bild zu Eintrag " + m.name + " (ID: " + m.id + ") konnte nicht gefunden werden! Der Eintrag wurde übersprungen");
                            }
                            else
                            {
                                MessageBox.Show("Du machst was falsch! Beim aktualiseren der GUI trat folgender Fehler auf:" + Environment.NewLine + ex.Message);
                                logging.Error("Fehler in der Prozedur 'fillGui'", ex);
                            }
                            
                        }
                    }
                }
                sw.Stop();
                logging.Debug("verstrichene Zeit: " + sw.Elapsed);
            }
            else
            {
                List<ListViewItem> items = new List<ListViewItem>();
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
                            items.Add(lvi);
                            index++;
                        }
                        catch(Exception ex)
                        {
                            if (!File.Exists(picturePath + m.pictureName))
                            {
                                MessageBox.Show("Das Bild zu Eintrag " + m.name + " (ID: " + m.id + ") konnte nicht gefunden werden! Der Eintrag wurde übersprungen");
                                logging.Warn("Das Bild zu Eintrag " + m.name + " (ID: " + m.id + ") konnte nicht gefunden werden! Der Eintrag wurde übersprungen");
                            }
                            else
                            {
                                MessageBox.Show("Du machst was falsch! Beim aktualiseren der GUI trat folgender Fehler auf:" + Environment.NewLine + ex.Message);
                                logging.Error("Fehler in der Prozedur 'fillGui'", ex);
                            }
                        }
                    }
                }
                livMedia.BeginUpdate();
                livMedia.Items.AddRange(items.ToArray());
                livMedia.EndUpdate();
                items.Clear();
                items = null;
                guiList.Clear();
                guiList = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                sw.Stop();
                logging.Debug("verstrichene Zeit: " + sw.Elapsed);
            }
           
        }

        private void btnFilterAll_Click(object sender, EventArgs e)
        {
            logging.Debug("btnFilterAll wurde gedrückt");
            changeHighlighting((Control) sender, true);
            changeHighlighting(btnShowAll, false);
            livMedia.Visible = true;
            currentType = "";
            currentList = mt.getAllEntrys();
            fillGui(currentList);
        }
        private void btnFilterMovie_Click(object sender, EventArgs e)
        {
            logging.Debug("btnFilterMovie wurde gedrückt");
            changeHighlighting((Control)sender, true);
            changeHighlighting(btnShowAll, false);
            livMedia.Visible = true;
            currentType = "movie";
            if(!performaceBoost)
            {
                movies.Clear();
                List<Media> loopList = new List<Media>();
                string[] types = new string[3] { "Film","",""};
                mt.filterList(types, true);
                movies.AddRange(mt.getFilteredList());
                mt.filterList(types, false);
                movies.AddRange(mt.getFilteredList());
                loopList.AddRange(movies);
                foreach (Media m in loopList)
                {
                    if (m.type != types[0])
                    {
                        movies.Remove(m);
                    }
                }
            }

            fillGui(movies);
        }
        private List<Media> createSubList(int type)
        {
            List<Media> worklist;
            List<Media> returnList;
            if(currentType=="movie")
            {
                worklist = movies;
            }
            else if(currentType== "series")
            {
                worklist = series;
            }
            else if (currentType=="anime")
            {
                worklist = anime;
            }
            else
            {
                worklist = mt.getAllEntrys();
            }
            if(type==0)
            {
                returnList = worklist.FindAll(x => x.wishList == true);
            }
            else if (type==1)
            {
                returnList = worklist.FindAll(x => x.started == true);
            }
            else
            {
                returnList = worklist.FindAll(x => x.finished == true);
            }

            return returnList;

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            logging.Debug("btnShowAll wurde gedrückt");
            changeHighlighting((Control)sender, false);
            livMedia.Visible = true;
            if (currentType == "movie")
            {
                fillGui(movies);
            }
            else if (currentType == "series")
            {
                fillGui(series);
            }
            else if (currentType == "anime")
            {
                fillGui(anime);
            }
            else
            {
                currentList = mt.getAllEntrys();
                fillGui(currentList);
            }
            wishlistFilterState = -1;
            progressFilterState = -1;
        }

        private void btnShowStarted_Click(object sender, EventArgs e)
        {
            logging.Debug("btnShowStarted wurde gedrückt");
            changeHighlighting((Control)sender, false);
            livMedia.Visible = true;
            livMedia.Clear();
            fillGui(createSubList(1));
            wishlistFilterState = 0;
            progressFilterState = 0;
        }
        private void btnShowFinished_Click(object sender, EventArgs e)
        {
            logging.Debug("btnShowFinished wurde gedrückt");
            changeHighlighting((Control)sender, false);
            livMedia.Visible = true;
            livMedia.Clear();
            fillGui(createSubList(2));
            wishlistFilterState = 0;
            progressFilterState = 1;
        }
        private void btnShowFavorites_Click(object sender, EventArgs e)
        {
            logging.Debug("btnShowFavorites wurde gedrückt");
            changeHighlighting((Control)sender, false);
            livMedia.Visible = true;
            livMedia.Visible = true;
            fillGui(createSubList(0));
            wishlistFilterState = 1;
            progressFilterState = 2;
        }

        private void bbtnFilterSeries_Click(object sender, EventArgs e)
        {
            logging.Debug("btnFilterSeries wurde gedrückt");
            changeHighlighting((Control)sender, true);
            changeHighlighting(btnShowAll, false);
            livMedia.Visible = true;
            currentType = "series";
            if(!performaceBoost)
            {
                series.Clear();
                List<Media> loopList = new List<Media>();
                string[] types = new string[3] { "Serie", "", "" };
                mt.filterList(types, true);
                series.AddRange(mt.getFilteredList());
                mt.filterList(types, false);
                series.AddRange(mt.getFilteredList());
                loopList.AddRange(series);
                foreach (Media m in loopList)
                {
                    if (m.type != types[0])
                    {
                        series.Remove(m);
                    }
                }
                
            }
            fillGui(series);
        }
        private void btnFilterAnime_Click(object sender, EventArgs e)
        {
            logging.Debug("btnFilterAnime wurde gedrückt");
            changeHighlighting((Control)sender, true);
            changeHighlighting(btnShowAll, false);
            livMedia.Visible = true;
            currentType = "anime";
            if(!performaceBoost)
            {
                anime.Clear();
                List<Media> loopList = new List<Media>();
                string[] types = new string[3] { "Anime", "", "" };
                mt.filterList(types, true);
                anime.AddRange(mt.getFilteredList());
                mt.filterList(types, false);
                anime.AddRange(mt.getFilteredList());
                loopList.AddRange(anime);
                foreach (Media m in loopList)
                {
                    if (m.type != types[0])
                    {
                        anime.Remove(m);
                    }
                }
            }

            fillGui(anime);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            logging.Debug("Editiermodus wurde geändert");
            changeEditMode();
        }

        private void changeEditMode()
        {
            if (editMode)
            {
                editMode = false;
                btnEdit.BackColor = colBackMiddle;
                currentid = -1;
            }
            else
            {
                editMode = true;
                btnEdit.BackColor = Color.Orange;
            }
        }
        private void deleteItem(Media delete, bool editmode)
        {
            logging.Info("Der Eintrag " + delete.id + " " + delete.name + " wird gelöscht");
            mt.removeEntry(delete, editMode);
            if(!editmode)
            {
                    fillGui(mt.getFilteredList());
            }
            

        }
        private void Form2_MouseLeave(object sender, EventArgs e)
        {
            f.DialogResult = DialogResult.OK;
        }
        private void livMedia_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                    if (usedGenres.Count > 0)
                    {
                        foreach (string genre in usedGenres)
                        {

                            string genreT = genre.Trim();
                            if (genreT.Length > 0)
                            {

                            }

                        }
                    }
                    livMedia.Visible = false;
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

                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!delMode)
            {
                logging.Info("Löschmodus wurde aktiviert");
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
                logging.Info("Löschmodus wurde deaktiviert");
            }
        }

        private void pbxSearch_Click(object sender, EventArgs e)
        {
            doSearch();
        }
        private void tbxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                doSearch();
            }
        }
        private void LivMedia_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            e.Graphics.DrawRectangle(Pens.Red, e.Bounds);
        }
        private void doSearch()
        {
            if (tbxSearch.Text.Length > 0)
            {

                currentList = mt.findEntrys(tbxSearch.Text);
            }
            else
            {
                currentList = mt.getFilteredList();
            }

            fillGui(currentList);
        }
        private void tbxSearch_Enter(object sender, EventArgs e)
        {
            tbxSearch.Clear();
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            lbxSort.Visible = !lbxSort.Visible;
        }
        private void lbxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            logging.Debug("Sortierfunktion wurde aufgerufen");
            List<Media> sortedList=null;

            if (lbxSort.SelectedIndex == 0)
            {
                sortedList = currentList.OrderBy(x => x.dateAdded).ThenBy(x=>x.name).ToList();
                logging.Debug("sortiere nach Datum aufsteigend");
            }
            else if (lbxSort.SelectedIndex == 1)
            {
                sortedList = currentList.OrderByDescending(x => x.dateAdded).ThenBy(x => x.name).ToList();
                logging.Debug("sortiere nach Datum absteigend");
            }
            if (lbxSort.SelectedIndex == 2)
            {
                sortedList = currentList.OrderBy(x => x.rating).ThenBy(x => x.name).ToList();
                logging.Debug("sortiere nach Bewertung aufsteigend");
            }
            else if (lbxSort.SelectedIndex == 3)
            {
                sortedList = currentList.OrderByDescending(x => x.rating).ThenBy(x => x.name).ToList();
                logging.Debug("sortiere nach Bewertung absteigend");
            }
            else if(lbxSort.SelectedIndex == 4)
            {
                sortedList = currentList.OrderBy(x => x.name).ToList();
                logging.Debug("sortiere nach Name aufsteigend");
            }
            else if (lbxSort.SelectedIndex == 5)
            {
                sortedList = currentList.OrderByDescending(x => x.name).ToList();
                logging.Debug("sortiere nach Name absteigend");
            }

            fillGui(sortedList,true);
            lblSortInfo.Text = lbxSort.Text;
            lbxSort.Visible = false;
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            logging.Debug("GenreFilter wurde benutzt");
            lbxGenre.Visible = false;
            btnSelect.Visible = false;
            string[] types;
            List<string> genreList = new List<string>();
            List<Media> currentList = new List<Media>();
            if (currentType == "movie")
            {
                types = new string[3] { "Film", "", "" };
            }
            else if (currentType == "series")
            {
                types = new string[3] { "", "Serie", "" };
            }
            else if (currentType == "anime")
            {
                types = new string[3] { "", "", "Anime" };
            }
            else
            {
                types = new string[3] { "Film", "Serie", "Anime" };
            }

            foreach (string s in lbxGenre.SelectedItems)
            {
                genreList.Add(s);
            }
            logging.Debug("Suche nach Einträgen, die ein oder mehrere der folgenden Genres enthalten:" + string.Join(",", genreList));
            if(wishlistFilterState==1||wishlistFilterState==-1)
            {
                mt.filterList(types, true, genreList);
                currentList.AddRange(mt.getFilteredList());
            }
            if(wishlistFilterState==0||wishlistFilterState==-1)
            {
                mt.filterList(types, false, genreList);
                currentList.AddRange(mt.getFilteredList());
            }
            switch(progressFilterState)
            {
                case 0:
                    currentList.RemoveAll(x => x.finished == true);
                    break;
                case 1:
                    currentList.RemoveAll(x => x.finished == false);
                    break;
                case 2:
                    currentList.RemoveAll(x => x.finished == true);
                    currentList.RemoveAll(x => x.finished == false);
                    break;
                case -1:
                    break;
            }
            fillGui(currentList, true);
        }
        private void btnShowHide_Click(object sender, EventArgs e)
        {
            pnlSort.Visible = !pnlSort.Visible;
            pnlGenre.Visible = !pnlGenre.Visible;
            btnSort.Visible = !btnSort.Visible;
            btnGenre.Visible = !btnGenre.Visible;
        }
        private void btnGenre_Click(object sender, EventArgs e)
        {
            lbxGenre.Visible = !lbxGenre.Visible;
            btnSelect.Visible = !btnSelect.Visible;
        }
        #endregion

        #region neuer Eintrag
        private void btnSave_Click(object sender, EventArgs e)
        {
            logging.Info("Speichere neuen Eintrag");

            List<string> selectedGenres = new List<string>();
            List<string> args = new List<string>();

            if (!tbxLink.Text.ToLower().StartsWith("http://") && !tbxLink.Text.ToLower().StartsWith("https://"))
            {
                tbxLink.Text = "http://" + tbxLink.Text;
            }

            args.AddRange(new string[] { tbxName.Text, tbxLink.Text, dtpWatchdate.Value.ToShortDateString() });
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
                args.AddRange(new string[] { "True"});
            }
            else
            {
                args.Add("False");
            }
            
            args.Add(string.Join("|", newEntryGenreList));

            if (lastWatch != DateTime.MinValue)
            {
                args.Add(lastWatch.ToShortDateString());
            }
            else
            {
                args.Add(dtpWatchdate.Value.ToShortDateString());
            }
            if(cbxStarted.Checked)
            {
                args.Add("true");//angefangen Flag
                args.Add("false");//abgeschlossen Flag
            }
            else
            {
                if(cbxAddWishList.Checked)
                {
                    args.Add("false"); //angefangen flag
                    args.Add("false"); //abgeschlossen flag
                }
                else
                {
                    args.Add("false");//angefangen flag
                    args.Add("true");//abgeschlossen Flag

                }
            }
            try
            {
                currentid = mt.getlastID()+1;
                logging.Debug("Datem des neuen Eintrags: " + currentid + ";" + string.Join(";", args));
                if (mt.createNewEntry(args.ToArray(), pictureSourcePath, currentid))
                {
                    tmrHide.Start();
                    pbxOK.Visible = true;
                    fillGui(mt.getFilteredList());

                }
                else
                {
                    MessageBox.Show("Datei konnte nicht gespeichert werden!", "Fehler beim Speichern", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Du machst was falsch! Folgender Fehler ist aufgetreten: " + ex.Message);
                logging.Fatal("Fehler beim Speichern der Datei!", ex);
            }
        }
        private void btnImageSelect_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = ofdImageSelect.ShowDialog();
                if (res == DialogResult.OK)
                {
                    pbxPreview.ImageLocation = ofdImageSelect.FileName;
                    pictureName = Path.GetFileName(ofdImageSelect.FileName);
                    pictureSourcePath = ofdImageSelect.FileName;
                    logging.Info("Bild ausgewählt");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Du machst was falsch! Folgender Fehler ist aufgetreten: " + ex.Message);
                logging.Error("Fehler in der Prozedur 'btnImageSelect_Click", ex);
            }
        }

        private void tmrHide_Tick(object sender, EventArgs e)
        {
            logging.Debug("Setze GUI auf Standard zurück");
            tmrHide.Stop();
            pbxOK.Visible = false;
            tbxLink.Clear();
            dtpWatchdate.Value = DateTime.Today;
            tbxName.Clear();
            nudParts.Value = 0;
            nudRating.Value = 0;
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
            lbxGenreAdd.ClearSelected();
            pictureName = "";
            tbxGenreAddDropdown.Clear();
            if (editMode)
            {
                livMedia.Visible = true;
            }
        }

        private void nudParts_ValueChanged(object sender, EventArgs e)
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

        private void tbxName_TextChanged(object sender, EventArgs e)
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

        private void rbnSeries_CheckedChanged(object sender, EventArgs e)
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

        private void rbnMovie_CheckedChanged(object sender, EventArgs e)
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

        private void rbnAnime_CheckedChanged(object sender, EventArgs e)
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

        private void cbxAddWishList_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAddWishList.Checked)
            { 
                dtpWatchdate.Enabled = false;
                nudRating.Enabled = false;
                cbxStarted.Checked = false;
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

        private void nudRating_ValueChanged(object sender, EventArgs e)
        {
            nudRating.Select(0, nudRating.Text.Length);
        }

        private void btnNewEntry_Click(object sender, EventArgs e)
        {
            livMedia.Visible = false;
            
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            infomode = !infomode;
            if (infomode)
            {
                btnInfo.BackColor = Color.Red;
            }
            else
            {
                btnInfo.BackColor = colBackMiddle;
            }
        }
        private void cbxStarted_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxStarted.Checked)
            {
                cbxAddWishList.Checked = false;
            }
        }
        private void pbxGenreDropDown_Click(object sender, EventArgs e)
        {
            if (lbxGenreAdd.Visible)
            {
                foreach (string s in lbxGenreAdd.SelectedItems)
                {
                    newEntryGenreList.Add(s);
                    tbxGenreAddDropdown.Text += s + "; ";
                }
                tbxGenreAddDropdown.Text = tbxGenreAddDropdown.Text.Substring(0, tbxGenreAddDropdown.Text.Length - 1);
            }
            lbxGenreAdd.Visible = !lbxGenreAdd.Visible;
        }
        private void btnNewGenre_Click(object sender, EventArgs e)
        {
            tbxNewGenre.Visible = true;
            pbxSaveNewGenre.Visible = true;
        }

        private void pbxSaveNewGenre_Click(object sender, EventArgs e)
        {
            string newGenre = tbxNewGenre.Text.Trim();
            lbxGenreAdd.Items.Add(newGenre);
            lbxGenre.Items.Add(newGenre);
            tbxNewGenre.Visible = false;
            pbxSaveNewGenre.Visible = false;
            logging.Debug("neues Genre hinzugefügt: " + newGenre);
        }


        #endregion
       
    }

}
