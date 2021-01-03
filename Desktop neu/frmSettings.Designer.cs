namespace Film_BD_V4
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.cbxPerformance = new System.Windows.Forms.CheckBox();
            this.cbxLogging = new System.Windows.Forms.CheckBox();
            this.btnCopyOneDrive = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblLastSync = new System.Windows.Forms.Label();
            this.pbxSelectOneDrive = new System.Windows.Forms.PictureBox();
            this.fbdSelectOnedrive = new System.Windows.Forms.FolderBrowserDialog();
            this.ttpInfo = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSelectOneDrive)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxPerformance
            // 
            this.cbxPerformance.AutoSize = true;
            this.cbxPerformance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbxPerformance.Location = new System.Drawing.Point(13, 13);
            this.cbxPerformance.Name = "cbxPerformance";
            this.cbxPerformance.Size = new System.Drawing.Size(212, 17);
            this.cbxPerformance.TabIndex = 0;
            this.cbxPerformance.Text = "Performancebooster (erfordert Neustart)";
            this.cbxPerformance.UseVisualStyleBackColor = true;
            this.cbxPerformance.CheckedChanged += new System.EventHandler(this.cbxPerformance_CheckedChanged);
            // 
            // cbxLogging
            // 
            this.cbxLogging.AutoSize = true;
            this.cbxLogging.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbxLogging.Location = new System.Drawing.Point(13, 37);
            this.cbxLogging.Name = "cbxLogging";
            this.cbxLogging.Size = new System.Drawing.Size(64, 17);
            this.cbxLogging.TabIndex = 1;
            this.cbxLogging.Text = "Logging";
            this.cbxLogging.UseVisualStyleBackColor = true;
            this.cbxLogging.CheckedChanged += new System.EventHandler(this.cbxLogging_CheckedChanged);
            // 
            // btnCopyOneDrive
            // 
            this.btnCopyOneDrive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnCopyOneDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyOneDrive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCopyOneDrive.Location = new System.Drawing.Point(53, 67);
            this.btnCopyOneDrive.Name = "btnCopyOneDrive";
            this.btnCopyOneDrive.Size = new System.Drawing.Size(134, 23);
            this.btnCopyOneDrive.TabIndex = 2;
            this.btnCopyOneDrive.Text = "nach OneDrive kopieren";
            this.btnCopyOneDrive.UseVisualStyleBackColor = false;
            this.btnCopyOneDrive.Click += new System.EventHandler(this.btnCopyOneDrive_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOk.Location = new System.Drawing.Point(93, 154);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblLastSync
            // 
            this.lblLastSync.AutoSize = true;
            this.lblLastSync.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblLastSync.Location = new System.Drawing.Point(51, 93);
            this.lblLastSync.Name = "lblLastSync";
            this.lblLastSync.Size = new System.Drawing.Size(84, 13);
            this.lblLastSync.TabIndex = 4;
            this.lblLastSync.Text = "letzter Sync: Nie";
            // 
            // pbxSelectOneDrive
            // 
            this.pbxSelectOneDrive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxSelectOneDrive.Image = ((System.Drawing.Image)(resources.GetObject("pbxSelectOneDrive.Image")));
            this.pbxSelectOneDrive.Location = new System.Drawing.Point(12, 67);
            this.pbxSelectOneDrive.Name = "pbxSelectOneDrive";
            this.pbxSelectOneDrive.Size = new System.Drawing.Size(32, 32);
            this.pbxSelectOneDrive.TabIndex = 5;
            this.pbxSelectOneDrive.TabStop = false;
            this.ttpInfo.SetToolTip(this.pbxSelectOneDrive, "Onedriveordner wählen");
            this.pbxSelectOneDrive.Click += new System.EventHandler(this.pbxSelectOneDrive_Click);
            this.pbxSelectOneDrive.MouseHover += new System.EventHandler(this.pbxSelectOneDrive_MouseHover);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(253, 189);
            this.Controls.Add(this.pbxSelectOneDrive);
            this.Controls.Add(this.lblLastSync);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCopyOneDrive);
            this.Controls.Add(this.cbxLogging);
            this.Controls.Add(this.cbxPerformance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.ShowInTaskbar = false;
            this.Text = "Einstellungen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            this.Load += new System.EventHandler(this.frmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSelectOneDrive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxPerformance;
        private System.Windows.Forms.CheckBox cbxLogging;
        private System.Windows.Forms.Button btnCopyOneDrive;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblLastSync;
        private System.Windows.Forms.PictureBox pbxSelectOneDrive;
        private System.Windows.Forms.FolderBrowserDialog fbdSelectOnedrive;
        private System.Windows.Forms.ToolTip ttpInfo;
    }
}