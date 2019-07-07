namespace SportsMeet
{
    partial class SearchPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPlayer));
            this.tbxPlayerNumberSW = new System.Windows.Forms.TextBox();
            this.tbxFirstNameSW = new System.Windows.Forms.TextBox();
            this.tbxLastNameSW = new System.Windows.Forms.TextBox();
            this.lblPlayerNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSchoolSW = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownAgeSW = new System.Windows.Forms.NumericUpDown();
            this.cbxDistrictSW = new System.Windows.Forms.ComboBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnSearchSW = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxRegionsSW = new System.Windows.Forms.ComboBox();
            this.groupBoxPlayer = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPlayerAgeSW = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPlayerGenderSW = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelPlayerFullNameSW = new System.Windows.Forms.Label();
            this.labelPlayerNumberSW = new System.Windows.Forms.Label();
            this.buttonOkaySW = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgeSW)).BeginInit();
            this.groupBoxPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxPlayerNumberSW
            // 
            this.tbxPlayerNumberSW.Location = new System.Drawing.Point(160, 18);
            this.tbxPlayerNumberSW.Name = "tbxPlayerNumberSW";
            this.tbxPlayerNumberSW.Size = new System.Drawing.Size(100, 26);
            this.tbxPlayerNumberSW.TabIndex = 0;
            // 
            // tbxFirstNameSW
            // 
            this.tbxFirstNameSW.Location = new System.Drawing.Point(160, 54);
            this.tbxFirstNameSW.Name = "tbxFirstNameSW";
            this.tbxFirstNameSW.Size = new System.Drawing.Size(100, 26);
            this.tbxFirstNameSW.TabIndex = 1;
            // 
            // tbxLastNameSW
            // 
            this.tbxLastNameSW.Location = new System.Drawing.Point(160, 89);
            this.tbxLastNameSW.Name = "tbxLastNameSW";
            this.tbxLastNameSW.Size = new System.Drawing.Size(100, 26);
            this.tbxLastNameSW.TabIndex = 2;
            // 
            // lblPlayerNumber
            // 
            this.lblPlayerNumber.AutoSize = true;
            this.lblPlayerNumber.Location = new System.Drawing.Point(8, 25);
            this.lblPlayerNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerNumber.Name = "lblPlayerNumber";
            this.lblPlayerNumber.Size = new System.Drawing.Size(112, 20);
            this.lblPlayerNumber.TabIndex = 3;
            this.lblPlayerNumber.Text = "Player Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Last Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbxSchoolSW
            // 
            this.cbxSchoolSW.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSchoolSW.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSchoolSW.DisplayMember = "Name";
            this.cbxSchoolSW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSchoolSW.FormattingEnabled = true;
            this.cbxSchoolSW.Location = new System.Drawing.Point(160, 123);
            this.cbxSchoolSW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxSchoolSW.Name = "cbxSchoolSW";
            this.cbxSchoolSW.Size = new System.Drawing.Size(180, 28);
            this.cbxSchoolSW.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "School";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numericUpDownAgeSW
            // 
            this.numericUpDownAgeSW.Location = new System.Drawing.Point(160, 158);
            this.numericUpDownAgeSW.Name = "numericUpDownAgeSW";
            this.numericUpDownAgeSW.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownAgeSW.TabIndex = 9;
            this.numericUpDownAgeSW.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // cbxDistrictSW
            // 
            this.cbxDistrictSW.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxDistrictSW.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxDistrictSW.DisplayMember = "Name";
            this.cbxDistrictSW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDistrictSW.FormattingEnabled = true;
            this.cbxDistrictSW.Location = new System.Drawing.Point(160, 228);
            this.cbxDistrictSW.Margin = new System.Windows.Forms.Padding(6);
            this.cbxDistrictSW.Name = "cbxDistrictSW";
            this.cbxDistrictSW.Size = new System.Drawing.Size(180, 28);
            this.cbxDistrictSW.TabIndex = 11;
            this.cbxDistrictSW.Visible = false;
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Location = new System.Drawing.Point(12, 234);
            this.lblDistrict.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(58, 20);
            this.lblDistrict.TabIndex = 27;
            this.lblDistrict.Text = "District";
            this.lblDistrict.Visible = false;
            this.lblDistrict.Click += new System.EventHandler(this.lblDistrict_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(8, 165);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 20);
            this.lblAge.TabIndex = 25;
            this.lblAge.Text = "Age";
            this.lblAge.Click += new System.EventHandler(this.lblAge_Click);
            // 
            // btnSearchSW
            // 
            this.btnSearchSW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchSW.Location = new System.Drawing.Point(433, 19);
            this.btnSearchSW.Name = "btnSearchSW";
            this.btnSearchSW.Size = new System.Drawing.Size(208, 38);
            this.btnSearchSW.TabIndex = 28;
            this.btnSearchSW.Text = "Search";
            this.btnSearchSW.UseVisualStyleBackColor = true;
            this.btnSearchSW.Click += new System.EventHandler(this.btnSearchSW_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Region";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbxRegionsSW
            // 
            this.cbxRegionsSW.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxRegionsSW.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxRegionsSW.DisplayMember = "Name";
            this.cbxRegionsSW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRegionsSW.FormattingEnabled = true;
            this.cbxRegionsSW.Location = new System.Drawing.Point(160, 263);
            this.cbxRegionsSW.Margin = new System.Windows.Forms.Padding(6);
            this.cbxRegionsSW.Name = "cbxRegionsSW";
            this.cbxRegionsSW.Size = new System.Drawing.Size(180, 28);
            this.cbxRegionsSW.TabIndex = 30;
            this.cbxRegionsSW.Visible = false;
            // 
            // groupBoxPlayer
            // 
            this.groupBoxPlayer.Controls.Add(this.lblPlayerNumber);
            this.groupBoxPlayer.Controls.Add(this.tbxPlayerNumberSW);
            this.groupBoxPlayer.Controls.Add(this.tbxFirstNameSW);
            this.groupBoxPlayer.Controls.Add(this.tbxLastNameSW);
            this.groupBoxPlayer.Controls.Add(this.label1);
            this.groupBoxPlayer.Controls.Add(this.label2);
            this.groupBoxPlayer.Controls.Add(this.cbxSchoolSW);
            this.groupBoxPlayer.Controls.Add(this.label3);
            this.groupBoxPlayer.Controls.Add(this.cbxRegionsSW);
            this.groupBoxPlayer.Controls.Add(this.label4);
            this.groupBoxPlayer.Controls.Add(this.cbxDistrictSW);
            this.groupBoxPlayer.Controls.Add(this.numericUpDownAgeSW);
            this.groupBoxPlayer.Controls.Add(this.lblDistrict);
            this.groupBoxPlayer.Controls.Add(this.lblAge);
            this.groupBoxPlayer.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPlayer.Name = "groupBoxPlayer";
            this.groupBoxPlayer.Size = new System.Drawing.Size(409, 302);
            this.groupBoxPlayer.TabIndex = 37;
            this.groupBoxPlayer.TabStop = false;
            this.groupBoxPlayer.Text = "Player Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 348);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Player Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 374);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Full Name";
            // 
            // labelPlayerAgeSW
            // 
            this.labelPlayerAgeSW.AutoSize = true;
            this.labelPlayerAgeSW.Location = new System.Drawing.Point(168, 428);
            this.labelPlayerAgeSW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayerAgeSW.Name = "labelPlayerAgeSW";
            this.labelPlayerAgeSW.Size = new System.Drawing.Size(140, 20);
            this.labelPlayerAgeSW.TabIndex = 46;
            this.labelPlayerAgeSW.Text = "labelPlayerAgeSW";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 428);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Age";
            // 
            // labelPlayerGenderSW
            // 
            this.labelPlayerGenderSW.AutoSize = true;
            this.labelPlayerGenderSW.Location = new System.Drawing.Point(168, 402);
            this.labelPlayerGenderSW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayerGenderSW.Name = "labelPlayerGenderSW";
            this.labelPlayerGenderSW.Size = new System.Drawing.Size(165, 20);
            this.labelPlayerGenderSW.TabIndex = 45;
            this.labelPlayerGenderSW.Text = "labelPlayerGenderSW";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 402);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Gender";
            // 
            // labelPlayerFullNameSW
            // 
            this.labelPlayerFullNameSW.AutoSize = true;
            this.labelPlayerFullNameSW.Location = new System.Drawing.Point(168, 374);
            this.labelPlayerFullNameSW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayerFullNameSW.Name = "labelPlayerFullNameSW";
            this.labelPlayerFullNameSW.Size = new System.Drawing.Size(178, 20);
            this.labelPlayerFullNameSW.TabIndex = 44;
            this.labelPlayerFullNameSW.Text = "labelPlayerFullNameSW";
            // 
            // labelPlayerNumberSW
            // 
            this.labelPlayerNumberSW.AutoSize = true;
            this.labelPlayerNumberSW.Location = new System.Drawing.Point(168, 348);
            this.labelPlayerNumberSW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayerNumberSW.Name = "labelPlayerNumberSW";
            this.labelPlayerNumberSW.Size = new System.Drawing.Size(167, 20);
            this.labelPlayerNumberSW.TabIndex = 43;
            this.labelPlayerNumberSW.Text = "labelPlayerNumberSW";
            // 
            // buttonOkaySW
            // 
            this.buttonOkaySW.Location = new System.Drawing.Point(433, 265);
            this.buttonOkaySW.Name = "buttonOkaySW";
            this.buttonOkaySW.Size = new System.Drawing.Size(208, 38);
            this.buttonOkaySW.TabIndex = 47;
            this.buttonOkaySW.Text = "OK";
            this.buttonOkaySW.UseVisualStyleBackColor = true;
            this.buttonOkaySW.Click += new System.EventHandler(this.buttonOkaySW_Click);
            // 
            // SearchPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 467);
            this.Controls.Add(this.buttonOkaySW);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelPlayerAgeSW);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelPlayerGenderSW);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelPlayerFullNameSW);
            this.Controls.Add(this.labelPlayerNumberSW);
            this.Controls.Add(this.groupBoxPlayer);
            this.Controls.Add(this.btnSearchSW);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchPlayer";
            this.Text = "Search Player";
            this.Load += new System.EventHandler(this.SearchPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgeSW)).EndInit();
            this.groupBoxPlayer.ResumeLayout(false);
            this.groupBoxPlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPlayerNumberSW;
        private System.Windows.Forms.TextBox tbxFirstNameSW;
        private System.Windows.Forms.TextBox tbxLastNameSW;
        private System.Windows.Forms.Label lblPlayerNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxSchoolSW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownAgeSW;
        private System.Windows.Forms.ComboBox cbxDistrictSW;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnSearchSW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxRegionsSW;
        private System.Windows.Forms.GroupBox groupBoxPlayer;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPlayerAgeSW;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelPlayerGenderSW;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelPlayerFullNameSW;
        private System.Windows.Forms.Label labelPlayerNumberSW;
        public System.Windows.Forms.Button buttonOkaySW;
    }
}