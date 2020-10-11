using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using commonLibraries;
namespace Film_BD_V4
{
    public partial class Form2 : Form
    {
        Media m;
        public Form2(Media s)
        {
            InitializeComponent();
            m = s;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Cursor.Position.X - 85, Cursor.Position.Y - 15);
            lblInfos.Text = "Bewertung: " + m.rating + Environment.NewLine + "hinzugefügt am: " + m.dateAdded.ToShortDateString()+Environment.NewLine+m.genre;
            if(m.parts>0)
            {
                lblInfos.Text += Environment.NewLine + "Anzahl Teile: " + m.parts;
            }
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
        }

        private void Form2_MouseLeave(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
