namespace SportsMeet
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tcMainForm = new System.Windows.Forms.TabControl();
            this.tbPlayers = new System.Windows.Forms.TabPage();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.numUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.gridViewPlayers = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblPlayerNumber = new System.Windows.Forms.Label();
            this.tbPlayerNumber = new System.Windows.Forms.TextBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.tpEvents = new System.Windows.Forms.TabPage();
            this.tabButtonImages = new System.Windows.Forms.ImageList(this.components);
            this.toolStripMainBottom = new System.Windows.Forms.ToolStrip();
            this.tspLabelTotalPlayers = new System.Windows.Forms.ToolStripLabel();
            this.tspLblPlayerCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripMainAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tcMainForm.SuspendLayout();
            this.tbPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPlayers)).BeginInit();
            this.toolStripMainBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMainForm
            // 
            this.tcMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMainForm.Controls.Add(this.tbPlayers);
            this.tcMainForm.Controls.Add(this.tpEvents);
            this.tcMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMainForm.ImageList = this.tabButtonImages;
            this.tcMainForm.ItemSize = new System.Drawing.Size(40, 50);
            this.tcMainForm.Location = new System.Drawing.Point(8, -3);
            this.tcMainForm.Margin = new System.Windows.Forms.Padding(6);
            this.tcMainForm.Multiline = true;
            this.tcMainForm.Name = "tcMainForm";
            this.tcMainForm.SelectedIndex = 0;
            this.tcMainForm.Size = new System.Drawing.Size(1616, 728);
            this.tcMainForm.TabIndex = 0;
            // 
            // tbPlayers
            // 
            this.tbPlayers.Controls.Add(this.btnDeletePlayer);
            this.tbPlayers.Controls.Add(this.numUpDownAge);
            this.tbPlayers.Controls.Add(this.gridViewPlayers);
            this.tbPlayers.Controls.Add(this.tbSearch);
            this.tbPlayers.Controls.Add(this.cbxGender);
            this.tbPlayers.Controls.Add(this.lblGender);
            this.tbPlayers.Controls.Add(this.lblAge);
            this.tbPlayers.Controls.Add(this.lblLastName);
            this.tbPlayers.Controls.Add(this.lbFirstName);
            this.tbPlayers.Controls.Add(this.tbLastName);
            this.tbPlayers.Controls.Add(this.tbFirstName);
            this.tbPlayers.Controls.Add(this.lblPlayerNumber);
            this.tbPlayers.Controls.Add(this.tbPlayerNumber);
            this.tbPlayers.Controls.Add(this.btnAddPlayer);
            this.tbPlayers.ImageIndex = 0;
            this.tbPlayers.Location = new System.Drawing.Point(8, 58);
            this.tbPlayers.Margin = new System.Windows.Forms.Padding(0);
            this.tbPlayers.Name = "tbPlayers";
            this.tbPlayers.Size = new System.Drawing.Size(1600, 662);
            this.tbPlayers.TabIndex = 1;
            this.tbPlayers.Text = "Players";
            this.tbPlayers.UseVisualStyleBackColor = true;
            this.tbPlayers.Click += new System.EventHandler(this.tbPlayers_Click);
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.Location = new System.Drawing.Point(257, 509);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(192, 65);
            this.btnDeletePlayer.TabIndex = 17;
            this.btnDeletePlayer.Text = "Delete";
            this.btnDeletePlayer.UseVisualStyleBackColor = true;
            this.btnDeletePlayer.Click += new System.EventHandler(this.btnDeletePlayer_Click);
            // 
            // numUpDownAge
            // 
            this.numUpDownAge.Location = new System.Drawing.Point(309, 252);
            this.numUpDownAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownAge.Name = "numUpDownAge";
            this.numUpDownAge.Size = new System.Drawing.Size(120, 44);
            this.numUpDownAge.TabIndex = 16;
            this.numUpDownAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gridViewPlayers
            // 
            this.gridViewPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewPlayers.ColumnHeadersHeight = 30;
            this.gridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewPlayers.Location = new System.Drawing.Point(703, 108);
            this.gridViewPlayers.Name = "gridViewPlayers";
            this.gridViewPlayers.RowTemplate.Height = 33;
            this.gridViewPlayers.Size = new System.Drawing.Size(874, 513);
            this.gridViewPlayers.TabIndex = 15;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbSearch.Location = new System.Drawing.Point(703, 39);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(874, 44);
            this.tbSearch.TabIndex = 13;
            this.tbSearch.Text = "Type Player Number to search";
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxGender.Location = new System.Drawing.Point(309, 321);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(121, 45);
            this.cbxGender.TabIndex = 11;
            this.cbxGender.Text = "Male";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(14, 315);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(123, 37);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(14, 246);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(74, 37);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Age";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(14, 177);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(173, 37);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(14, 108);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(175, 37);
            this.lbFirstName.TabIndex = 7;
            this.lbFirstName.Text = "First Name";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(309, 183);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(244, 44);
            this.tbLastName.TabIndex = 4;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(309, 114);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(244, 44);
            this.tbFirstName.TabIndex = 3;
            // 
            // lblPlayerNumber
            // 
            this.lblPlayerNumber.AutoSize = true;
            this.lblPlayerNumber.Location = new System.Drawing.Point(14, 39);
            this.lblPlayerNumber.Name = "lblPlayerNumber";
            this.lblPlayerNumber.Size = new System.Drawing.Size(230, 37);
            this.lblPlayerNumber.TabIndex = 2;
            this.lblPlayerNumber.Text = "Player Number";
            // 
            // tbPlayerNumber
            // 
            this.tbPlayerNumber.Location = new System.Drawing.Point(309, 45);
            this.tbPlayerNumber.Name = "tbPlayerNumber";
            this.tbPlayerNumber.Size = new System.Drawing.Size(247, 44);
            this.tbPlayerNumber.TabIndex = 1;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(21, 509);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(192, 65);
            this.btnAddPlayer.TabIndex = 0;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // tpEvents
            // 
            this.tpEvents.AutoScroll = true;
            this.tpEvents.ImageIndex = 1;
            this.tpEvents.Location = new System.Drawing.Point(8, 58);
            this.tpEvents.Margin = new System.Windows.Forms.Padding(0);
            this.tpEvents.Name = "tpEvents";
            this.tpEvents.Size = new System.Drawing.Size(1600, 662);
            this.tpEvents.TabIndex = 0;
            this.tpEvents.Text = "Events";
            this.tpEvents.ToolTipText = "Add Players";
            this.tpEvents.UseVisualStyleBackColor = true;
            // 
            // tabButtonImages
            // 
            this.tabButtonImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabButtonImages.ImageStream")));
            this.tabButtonImages.TransparentColor = System.Drawing.Color.Transparent;
            this.tabButtonImages.Images.SetKeyName(0, "Icons8-Windows-8-Sports-Running-Man.ico");
            this.tabButtonImages.Images.SetKeyName(1, "Icons8-Windows-8-Sports-Football-2.ico");
            // 
            // toolStripMainBottom
            // 
            this.toolStripMainBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripMainBottom.AutoSize = false;
            this.toolStripMainBottom.CanOverflow = false;
            this.toolStripMainBottom.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripMainBottom.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripMainBottom.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripMainBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspLabelTotalPlayers,
            this.tspLblPlayerCount,
            this.toolStripMainAbout,
            this.toolStripSeparator1});
            this.toolStripMainBottom.Location = new System.Drawing.Point(8, 722);
            this.toolStripMainBottom.Name = "toolStripMainBottom";
            this.toolStripMainBottom.Size = new System.Drawing.Size(1607, 48);
            this.toolStripMainBottom.TabIndex = 0;
            // 
            // tspLabelTotalPlayers
            // 
            this.tspLabelTotalPlayers.Name = "tspLabelTotalPlayers";
            this.tspLabelTotalPlayers.Size = new System.Drawing.Size(147, 45);
            this.tspLabelTotalPlayers.Text = "Total Players";
            // 
            // tspLblPlayerCount
            // 
            this.tspLblPlayerCount.Name = "tspLblPlayerCount";
            this.tspLblPlayerCount.Size = new System.Drawing.Size(28, 45);
            this.tspLblPlayerCount.Text = "0";
            // 
            // toolStripMainAbout
            // 
            this.toolStripMainAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMainAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMainAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMainAbout.Name = "toolStripMainAbout";
            this.toolStripMainAbout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMainAbout.Size = new System.Drawing.Size(84, 45);
            this.toolStripMainAbout.Text = "About";
            this.toolStripMainAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripMainAbout.ToolTipText = "About";
            this.toolStripMainAbout.Click += new System.EventHandler(this.toolStripMainAbout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 779);
            this.Controls.Add(this.toolStripMainBottom);
            this.Controls.Add(this.tcMainForm);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1650, 850);
            this.Name = "MainForm";
            this.Text = "Sports Meet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.tcMainForm.ResumeLayout(false);
            this.tbPlayers.ResumeLayout(false);
            this.tbPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPlayers)).EndInit();
            this.toolStripMainBottom.ResumeLayout(false);
            this.toolStripMainBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMainForm;
        private System.Windows.Forms.TabPage tpEvents;
        private System.Windows.Forms.TabPage tbPlayers;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblPlayerNumber;
        private System.Windows.Forms.TextBox tbPlayerNumber;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.DataGridView gridViewPlayers;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.NumericUpDown numUpDownAge;
        private System.Windows.Forms.ImageList tabButtonImages;
        private System.Windows.Forms.ToolStrip toolStripMainBottom;
        private System.Windows.Forms.ToolStripLabel tspLabelTotalPlayers;
        private System.Windows.Forms.ToolStripLabel tspLblPlayerCount;
        private System.Windows.Forms.ToolStripButton toolStripMainAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnDeletePlayer;
    }
}

