namespace Film_BD_V4
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnFilterAll = new System.Windows.Forms.Button();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFilterSeries = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFilterMovie = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFilterAnime = new System.Windows.Forms.Button();
            this.imlContentPics = new System.Windows.Forms.ImageList(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblDelmode = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnShowFavorites = new System.Windows.Forms.Button();
            this.btnNewEntry = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnShowStarted = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowFinished = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dtpLastWatchDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxOK = new System.Windows.Forms.PictureBox();
            this.pbxPreview = new System.Windows.Forms.PictureBox();
            this.dtpWatchdate = new System.Windows.Forms.DateTimePicker();
            this.nudParts = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbnAnime = new System.Windows.Forms.RadioButton();
            this.rbnMovie = new System.Windows.Forms.RadioButton();
            this.rbnSeries = new System.Windows.Forms.RadioButton();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.cbxAddWishList = new System.Windows.Forms.CheckBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxLink = new System.Windows.Forms.TextBox();
            this.btnImageSelect = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.livMedia = new System.Windows.Forms.ListView();
            this.img1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.img2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.img3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.img4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tmrHide = new System.Windows.Forms.Timer(this.components);
            this.ofdImageSelect = new System.Windows.Forms.OpenFileDialog();
            this.ttpInfo = new System.Windows.Forms.ToolTip(this.components);
            this.lbxSort = new System.Windows.Forms.ListBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblSortInfo = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.btnFilterAll);
            this.panel1.Controls.Add(this.pbxSearch);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.tbxSearch);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnFilterSeries);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnFilterMovie);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnFilterAnime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 41);
            this.panel1.TabIndex = 55;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(61)))), ((int)(((byte)(106)))));
            this.panel7.Location = new System.Drawing.Point(0, 37);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(152, 2);
            this.panel7.TabIndex = 63;
            // 
            // btnFilterAll
            // 
            this.btnFilterAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.btnFilterAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFilterAll.FlatAppearance.BorderSize = 0;
            this.btnFilterAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFilterAll.Location = new System.Drawing.Point(0, 0);
            this.btnFilterAll.Name = "btnFilterAll";
            this.btnFilterAll.Size = new System.Drawing.Size(152, 41);
            this.btnFilterAll.TabIndex = 64;
            this.btnFilterAll.Text = "Alles";
            this.btnFilterAll.UseVisualStyleBackColor = false;
            this.btnFilterAll.Click += new System.EventHandler(this.btnFilterAll_Click);
            // 
            // pbxSearch
            // 
            this.pbxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.pbxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbxSearch.Image")));
            this.pbxSearch.Location = new System.Drawing.Point(871, 12);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(22, 19);
            this.pbxSearch.TabIndex = 62;
            this.pbxSearch.TabStop = false;
            this.pbxSearch.Click += new System.EventHandler(this.pbxSearch_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(61)))), ((int)(((byte)(106)))));
            this.panel5.Location = new System.Drawing.Point(870, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 2);
            this.panel5.TabIndex = 59;
            // 
            // tbxSearch
            // 
            this.tbxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.tbxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSearch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxSearch.Location = new System.Drawing.Point(899, 12);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(209, 18);
            this.tbxSearch.TabIndex = 61;
            this.tbxSearch.Text = "Suche";
            this.tbxSearch.Enter += new System.EventHandler(this.tbxSearch_Enter);
            this.tbxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSearch_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(61)))), ((int)(((byte)(106)))));
            this.panel4.Location = new System.Drawing.Point(316, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 2);
            this.panel4.TabIndex = 58;
            // 
            // btnFilterSeries
            // 
            this.btnFilterSeries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.btnFilterSeries.FlatAppearance.BorderSize = 0;
            this.btnFilterSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterSeries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFilterSeries.Location = new System.Drawing.Point(316, 0);
            this.btnFilterSeries.Name = "btnFilterSeries";
            this.btnFilterSeries.Size = new System.Drawing.Size(152, 41);
            this.btnFilterSeries.TabIndex = 59;
            this.btnFilterSeries.Text = "Serie";
            this.btnFilterSeries.UseVisualStyleBackColor = false;
            this.btnFilterSeries.Click += new System.EventHandler(this.bbtnFilterSeries_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(61)))), ((int)(((byte)(106)))));
            this.panel3.Location = new System.Drawing.Point(158, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 2);
            this.panel3.TabIndex = 56;
            // 
            // btnFilterMovie
            // 
            this.btnFilterMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.btnFilterMovie.FlatAppearance.BorderSize = 0;
            this.btnFilterMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFilterMovie.Location = new System.Drawing.Point(158, 0);
            this.btnFilterMovie.Name = "btnFilterMovie";
            this.btnFilterMovie.Size = new System.Drawing.Size(152, 41);
            this.btnFilterMovie.TabIndex = 57;
            this.btnFilterMovie.Text = "Filme";
            this.btnFilterMovie.UseVisualStyleBackColor = false;
            this.btnFilterMovie.Click += new System.EventHandler(this.btnFilterMovie_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(61)))), ((int)(((byte)(106)))));
            this.panel2.Location = new System.Drawing.Point(474, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 2);
            this.panel2.TabIndex = 55;
            // 
            // btnFilterAnime
            // 
            this.btnFilterAnime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.btnFilterAnime.FlatAppearance.BorderSize = 0;
            this.btnFilterAnime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterAnime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterAnime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFilterAnime.Location = new System.Drawing.Point(474, 0);
            this.btnFilterAnime.Name = "btnFilterAnime";
            this.btnFilterAnime.Size = new System.Drawing.Size(152, 41);
            this.btnFilterAnime.TabIndex = 55;
            this.btnFilterAnime.Text = "Anime";
            this.btnFilterAnime.UseVisualStyleBackColor = false;
            this.btnFilterAnime.Click += new System.EventHandler(this.btnFilterAnime_Click);
            // 
            // imlContentPics
            // 
            this.imlContentPics.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imlContentPics.ImageSize = new System.Drawing.Size(256, 256);
            this.imlContentPics.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.panel6.Controls.Add(this.lblDelmode);
            this.panel6.Controls.Add(this.panel11);
            this.panel6.Controls.Add(this.btnShowFavorites);
            this.panel6.Controls.Add(this.btnNewEntry);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.btnEdit);
            this.panel6.Controls.Add(this.btnInfo);
            this.panel6.Controls.Add(this.btnShowStarted);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.btnDelete);
            this.panel6.Controls.Add(this.btnShowFinished);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.btnShowAll);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 41);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1111, 36);
            this.panel6.TabIndex = 57;
            // 
            // lblDelmode
            // 
            this.lblDelmode.AutoSize = true;
            this.lblDelmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelmode.ForeColor = System.Drawing.Color.Red;
            this.lblDelmode.Location = new System.Drawing.Point(807, 9);
            this.lblDelmode.Name = "lblDelmode";
            this.lblDelmode.Size = new System.Drawing.Size(132, 16);
            this.lblDelmode.TabIndex = 71;
            this.lblDelmode.Text = "Löschmodus aktiv";
            this.lblDelmode.Visible = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.panel11.Location = new System.Drawing.Point(226, 26);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(75, 2);
            this.panel11.TabIndex = 70;
            // 
            // btnShowFavorites
            // 
            this.btnShowFavorites.FlatAppearance.BorderSize = 0;
            this.btnShowFavorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFavorites.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShowFavorites.Location = new System.Drawing.Point(226, 3);
            this.btnShowFavorites.Name = "btnShowFavorites";
            this.btnShowFavorites.Size = new System.Drawing.Size(75, 23);
            this.btnShowFavorites.TabIndex = 69;
            this.btnShowFavorites.Text = "Lesezeichen";
            this.btnShowFavorites.UseVisualStyleBackColor = true;
            this.btnShowFavorites.Click += new System.EventHandler(this.btnShowFavorites_Click);
            // 
            // btnNewEntry
            // 
            this.btnNewEntry.FlatAppearance.BorderSize = 0;
            this.btnNewEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnNewEntry.Image = ((System.Drawing.Image)(resources.GetObject("btnNewEntry.Image")));
            this.btnNewEntry.Location = new System.Drawing.Point(955, -1);
            this.btnNewEntry.Name = "btnNewEntry";
            this.btnNewEntry.Size = new System.Drawing.Size(42, 35);
            this.btnNewEntry.TabIndex = 61;
            this.btnNewEntry.UseVisualStyleBackColor = true;
            this.btnNewEntry.Click += new System.EventHandler(this.btnNewEntry_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.panel10.Location = new System.Drawing.Point(52, 26);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(75, 2);
            this.panel10.TabIndex = 68;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(1035, -1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(42, 35);
            this.btnEdit.TabIndex = 59;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(995, -1);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(42, 35);
            this.btnInfo.TabIndex = 60;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnShowStarted
            // 
            this.btnShowStarted.FlatAppearance.BorderSize = 0;
            this.btnShowStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowStarted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShowStarted.Location = new System.Drawing.Point(52, 6);
            this.btnShowStarted.Name = "btnShowStarted";
            this.btnShowStarted.Size = new System.Drawing.Size(75, 23);
            this.btnShowStarted.TabIndex = 67;
            this.btnShowStarted.Text = "Angefangen";
            this.btnShowStarted.UseVisualStyleBackColor = true;
            this.btnShowStarted.Click += new System.EventHandler(this.btnShowStarted_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.panel9.Location = new System.Drawing.Point(133, 26);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(87, 2);
            this.panel9.TabIndex = 66;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(1074, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(34, 35);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnShowFinished
            // 
            this.btnShowFinished.FlatAppearance.BorderSize = 0;
            this.btnShowFinished.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFinished.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShowFinished.Location = new System.Drawing.Point(133, 6);
            this.btnShowFinished.Name = "btnShowFinished";
            this.btnShowFinished.Size = new System.Drawing.Size(87, 23);
            this.btnShowFinished.TabIndex = 65;
            this.btnShowFinished.Text = "Abgeschlossen";
            this.btnShowFinished.UseVisualStyleBackColor = true;
            this.btnShowFinished.Click += new System.EventHandler(this.btnShowFinished_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.panel8.Location = new System.Drawing.Point(2, 26);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(44, 2);
            this.panel8.TabIndex = 64;
            // 
            // btnShowAll
            // 
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShowAll.Location = new System.Drawing.Point(2, 6);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(44, 23);
            this.btnShowAll.TabIndex = 63;
            this.btnShowAll.Text = "Alle";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dtpLastWatchDate
            // 
            this.dtpLastWatchDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLastWatchDate.Location = new System.Drawing.Point(145, 382);
            this.dtpLastWatchDate.Name = "dtpLastWatchDate";
            this.dtpLastWatchDate.Size = new System.Drawing.Size(140, 20);
            this.dtpLastWatchDate.TabIndex = 78;
            this.dtpLastWatchDate.ValueChanged += new System.EventHandler(this.dtpLastWatchDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(35, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 30);
            this.label2.TabIndex = 79;
            this.label2.Text = "zuletzt geschaut am";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(35, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 30);
            this.label1.TabIndex = 77;
            this.label1.Text = "Genre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbxOK
            // 
            this.pbxOK.Image = ((System.Drawing.Image)(resources.GetObject("pbxOK.Image")));
            this.pbxOK.Location = new System.Drawing.Point(105, 146);
            this.pbxOK.Name = "pbxOK";
            this.pbxOK.Size = new System.Drawing.Size(36, 36);
            this.pbxOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxOK.TabIndex = 76;
            this.pbxOK.TabStop = false;
            this.pbxOK.Visible = false;
            // 
            // pbxPreview
            // 
            this.pbxPreview.Location = new System.Drawing.Point(860, 130);
            this.pbxPreview.Name = "pbxPreview";
            this.pbxPreview.Size = new System.Drawing.Size(237, 376);
            this.pbxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPreview.TabIndex = 75;
            this.pbxPreview.TabStop = false;
            // 
            // dtpWatchdate
            // 
            this.dtpWatchdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWatchdate.Location = new System.Drawing.Point(145, 344);
            this.dtpWatchdate.Name = "dtpWatchdate";
            this.dtpWatchdate.Size = new System.Drawing.Size(140, 20);
            this.dtpWatchdate.TabIndex = 65;
            this.dtpWatchdate.ValueChanged += new System.EventHandler(this.dtpWatchdate_ValueChanged);
            // 
            // nudParts
            // 
            this.nudParts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.nudParts.Enabled = false;
            this.nudParts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nudParts.Location = new System.Drawing.Point(463, 347);
            this.nudParts.Name = "nudParts";
            this.nudParts.Size = new System.Drawing.Size(53, 20);
            this.nudParts.TabIndex = 66;
            this.nudParts.ValueChanged += new System.EventHandler(this.nudParts_ValueChanged);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(382, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 30);
            this.label11.TabIndex = 74;
            this.label11.Text = "Staffeln";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(35, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 30);
            this.label8.TabIndex = 73;
            this.label8.Text = "zuerst geschaut am";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(35, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 30);
            this.label7.TabIndex = 72;
            this.label7.Text = "Bewertung";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(14, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 30);
            this.label6.TabIndex = 71;
            this.label6.Text = "Link";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(22, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 30);
            this.label5.TabIndex = 70;
            this.label5.Text = "Name:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbnAnime
            // 
            this.rbnAnime.AutoSize = true;
            this.rbnAnime.BackColor = System.Drawing.Color.Red;
            this.rbnAnime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbnAnime.Location = new System.Drawing.Point(553, 306);
            this.rbnAnime.Name = "rbnAnime";
            this.rbnAnime.Size = new System.Drawing.Size(54, 17);
            this.rbnAnime.TabIndex = 64;
            this.rbnAnime.TabStop = true;
            this.rbnAnime.Text = "Anime";
            this.rbnAnime.UseVisualStyleBackColor = false;
            this.rbnAnime.CheckedChanged += new System.EventHandler(this.rbnAnime_CheckedChanged);
            // 
            // rbnMovie
            // 
            this.rbnMovie.AutoSize = true;
            this.rbnMovie.BackColor = System.Drawing.Color.Red;
            this.rbnMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbnMovie.Location = new System.Drawing.Point(475, 306);
            this.rbnMovie.Name = "rbnMovie";
            this.rbnMovie.Size = new System.Drawing.Size(43, 17);
            this.rbnMovie.TabIndex = 63;
            this.rbnMovie.TabStop = true;
            this.rbnMovie.Text = "Film";
            this.rbnMovie.UseVisualStyleBackColor = false;
            this.rbnMovie.CheckedChanged += new System.EventHandler(this.rbnMovie_CheckedChanged);
            // 
            // rbnSeries
            // 
            this.rbnSeries.AutoSize = true;
            this.rbnSeries.BackColor = System.Drawing.Color.Red;
            this.rbnSeries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbnSeries.Location = new System.Drawing.Point(400, 306);
            this.rbnSeries.Name = "rbnSeries";
            this.rbnSeries.Size = new System.Drawing.Size(49, 17);
            this.rbnSeries.TabIndex = 62;
            this.rbnSeries.TabStop = true;
            this.rbnSeries.Text = "Serie";
            this.rbnSeries.UseVisualStyleBackColor = false;
            this.rbnSeries.CheckedChanged += new System.EventHandler(this.rbnSeries_CheckedChanged);
            // 
            // nudRating
            // 
            this.nudRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.nudRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nudRating.Location = new System.Drawing.Point(145, 306);
            this.nudRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudRating.Name = "nudRating";
            this.nudRating.Size = new System.Drawing.Size(203, 20);
            this.nudRating.TabIndex = 61;
            this.nudRating.ValueChanged += new System.EventHandler(this.nudRating_ValueChanged);
            // 
            // cbxAddWishList
            // 
            this.cbxAddWishList.AutoSize = true;
            this.cbxAddWishList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbxAddWishList.Location = new System.Drawing.Point(400, 376);
            this.cbxAddWishList.Name = "cbxAddWishList";
            this.cbxAddWishList.Size = new System.Drawing.Size(84, 17);
            this.cbxAddWishList.TabIndex = 67;
            this.cbxAddWishList.Text = "Wunschliste";
            this.cbxAddWishList.UseVisualStyleBackColor = true;
            this.cbxAddWishList.CheckedChanged += new System.EventHandler(this.cbxAddWishList_CheckedChanged);
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.Red;
            this.tbxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbxName.Location = new System.Drawing.Point(145, 246);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(482, 20);
            this.tbxName.TabIndex = 59;
            this.tbxName.TextChanged += new System.EventHandler(this.tbxName_TextChanged);
            // 
            // tbxLink
            // 
            this.tbxLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tbxLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbxLink.Location = new System.Drawing.Point(145, 276);
            this.tbxLink.Name = "tbxLink";
            this.tbxLink.Size = new System.Drawing.Size(482, 20);
            this.tbxLink.TabIndex = 60;
            // 
            // btnImageSelect
            // 
            this.btnImageSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnImageSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImageSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnImageSelect.Image")));
            this.btnImageSelect.Location = new System.Drawing.Point(645, 130);
            this.btnImageSelect.Name = "btnImageSelect";
            this.btnImageSelect.Size = new System.Drawing.Size(69, 64);
            this.btnImageSelect.TabIndex = 68;
            this.btnImageSelect.UseVisualStyleBackColor = true;
            this.btnImageSelect.Click += new System.EventHandler(this.btnImageSelect_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(34, 130);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 64);
            this.btnSave.TabIndex = 69;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // livMedia
            // 
            this.livMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.livMedia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.livMedia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.img1,
            this.img2,
            this.img3,
            this.img4});
            this.livMedia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.livMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livMedia.ForeColor = System.Drawing.Color.White;
            this.livMedia.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.livMedia.HideSelection = false;
            this.livMedia.LargeImageList = this.imlContentPics;
            this.livMedia.Location = new System.Drawing.Point(0, 117);
            this.livMedia.MultiSelect = false;
            this.livMedia.Name = "livMedia";
            this.livMedia.Size = new System.Drawing.Size(1111, 520);
            this.livMedia.SmallImageList = this.imlContentPics;
            this.livMedia.TabIndex = 80;
            this.livMedia.UseCompatibleStateImageBehavior = false;
            this.livMedia.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.LivMedia_DrawItem);
            this.livMedia.SelectedIndexChanged += new System.EventHandler(this.livMedia_SelectedIndexChanged);
            // 
            // tmrHide
            // 
            this.tmrHide.Interval = 2000;
            this.tmrHide.Tick += new System.EventHandler(this.tmrHide_Tick);
            // 
            // ofdImageSelect
            // 
            this.ofdImageSelect.FileName = "openFileDialog1";
            // 
            // lbxSort
            // 
            this.lbxSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.lbxSort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbxSort.FormattingEnabled = true;
            this.lbxSort.Items.AddRange(new object[] {
            "Datum Auf",
            "Datum Ab",
            "Bewertung Auf",
            "Bewertung Ab"});
            this.lbxSort.Location = new System.Drawing.Point(228, 101);
            this.lbxSort.Name = "lbxSort";
            this.lbxSort.Size = new System.Drawing.Size(82, 65);
            this.lbxSort.TabIndex = 82;
            this.lbxSort.Visible = false;
            this.lbxSort.SelectedIndexChanged += new System.EventHandler(this.lbxSort_SelectedIndexChanged);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnSort.FlatAppearance.BorderSize = 0;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSort.Location = new System.Drawing.Point(216, 76);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(85, 22);
            this.btnSort.TabIndex = 65;
            this.btnSort.Text = "Sortieren";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblSortInfo
            // 
            this.lblSortInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSortInfo.Location = new System.Drawing.Point(297, 81);
            this.lblSortInfo.Name = "lblSortInfo";
            this.lblSortInfo.Size = new System.Drawing.Size(100, 17);
            this.lblSortInfo.TabIndex = 83;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.panel12.Location = new System.Drawing.Point(226, 96);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(65, 2);
            this.panel12.TabIndex = 71;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1111, 637);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.lblSortInfo);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lbxSort);
            this.Controls.Add(this.livMedia);
            this.Controls.Add(this.dtpLastWatchDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxOK);
            this.Controls.Add(this.pbxPreview);
            this.Controls.Add(this.dtpWatchdate);
            this.Controls.Add(this.nudParts);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbnAnime);
            this.Controls.Add(this.rbnMovie);
            this.Controls.Add(this.rbnSeries);
            this.Controls.Add(this.nudRating);
            this.Controls.Add(this.cbxAddWishList);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxLink);
            this.Controls.Add(this.btnImageSelect);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Film_DB";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnFilterSeries;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFilterMovie;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFilterAnime;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pbxSearch;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnFilterAll;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnShowStarted;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnShowFinished;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnNewEntry;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnShowFavorites;
        private System.Windows.Forms.ImageList imlContentPics;
        private System.Windows.Forms.DateTimePicker dtpLastWatchDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxOK;
        private System.Windows.Forms.PictureBox pbxPreview;
        private System.Windows.Forms.DateTimePicker dtpWatchdate;
        private System.Windows.Forms.NumericUpDown nudParts;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbnAnime;
        private System.Windows.Forms.RadioButton rbnMovie;
        private System.Windows.Forms.RadioButton rbnSeries;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.CheckBox cbxAddWishList;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxLink;
        private System.Windows.Forms.Button btnImageSelect;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView livMedia;
        private System.Windows.Forms.ColumnHeader img1;
        private System.Windows.Forms.ColumnHeader img2;
        private System.Windows.Forms.ColumnHeader img3;
        private System.Windows.Forms.ColumnHeader img4;
        private System.Windows.Forms.Timer tmrHide;
        private System.Windows.Forms.OpenFileDialog ofdImageSelect;
        private System.Windows.Forms.ToolTip ttpInfo;
        private System.Windows.Forms.Label lblDelmode;
        private System.Windows.Forms.ListBox lbxSort;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblSortInfo;
        private System.Windows.Forms.Panel panel12;
    }
}

