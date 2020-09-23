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

namespace Film_DB_V2
{
    public partial class frmFilm : Form
    {
        List<Media> media = new List<Media>();
        List<string> entrys = new List<string>();
        string picturepath = "";
        int id = -1;
        int freeId = 0;
        string fileName;
        int currentpos = 0;
        public frmFilm()
        {
            InitializeComponent();
            this.MouseWheel += Form1_Scroll;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }
       /* private void Form1_Load(object sender, EventArgs e)
        {
            
            fileName = Application.StartupPath + "\\filme.csv";
            string targetpath = Application.StartupPath + @"\vorschläge.txt";
            string sourcepath = " http://germanfungaming.de/vorschläge.txt";
            picturepath = Application.StartupPath + @"\images\";
            //this.BackColor = colBack;
            if (File.Exists(fileName))
            {
                try
                {
                    entrys = File.ReadAllLines(fileName).ToList();
                    foreach (string entry in entrys)
                    {
                        string[] parts = entry.Split(';');
                        Media m = new Media(freeId);
                        freeId++;
                        m.setName(parts[1]);
                        m.setLink(parts[2]);
                        m.setWatchDate(Convert.ToDateTime(parts[3]));
                        if (parts[3] != "")
                        {
                            m.setRating(Convert.ToInt32(parts[4]));
                        }
                        else
                        {
                            m.setRating(0);
                        }
                        if (parts[5] == "Film")
                        {
                            m.setType("Film");
                        }
                        else if ((parts[5] == "Serie"))
                        {
                            m.setType("Serie");
                            m.setParts(Convert.ToInt32(parts[6]));
                        }
                        else
                        {
                            m.setType("Anime");
                            m.setParts(Convert.ToInt32(parts[6]));
                        }

                        if (parts[7] != "")
                        {
                            m.setPicture(parts[7]);
                        }
                        if (parts.Count() > 8) //kompatibilität zur alten Liste ohne die Wunschlistenfunktion
                        {
                            if (parts[8] != "")
                            {
                                m.setWishlist(Convert.ToBoolean(parts[8]));
                            }
                        }
                        media.Add(m);
                    }
                    
                }
                catch
                { }
                loadNext();
            }
        }*/
        private void Form1_Load(object sender, EventArgs e)
        {
            string folderName = @"D:\Patrick\Bilder\kamera\Amsterdam August 2012";
            string csvPath = @"D:\Patrick\Dokumente\Programmierung\Projekte\C#\Film_DB\Film_DB\bin\Debug\filme.csv";
            List<string> pictureNames = new List<string>();
            List<string> csvContent = File.ReadAllLines(csvPath).ToList();
            List<string> movieNames = new List<string>();
            
            
            for (int i =0;i<4;i++)
            {
                string line = csvContent[i];
                string[] parts = line.Split(';');
                movieNames.Add(parts[1]);

               pictureNames.Add(folderName + "\\"+parts[7]);
            }
            pbxMovie1.ImageLocation = pictureNames.First();
            pbxMovie1.SizeMode = PictureBoxSizeMode.StretchImage;
            lblMovie1.Text = movieNames.First();
            pbxMovie2.ImageLocation = pictureNames[1];
            pbxMovie2.SizeMode = PictureBoxSizeMode.StretchImage;
            lblMovie2.Text = movieNames[1];
            pbxMovie3.ImageLocation = pictureNames[2];
            pbxMovie3.SizeMode = PictureBoxSizeMode.StretchImage;
            lblMovie3.Text = movieNames[2];
            pbxMovie4.ImageLocation = pictureNames[3];
            pbxMovie4.SizeMode = PictureBoxSizeMode.StretchImage;
            lblMovie4.Text = movieNames[3];
        }
        private void loadNext()
        {
            List<Media> nextEntrys = new List<Media>();
            for (int i = 0; i < 4; i++)
            {
                if(currentpos + i<media.Count)
                {
                  nextEntrys.Add(media[currentpos + i]);
                }
                
            }
            currentpos += 4;
            picturepath = @"D:\Patrick\Bilder\kamera\Amsterdam August 2012\";
            pbxMovie1.ImageLocation =picturepath+ nextEntrys.First().pictureName;
            pbxMovie1.SizeMode = PictureBoxSizeMode.StretchImage;
            lblMovie1.Text = nextEntrys.First().name;
            pbxMovie2.ImageLocation = picturepath + nextEntrys[1].pictureName;
            pbxMovie2.SizeMode = PictureBoxSizeMode.StretchImage;
            lblMovie2.Text = nextEntrys[1].name;
            pbxMovie3.ImageLocation = picturepath + nextEntrys[2].pictureName;
            pbxMovie3.SizeMode = PictureBoxSizeMode.StretchImage;
            lblMovie3.Text = nextEntrys[2].name;
            pbxMovie4.ImageLocation = picturepath + nextEntrys[1].pictureName;
            pbxMovie4.SizeMode = PictureBoxSizeMode.StretchImage;
            lblMovie4.Text = nextEntrys[3].name;
        }
        private void loadPrevious()
        {
            List<Media> previousEntrys = new List<Media>();
            for (int i = 0; i < 4; i++)
            {
                if(currentpos-i-4>0)
                {
                    previousEntrys.Add(media[currentpos - i-4]);
                }
                
            }
            currentpos -= 4;
            picturepath = @"D:\Patrick\Bilder\kamera\Amsterdam August 2012\";
            pbxMovie1.ImageLocation = picturepath + previousEntrys.First().pictureName;
            pbxMovie1.SizeMode = PictureBoxSizeMode.StretchImage;
            lblMovie1.Text = previousEntrys.First().name;
            pbxMovie2.ImageLocation = picturepath + previousEntrys[1].pictureName;
            pbxMovie2.SizeMode = PictureBoxSizeMode.StretchImage;
            lblMovie2.Text = previousEntrys[1].name;
            pbxMovie3.ImageLocation = picturepath + previousEntrys[2].pictureName;
            pbxMovie3.SizeMode = PictureBoxSizeMode.StretchImage;
            lblMovie3.Text = previousEntrys[2].name;
            pbxMovie4.ImageLocation = picturepath + previousEntrys[1].pictureName;
            pbxMovie4.SizeMode = PictureBoxSizeMode.StretchImage;
            lblMovie4.Text = previousEntrys[3].name;
        }
        private void Form1_Scroll(object sender, MouseEventArgs e)
        {
            if(e.Delta<0)
            {
                loadNext();
            }
            else
            {
                loadPrevious();
            }
            
        }

        private void BtnSuggest_Click(object sender, EventArgs e)
        {
            string folderName = @"D:\Patrick\Bilder\kamera\Amsterdam August 2012";
            string csvPath = @"D:\Patrick\Dokumente\Programmierung\Projekte\C#\Film_DB\Film_DB\bin\Debug\filme.csv";
            List<string> pictureNames = new List<string>();
            List<string> csvContent = File.ReadAllLines(csvPath).ToList();
            List<string> movieNames = new List<string>();
            Random rnd = new Random();

            for (int i = 0; i < 4; i++)
            {
                string line = csvContent[rnd.Next(csvContent.Count)];
                string[] parts = line.Split(';');
                movieNames.Add(parts[1]);

                pictureNames.Add(folderName + "\\" + parts[7]);
            }
            pbxMovie1.ImageLocation = pictureNames.First();
            pbxMovie1.SizeMode = PictureBoxSizeMode.StretchImage;
            lblMovie1.Text = movieNames.First();
            pbxMovie2.ImageLocation = pictureNames[1];
            pbxMovie2.SizeMode = PictureBoxSizeMode.StretchImage;
            lblMovie2.Text = movieNames[1];
            pbxMovie3.ImageLocation = pictureNames[2];
            pbxMovie3.SizeMode = PictureBoxSizeMode.StretchImage;
            lblMovie3.Text = movieNames[2];
            pbxMovie4.ImageLocation = pictureNames[3];
            pbxMovie4.SizeMode = PictureBoxSizeMode.StretchImage;
            lblMovie4.Text = movieNames[3];
        }
    }
}
