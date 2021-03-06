﻿namespace Film_BD_V4
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
            this.imlContentPics = new System.Windows.Forms.ImageList(this.components);
            this.dtpLastWatchDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tmrHide = new System.Windows.Forms.Timer(this.components);
            this.ofdImageSelect = new System.Windows.Forms.OpenFileDialog();
            this.ttpInfo = new System.Windows.Forms.ToolTip(this.components);
            this.pnlFilterAll = new System.Windows.Forms.Panel();
            this.pnlFilterMovie = new System.Windows.Forms.Panel();
            this.pnlFilterSeries = new System.Windows.Forms.Panel();
            this.pnlFilterAnime = new System.Windows.Forms.Panel();
            this.btnFilterAll = new System.Windows.Forms.Button();
            this.btnFilterSeries = new System.Windows.Forms.Button();
            this.btnFilterMovie = new System.Windows.Forms.Button();
            this.btnFilterAnime = new System.Windows.Forms.Button();
            this.pnlShowFavorites = new System.Windows.Forms.Panel();
            this.btnShowFavorites = new System.Windows.Forms.Button();
            this.pnlShowStarted = new System.Windows.Forms.Panel();
            this.btnShowStarted = new System.Windows.Forms.Button();
            this.pnlShowFinished = new System.Windows.Forms.Panel();
            this.btnShowFinished = new System.Windows.Forms.Button();
            this.pnlShowAll = new System.Windows.Forms.Panel();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblDelmode = new System.Windows.Forms.Label();
            this.pnlSort = new System.Windows.Forms.Panel();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnGenre = new System.Windows.Forms.Button();
            this.pnlGenre = new System.Windows.Forms.Panel();
            this.cbxStarted = new System.Windows.Forms.CheckBox();
            this.lblSortInfo = new System.Windows.Forms.Label();
            this.tbxGenreAddDropdown = new System.Windows.Forms.TextBox();
            this.lbxGenreAdd = new System.Windows.Forms.ListBox();
            this.livMedia = new System.Windows.Forms.ListView();
            this.img1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.img2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.img3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.img4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbxNewGenre = new System.Windows.Forms.TextBox();
            this.lbxGenre = new System.Windows.Forms.ListBox();
            this.lbxSort = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pbxSaveNewGenre = new System.Windows.Forms.PictureBox();
            this.btnNewGenre = new System.Windows.Forms.Button();
            this.pbxGenreDropDown = new System.Windows.Forms.PictureBox();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.btnNewEntry = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pbxBackLV2 = new System.Windows.Forms.PictureBox();
            this.pbxBackLV1 = new System.Windows.Forms.PictureBox();
            this.pbxOK = new System.Windows.Forms.PictureBox();
            this.pbxPreview = new System.Windows.Forms.PictureBox();
            this.btnImageSelect = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSaveNewGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGenreDropDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackLV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackLV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // imlContentPics
            // 
            this.imlContentPics.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imlContentPics.ImageSize = new System.Drawing.Size(256, 256);
            this.imlContentPics.TransparentColor = System.Drawing.Color.Transparent;
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
            this.cbxAddWishList.Size = new System.Drawing.Size(86, 17);
            this.cbxAddWishList.TabIndex = 67;
            this.cbxAddWishList.Text = "Lesezeichen";
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
            // tmrHide
            // 
            this.tmrHide.Interval = 2000;
            this.tmrHide.Tick += new System.EventHandler(this.tmrHide_Tick);
            // 
            // ofdImageSelect
            // 
            this.ofdImageSelect.FileName = "openFileDialog1";
            // 
            // pnlFilterAll
            // 
            this.pnlFilterAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(61)))), ((int)(((byte)(106)))));
            this.pnlFilterAll.Location = new System.Drawing.Point(1, 43);
            this.pnlFilterAll.Name = "pnlFilterAll";
            this.pnlFilterAll.Size = new System.Drawing.Size(152, 2);
            this.pnlFilterAll.TabIndex = 111;
            // 
            // pnlFilterMovie
            // 
            this.pnlFilterMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(61)))), ((int)(((byte)(106)))));
            this.pnlFilterMovie.Location = new System.Drawing.Point(159, 43);
            this.pnlFilterMovie.Name = "pnlFilterMovie";
            this.pnlFilterMovie.Size = new System.Drawing.Size(152, 2);
            this.pnlFilterMovie.TabIndex = 110;
            // 
            // pnlFilterSeries
            // 
            this.pnlFilterSeries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(61)))), ((int)(((byte)(106)))));
            this.pnlFilterSeries.Location = new System.Drawing.Point(317, 43);
            this.pnlFilterSeries.Name = "pnlFilterSeries";
            this.pnlFilterSeries.Size = new System.Drawing.Size(152, 2);
            this.pnlFilterSeries.TabIndex = 109;
            // 
            // pnlFilterAnime
            // 
            this.pnlFilterAnime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(61)))), ((int)(((byte)(106)))));
            this.pnlFilterAnime.Location = new System.Drawing.Point(475, 43);
            this.pnlFilterAnime.Name = "pnlFilterAnime";
            this.pnlFilterAnime.Size = new System.Drawing.Size(152, 2);
            this.pnlFilterAnime.TabIndex = 108;
            // 
            // btnFilterAll
            // 
            this.btnFilterAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.btnFilterAll.FlatAppearance.BorderSize = 0;
            this.btnFilterAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFilterAll.Location = new System.Drawing.Point(1, 1);
            this.btnFilterAll.Name = "btnFilterAll";
            this.btnFilterAll.Size = new System.Drawing.Size(152, 41);
            this.btnFilterAll.TabIndex = 107;
            this.btnFilterAll.Text = "Alles";
            this.btnFilterAll.UseVisualStyleBackColor = false;
            this.btnFilterAll.Click += new System.EventHandler(this.btnFilterAll_Click);
            // 
            // btnFilterSeries
            // 
            this.btnFilterSeries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.btnFilterSeries.FlatAppearance.BorderSize = 0;
            this.btnFilterSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterSeries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFilterSeries.Location = new System.Drawing.Point(317, 1);
            this.btnFilterSeries.Name = "btnFilterSeries";
            this.btnFilterSeries.Size = new System.Drawing.Size(152, 41);
            this.btnFilterSeries.TabIndex = 106;
            this.btnFilterSeries.Text = "Serie";
            this.btnFilterSeries.UseVisualStyleBackColor = false;
            this.btnFilterSeries.Click += new System.EventHandler(this.bbtnFilterSeries_Click);
            // 
            // btnFilterMovie
            // 
            this.btnFilterMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.btnFilterMovie.FlatAppearance.BorderSize = 0;
            this.btnFilterMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFilterMovie.Location = new System.Drawing.Point(159, 1);
            this.btnFilterMovie.Name = "btnFilterMovie";
            this.btnFilterMovie.Size = new System.Drawing.Size(152, 41);
            this.btnFilterMovie.TabIndex = 105;
            this.btnFilterMovie.Text = "Filme";
            this.btnFilterMovie.UseVisualStyleBackColor = false;
            this.btnFilterMovie.Click += new System.EventHandler(this.btnFilterMovie_Click);
            // 
            // btnFilterAnime
            // 
            this.btnFilterAnime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.btnFilterAnime.FlatAppearance.BorderSize = 0;
            this.btnFilterAnime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterAnime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterAnime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFilterAnime.Location = new System.Drawing.Point(475, 1);
            this.btnFilterAnime.Name = "btnFilterAnime";
            this.btnFilterAnime.Size = new System.Drawing.Size(152, 41);
            this.btnFilterAnime.TabIndex = 104;
            this.btnFilterAnime.Text = "Anime";
            this.btnFilterAnime.UseVisualStyleBackColor = false;
            this.btnFilterAnime.Click += new System.EventHandler(this.btnFilterAnime_Click);
            // 
            // pnlShowFavorites
            // 
            this.pnlShowFavorites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.pnlShowFavorites.Location = new System.Drawing.Point(229, 80);
            this.pnlShowFavorites.Name = "pnlShowFavorites";
            this.pnlShowFavorites.Size = new System.Drawing.Size(75, 2);
            this.pnlShowFavorites.TabIndex = 126;
            // 
            // btnShowFavorites
            // 
            this.btnShowFavorites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnShowFavorites.FlatAppearance.BorderSize = 0;
            this.btnShowFavorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFavorites.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShowFavorites.Location = new System.Drawing.Point(229, 55);
            this.btnShowFavorites.Name = "btnShowFavorites";
            this.btnShowFavorites.Size = new System.Drawing.Size(75, 23);
            this.btnShowFavorites.TabIndex = 125;
            this.btnShowFavorites.Text = "Lesezeichen";
            this.btnShowFavorites.UseVisualStyleBackColor = false;
            this.btnShowFavorites.Click += new System.EventHandler(this.btnShowFavorites_Click);
            // 
            // pnlShowStarted
            // 
            this.pnlShowStarted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.pnlShowStarted.Location = new System.Drawing.Point(55, 80);
            this.pnlShowStarted.Name = "pnlShowStarted";
            this.pnlShowStarted.Size = new System.Drawing.Size(75, 2);
            this.pnlShowStarted.TabIndex = 124;
            // 
            // btnShowStarted
            // 
            this.btnShowStarted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnShowStarted.FlatAppearance.BorderSize = 0;
            this.btnShowStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowStarted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShowStarted.Location = new System.Drawing.Point(55, 55);
            this.btnShowStarted.Name = "btnShowStarted";
            this.btnShowStarted.Size = new System.Drawing.Size(75, 23);
            this.btnShowStarted.TabIndex = 123;
            this.btnShowStarted.Text = "Angefangen";
            this.btnShowStarted.UseVisualStyleBackColor = false;
            this.btnShowStarted.Click += new System.EventHandler(this.btnShowStarted_Click);
            // 
            // pnlShowFinished
            // 
            this.pnlShowFinished.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.pnlShowFinished.Location = new System.Drawing.Point(136, 80);
            this.pnlShowFinished.Name = "pnlShowFinished";
            this.pnlShowFinished.Size = new System.Drawing.Size(87, 2);
            this.pnlShowFinished.TabIndex = 122;
            // 
            // btnShowFinished
            // 
            this.btnShowFinished.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnShowFinished.FlatAppearance.BorderSize = 0;
            this.btnShowFinished.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFinished.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShowFinished.Location = new System.Drawing.Point(136, 55);
            this.btnShowFinished.Name = "btnShowFinished";
            this.btnShowFinished.Size = new System.Drawing.Size(87, 23);
            this.btnShowFinished.TabIndex = 121;
            this.btnShowFinished.Text = "Abgeschlossen";
            this.btnShowFinished.UseVisualStyleBackColor = false;
            this.btnShowFinished.Click += new System.EventHandler(this.btnShowFinished_Click);
            // 
            // pnlShowAll
            // 
            this.pnlShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.pnlShowAll.Location = new System.Drawing.Point(5, 80);
            this.pnlShowAll.Name = "pnlShowAll";
            this.pnlShowAll.Size = new System.Drawing.Size(44, 2);
            this.pnlShowAll.TabIndex = 120;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShowAll.Location = new System.Drawing.Point(5, 55);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(44, 23);
            this.btnShowAll.TabIndex = 119;
            this.btnShowAll.Text = "Alle";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(61)))), ((int)(((byte)(106)))));
            this.panel5.Location = new System.Drawing.Point(865, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 2);
            this.panel5.TabIndex = 136;
            // 
            // tbxSearch
            // 
            this.tbxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.tbxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSearch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxSearch.Location = new System.Drawing.Point(899, 23);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(209, 18);
            this.tbxSearch.TabIndex = 134;
            this.tbxSearch.Text = "Suche";
            this.tbxSearch.Click += new System.EventHandler(this.tbxSearch_Enter);
            // 
            // lblDelmode
            // 
            this.lblDelmode.AutoSize = true;
            this.lblDelmode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.lblDelmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelmode.ForeColor = System.Drawing.Color.Red;
            this.lblDelmode.Location = new System.Drawing.Point(776, 58);
            this.lblDelmode.Name = "lblDelmode";
            this.lblDelmode.Size = new System.Drawing.Size(132, 16);
            this.lblDelmode.TabIndex = 137;
            this.lblDelmode.Text = "Löschmodus aktiv";
            this.lblDelmode.Visible = false;
            // 
            // pnlSort
            // 
            this.pnlSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.pnlSort.Location = new System.Drawing.Point(41, 108);
            this.pnlSort.Name = "pnlSort";
            this.pnlSort.Size = new System.Drawing.Size(65, 2);
            this.pnlSort.TabIndex = 140;
            this.pnlSort.Visible = false;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnSort.FlatAppearance.BorderSize = 0;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSort.Location = new System.Drawing.Point(31, 89);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(85, 22);
            this.btnSort.TabIndex = 139;
            this.btnSort.Text = "Sortieren";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Visible = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnGenre
            // 
            this.btnGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnGenre.FlatAppearance.BorderSize = 0;
            this.btnGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGenre.Location = new System.Drawing.Point(199, 89);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.Size = new System.Drawing.Size(60, 22);
            this.btnGenre.TabIndex = 141;
            this.btnGenre.Text = "Genre";
            this.btnGenre.UseVisualStyleBackColor = false;
            this.btnGenre.Visible = false;
            this.btnGenre.Click += new System.EventHandler(this.btnGenre_Click);
            // 
            // pnlGenre
            // 
            this.pnlGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.pnlGenre.Location = new System.Drawing.Point(199, 108);
            this.pnlGenre.Name = "pnlGenre";
            this.pnlGenre.Size = new System.Drawing.Size(55, 2);
            this.pnlGenre.TabIndex = 142;
            this.pnlGenre.Visible = false;
            // 
            // cbxStarted
            // 
            this.cbxStarted.AutoSize = true;
            this.cbxStarted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbxStarted.Location = new System.Drawing.Point(399, 399);
            this.cbxStarted.Name = "cbxStarted";
            this.cbxStarted.Size = new System.Drawing.Size(84, 17);
            this.cbxStarted.TabIndex = 143;
            this.cbxStarted.Text = "Angefangen";
            this.cbxStarted.UseVisualStyleBackColor = true;
            this.cbxStarted.CheckedChanged += new System.EventHandler(this.cbxStarted_CheckedChanged);
            // 
            // lblSortInfo
            // 
            this.lblSortInfo.AutoSize = true;
            this.lblSortInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSortInfo.Location = new System.Drawing.Point(87, 96);
            this.lblSortInfo.Name = "lblSortInfo";
            this.lblSortInfo.Size = new System.Drawing.Size(0, 13);
            this.lblSortInfo.TabIndex = 147;
            // 
            // tbxGenreAddDropdown
            // 
            this.tbxGenreAddDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tbxGenreAddDropdown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxGenreAddDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbxGenreAddDropdown.Location = new System.Drawing.Point(145, 418);
            this.tbxGenreAddDropdown.Name = "tbxGenreAddDropdown";
            this.tbxGenreAddDropdown.ReadOnly = true;
            this.tbxGenreAddDropdown.Size = new System.Drawing.Size(125, 20);
            this.tbxGenreAddDropdown.TabIndex = 150;
            // 
            // lbxGenreAdd
            // 
            this.lbxGenreAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.lbxGenreAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxGenreAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbxGenreAdd.FormattingEnabled = true;
            this.lbxGenreAdd.Location = new System.Drawing.Point(145, 443);
            this.lbxGenreAdd.Name = "lbxGenreAdd";
            this.lbxGenreAdd.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxGenreAdd.Size = new System.Drawing.Size(140, 104);
            this.lbxGenreAdd.TabIndex = 152;
            this.lbxGenreAdd.Visible = false;
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
            this.livMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livMedia.ForeColor = System.Drawing.Color.White;
            this.livMedia.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.livMedia.HideSelection = false;
            this.livMedia.LargeImageList = this.imlContentPics;
            this.livMedia.Location = new System.Drawing.Point(11, 116);
            this.livMedia.MultiSelect = false;
            this.livMedia.Name = "livMedia";
            this.livMedia.Size = new System.Drawing.Size(1099, 521);
            this.livMedia.SmallImageList = this.imlContentPics;
            this.livMedia.TabIndex = 154;
            this.livMedia.UseCompatibleStateImageBehavior = false;
            this.livMedia.SelectedIndexChanged += new System.EventHandler(this.livMedia_SelectedIndexChanged);
            // 
            // tbxNewGenre
            // 
            this.tbxNewGenre.Location = new System.Drawing.Point(145, 418);
            this.tbxNewGenre.Name = "tbxNewGenre";
            this.tbxNewGenre.Size = new System.Drawing.Size(140, 20);
            this.tbxNewGenre.TabIndex = 155;
            this.tbxNewGenre.Visible = false;
            // 
            // lbxGenre
            // 
            this.lbxGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.lbxGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbxGenre.FormattingEnabled = true;
            this.lbxGenre.Location = new System.Drawing.Point(189, 114);
            this.lbxGenre.Name = "lbxGenre";
            this.lbxGenre.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxGenre.Size = new System.Drawing.Size(92, 104);
            this.lbxGenre.TabIndex = 158;
            this.lbxGenre.Visible = false;
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
            "Bewertung Ab",
            "Name A-Z",
            "Name Z-A"});
            this.lbxSort.Location = new System.Drawing.Point(42, 115);
            this.lbxSort.Name = "lbxSort";
            this.lbxSort.Size = new System.Drawing.Size(82, 65);
            this.lbxSort.TabIndex = 157;
            this.lbxSort.Visible = false;
            this.lbxSort.SelectedIndexChanged += new System.EventHandler(this.lbxSort_SelectedIndexChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(186, 220);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(95, 23);
            this.btnSelect.TabIndex = 159;
            this.btnSelect.Text = "auswählen";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Visible = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnSettings.BackgroundImage = global::Film_BD_V4.Properties.Resources.Settings1;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnSettings.Location = new System.Drawing.Point(914, 48);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(42, 35);
            this.btnSettings.TabIndex = 160;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pbxSaveNewGenre
            // 
            this.pbxSaveNewGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxSaveNewGenre.Image = ((System.Drawing.Image)(resources.GetObject("pbxSaveNewGenre.Image")));
            this.pbxSaveNewGenre.Location = new System.Drawing.Point(291, 418);
            this.pbxSaveNewGenre.Name = "pbxSaveNewGenre";
            this.pbxSaveNewGenre.Size = new System.Drawing.Size(22, 22);
            this.pbxSaveNewGenre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSaveNewGenre.TabIndex = 156;
            this.pbxSaveNewGenre.TabStop = false;
            this.pbxSaveNewGenre.Visible = false;
            this.pbxSaveNewGenre.Click += new System.EventHandler(this.pbxSaveNewGenre_Click);
            // 
            // btnNewGenre
            // 
            this.btnNewGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnNewGenre.FlatAppearance.BorderSize = 0;
            this.btnNewGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnNewGenre.Image = global::Film_BD_V4.Properties.Resources.hinzufuegen_klein;
            this.btnNewGenre.Location = new System.Drawing.Point(291, 416);
            this.btnNewGenre.Name = "btnNewGenre";
            this.btnNewGenre.Size = new System.Drawing.Size(22, 22);
            this.btnNewGenre.TabIndex = 153;
            this.btnNewGenre.UseVisualStyleBackColor = false;
            this.btnNewGenre.Click += new System.EventHandler(this.btnNewGenre_Click);
            // 
            // pbxGenreDropDown
            // 
            this.pbxGenreDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.pbxGenreDropDown.Image = global::Film_BD_V4.Properties.Resources.dropdown20x20;
            this.pbxGenreDropDown.Location = new System.Drawing.Point(265, 418);
            this.pbxGenreDropDown.Name = "pbxGenreDropDown";
            this.pbxGenreDropDown.Size = new System.Drawing.Size(20, 20);
            this.pbxGenreDropDown.TabIndex = 151;
            this.pbxGenreDropDown.TabStop = false;
            this.pbxGenreDropDown.Click += new System.EventHandler(this.pbxGenreDropDown_Click);
            // 
            // btnShowHide
            // 
            this.btnShowHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnShowHide.FlatAppearance.BorderSize = 0;
            this.btnShowHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowHide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnShowHide.Image = global::Film_BD_V4.Properties.Resources.Pfeil_klein;
            this.btnShowHide.Location = new System.Drawing.Point(2, 89);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(29, 29);
            this.btnShowHide.TabIndex = 149;
            this.btnShowHide.UseVisualStyleBackColor = false;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // pbxSearch
            // 
            this.pbxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.pbxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbxSearch.Image")));
            this.pbxSearch.Location = new System.Drawing.Point(867, 21);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(22, 19);
            this.pbxSearch.TabIndex = 135;
            this.pbxSearch.TabStop = false;
            this.pbxSearch.Click += new System.EventHandler(this.pbxSearch_Click);
            // 
            // btnNewEntry
            // 
            this.btnNewEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnNewEntry.FlatAppearance.BorderSize = 0;
            this.btnNewEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnNewEntry.Image = ((System.Drawing.Image)(resources.GetObject("btnNewEntry.Image")));
            this.btnNewEntry.Location = new System.Drawing.Point(956, 48);
            this.btnNewEntry.Name = "btnNewEntry";
            this.btnNewEntry.Size = new System.Drawing.Size(42, 35);
            this.btnNewEntry.TabIndex = 130;
            this.btnNewEntry.UseVisualStyleBackColor = false;
            this.btnNewEntry.Click += new System.EventHandler(this.btnNewEntry_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(1036, 48);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(42, 35);
            this.btnEdit.TabIndex = 128;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(996, 48);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(42, 35);
            this.btnInfo.TabIndex = 129;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(1075, 49);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(34, 35);
            this.btnDelete.TabIndex = 127;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // pbxBackLV2
            // 
            this.pbxBackLV2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.pbxBackLV2.Location = new System.Drawing.Point(0, 47);
            this.pbxBackLV2.Name = "pbxBackLV2";
            this.pbxBackLV2.Size = new System.Drawing.Size(1115, 40);
            this.pbxBackLV2.TabIndex = 118;
            this.pbxBackLV2.TabStop = false;
            // 
            // pbxBackLV1
            // 
            this.pbxBackLV1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.pbxBackLV1.Location = new System.Drawing.Point(0, 1);
            this.pbxBackLV1.Name = "pbxBackLV1";
            this.pbxBackLV1.Size = new System.Drawing.Size(1115, 47);
            this.pbxBackLV1.TabIndex = 84;
            this.pbxBackLV1.TabStop = false;
            // 
            // pbxOK
            // 
            this.pbxOK.Image = ((System.Drawing.Image)(resources.GetObject("pbxOK.Image")));
            this.pbxOK.Location = new System.Drawing.Point(104, 146);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1111, 637);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lbxGenre);
            this.Controls.Add(this.lbxSort);
            this.Controls.Add(this.pbxSaveNewGenre);
            this.Controls.Add(this.tbxNewGenre);
            this.Controls.Add(this.livMedia);
            this.Controls.Add(this.btnNewGenre);
            this.Controls.Add(this.lbxGenreAdd);
            this.Controls.Add(this.pbxGenreDropDown);
            this.Controls.Add(this.tbxGenreAddDropdown);
            this.Controls.Add(this.btnShowHide);
            this.Controls.Add(this.lblSortInfo);
            this.Controls.Add(this.cbxStarted);
            this.Controls.Add(this.pnlGenre);
            this.Controls.Add(this.btnGenre);
            this.Controls.Add(this.pnlSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lblDelmode);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pbxSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnNewEntry);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pnlShowFavorites);
            this.Controls.Add(this.btnShowFavorites);
            this.Controls.Add(this.pnlShowStarted);
            this.Controls.Add(this.btnShowStarted);
            this.Controls.Add(this.pnlShowFinished);
            this.Controls.Add(this.btnShowFinished);
            this.Controls.Add(this.pnlShowAll);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.pbxBackLV2);
            this.Controls.Add(this.pnlFilterAll);
            this.Controls.Add(this.pnlFilterMovie);
            this.Controls.Add(this.pnlFilterSeries);
            this.Controls.Add(this.pnlFilterAnime);
            this.Controls.Add(this.btnFilterAll);
            this.Controls.Add(this.btnFilterSeries);
            this.Controls.Add(this.btnFilterMovie);
            this.Controls.Add(this.btnFilterAnime);
            this.Controls.Add(this.pbxBackLV1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Film_DB";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSaveNewGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGenreDropDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackLV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackLV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Timer tmrHide;
        private System.Windows.Forms.OpenFileDialog ofdImageSelect;
        private System.Windows.Forms.ToolTip ttpInfo;
        private System.Windows.Forms.PictureBox pbxBackLV1;
        private System.Windows.Forms.Panel pnlFilterAll;
        private System.Windows.Forms.Panel pnlFilterMovie;
        private System.Windows.Forms.Panel pnlFilterSeries;
        private System.Windows.Forms.Panel pnlFilterAnime;
        private System.Windows.Forms.Button btnFilterAll;
        private System.Windows.Forms.Button btnFilterSeries;
        private System.Windows.Forms.Button btnFilterMovie;
        private System.Windows.Forms.Button btnFilterAnime;
        private System.Windows.Forms.PictureBox pbxBackLV2;
        private System.Windows.Forms.Panel pnlShowFavorites;
        private System.Windows.Forms.Button btnShowFavorites;
        private System.Windows.Forms.Panel pnlShowStarted;
        private System.Windows.Forms.Button btnShowStarted;
        private System.Windows.Forms.Panel pnlShowFinished;
        private System.Windows.Forms.Button btnShowFinished;
        private System.Windows.Forms.Panel pnlShowAll;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnNewEntry;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pbxSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblDelmode;
        private System.Windows.Forms.Panel pnlSort;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnGenre;
        private System.Windows.Forms.Panel pnlGenre;
        private System.Windows.Forms.CheckBox cbxStarted;
        private System.Windows.Forms.Label lblSortInfo;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.TextBox tbxGenreAddDropdown;
        private System.Windows.Forms.PictureBox pbxGenreDropDown;
        private System.Windows.Forms.ListBox lbxGenreAdd;
        private System.Windows.Forms.Button btnNewGenre;
        private System.Windows.Forms.ListView livMedia;
        private System.Windows.Forms.ColumnHeader img1;
        private System.Windows.Forms.ColumnHeader img2;
        private System.Windows.Forms.ColumnHeader img3;
        private System.Windows.Forms.ColumnHeader img4;
        private System.Windows.Forms.TextBox tbxNewGenre;
        private System.Windows.Forms.PictureBox pbxSaveNewGenre;
        private System.Windows.Forms.ListBox lbxGenre;
        private System.Windows.Forms.ListBox lbxSort;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSettings;
    }
}

