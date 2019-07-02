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
            this.components = new System.ComponentModel.Container();
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
            this.cbxGenderSW = new System.Windows.Forms.ComboBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnSearchSW = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxRegionsSW = new System.Windows.Forms.ComboBox();
            this.numericUpDownEventAgeLimit = new System.Windows.Forms.NumericUpDown();
            this.labelEventsAgeLimit = new System.Windows.Forms.Label();
            this.tbNewEventsName = new System.Windows.Forms.TextBox();
            this.tbNewEventsNumber = new System.Windows.Forms.TextBox();
            this.lblNewEventsName = new System.Windows.Forms.Label();
            this.lblNewEventsNumber = new System.Windows.Forms.Label();
            this.groupBoxPlayer = new System.Windows.Forms.GroupBox();
            this.groupBoxEvent = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPlayerAgeSW = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPlayerGenderSW = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelPlayerFullNameSW = new System.Windows.Forms.Label();
            this.labelPlayerNumberSW = new System.Windows.Forms.Label();
            this.dataGridViewEventsBelongToPlayer = new System.Windows.Forms.DataGridView();
            this.bindingSourceSearchedPlayers = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgeSW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEventAgeLimit)).BeginInit();
            this.groupBoxPlayer.SuspendLayout();
            this.groupBoxEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventsBelongToPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSearchedPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxPlayerNumberSW
            // 
            this.tbxPlayerNumberSW.Location = new System.Drawing.Point(160, 19);
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
            this.lblPlayerNumber.Location = new System.Drawing.Point(7, 22);
            this.lblPlayerNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerNumber.Name = "lblPlayerNumber";
            this.lblPlayerNumber.Size = new System.Drawing.Size(112, 20);
            this.lblPlayerNumber.TabIndex = 3;
            this.lblPlayerNumber.Text = "Player Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // cbxSchoolSW
            // 
            this.cbxSchoolSW.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSchoolSW.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSchoolSW.DisplayMember = "Name";
            this.cbxSchoolSW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSchoolSW.FormattingEnabled = true;
            this.cbxSchoolSW.Location = new System.Drawing.Point(160, 123);
            this.cbxSchoolSW.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSchoolSW.Name = "cbxSchoolSW";
            this.cbxSchoolSW.Size = new System.Drawing.Size(180, 28);
            this.cbxSchoolSW.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "School";
            // 
            // numericUpDownAgeSW
            // 
            this.numericUpDownAgeSW.Location = new System.Drawing.Point(160, 159);
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
            // 
            // cbxGenderSW
            // 
            this.cbxGenderSW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGenderSW.FormattingEnabled = true;
            this.cbxGenderSW.Items.AddRange(new object[] {
            "Not known",
            "Male",
            "Female",
            "Not applicable"});
            this.cbxGenderSW.Location = new System.Drawing.Point(160, 193);
            this.cbxGenderSW.Margin = new System.Windows.Forms.Padding(4);
            this.cbxGenderSW.Name = "cbxGenderSW";
            this.cbxGenderSW.Size = new System.Drawing.Size(120, 28);
            this.cbxGenderSW.TabIndex = 10;
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Location = new System.Drawing.Point(7, 232);
            this.lblDistrict.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(58, 20);
            this.lblDistrict.TabIndex = 27;
            this.lblDistrict.Text = "District";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(7, 197);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 20);
            this.lblGender.TabIndex = 26;
            this.lblGender.Text = "Gender";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(7, 162);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 20);
            this.lblAge.TabIndex = 25;
            this.lblAge.Text = "Age";
            // 
            // btnSearchSW
            // 
            this.btnSearchSW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchSW.Location = new System.Drawing.Point(625, 335);
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
            this.label4.Location = new System.Drawing.Point(7, 267);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Region";
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
            // 
            // numericUpDownEventAgeLimit
            // 
            this.numericUpDownEventAgeLimit.Location = new System.Drawing.Point(131, 89);
            this.numericUpDownEventAgeLimit.Name = "numericUpDownEventAgeLimit";
            this.numericUpDownEventAgeLimit.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownEventAgeLimit.TabIndex = 34;
            this.numericUpDownEventAgeLimit.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // labelEventsAgeLimit
            // 
            this.labelEventsAgeLimit.AutoSize = true;
            this.labelEventsAgeLimit.Location = new System.Drawing.Point(9, 92);
            this.labelEventsAgeLimit.Name = "labelEventsAgeLimit";
            this.labelEventsAgeLimit.Size = new System.Drawing.Size(75, 20);
            this.labelEventsAgeLimit.TabIndex = 36;
            this.labelEventsAgeLimit.Text = "Age Limit";
            // 
            // tbNewEventsName
            // 
            this.tbNewEventsName.Location = new System.Drawing.Point(131, 54);
            this.tbNewEventsName.Margin = new System.Windows.Forms.Padding(6);
            this.tbNewEventsName.Name = "tbNewEventsName";
            this.tbNewEventsName.Size = new System.Drawing.Size(196, 26);
            this.tbNewEventsName.TabIndex = 32;
            // 
            // tbNewEventsNumber
            // 
            this.tbNewEventsNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbNewEventsNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbNewEventsNumber.Location = new System.Drawing.Point(131, 19);
            this.tbNewEventsNumber.Margin = new System.Windows.Forms.Padding(6);
            this.tbNewEventsNumber.Name = "tbNewEventsNumber";
            this.tbNewEventsNumber.Size = new System.Drawing.Size(196, 26);
            this.tbNewEventsNumber.TabIndex = 31;
            // 
            // lblNewEventsName
            // 
            this.lblNewEventsName.AutoSize = true;
            this.lblNewEventsName.Location = new System.Drawing.Point(9, 57);
            this.lblNewEventsName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNewEventsName.Name = "lblNewEventsName";
            this.lblNewEventsName.Size = new System.Drawing.Size(96, 20);
            this.lblNewEventsName.TabIndex = 35;
            this.lblNewEventsName.Text = "Event Name";
            // 
            // lblNewEventsNumber
            // 
            this.lblNewEventsNumber.AutoSize = true;
            this.lblNewEventsNumber.Location = new System.Drawing.Point(9, 22);
            this.lblNewEventsNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNewEventsNumber.Name = "lblNewEventsNumber";
            this.lblNewEventsNumber.Size = new System.Drawing.Size(110, 20);
            this.lblNewEventsNumber.TabIndex = 33;
            this.lblNewEventsNumber.Text = "Event Number";
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
            this.groupBoxPlayer.Controls.Add(this.cbxGenderSW);
            this.groupBoxPlayer.Controls.Add(this.label4);
            this.groupBoxPlayer.Controls.Add(this.cbxDistrictSW);
            this.groupBoxPlayer.Controls.Add(this.numericUpDownAgeSW);
            this.groupBoxPlayer.Controls.Add(this.lblDistrict);
            this.groupBoxPlayer.Controls.Add(this.lblAge);
            this.groupBoxPlayer.Controls.Add(this.lblGender);
            this.groupBoxPlayer.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPlayer.Name = "groupBoxPlayer";
            this.groupBoxPlayer.Size = new System.Drawing.Size(460, 301);
            this.groupBoxPlayer.TabIndex = 37;
            this.groupBoxPlayer.TabStop = false;
            this.groupBoxPlayer.Text = "Player Details";
            // 
            // groupBoxEvent
            // 
            this.groupBoxEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEvent.Controls.Add(this.lblNewEventsNumber);
            this.groupBoxEvent.Controls.Add(this.lblNewEventsName);
            this.groupBoxEvent.Controls.Add(this.numericUpDownEventAgeLimit);
            this.groupBoxEvent.Controls.Add(this.tbNewEventsNumber);
            this.groupBoxEvent.Controls.Add(this.labelEventsAgeLimit);
            this.groupBoxEvent.Controls.Add(this.tbNewEventsName);
            this.groupBoxEvent.Location = new System.Drawing.Point(490, 12);
            this.groupBoxEvent.Name = "groupBoxEvent";
            this.groupBoxEvent.Size = new System.Drawing.Size(343, 301);
            this.groupBoxEvent.TabIndex = 38;
            this.groupBoxEvent.TabStop = false;
            this.groupBoxEvent.Text = "Event Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 347);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Player Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 374);
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
            this.label7.Location = new System.Drawing.Point(19, 428);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Age";
            // 
            // labelPlayerGenderSW
            // 
            this.labelPlayerGenderSW.AutoSize = true;
            this.labelPlayerGenderSW.Location = new System.Drawing.Point(168, 401);
            this.labelPlayerGenderSW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayerGenderSW.Name = "labelPlayerGenderSW";
            this.labelPlayerGenderSW.Size = new System.Drawing.Size(165, 20);
            this.labelPlayerGenderSW.TabIndex = 45;
            this.labelPlayerGenderSW.Text = "labelPlayerGenderSW";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 401);
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
            this.labelPlayerNumberSW.Location = new System.Drawing.Point(168, 347);
            this.labelPlayerNumberSW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayerNumberSW.Name = "labelPlayerNumberSW";
            this.labelPlayerNumberSW.Size = new System.Drawing.Size(167, 20);
            this.labelPlayerNumberSW.TabIndex = 43;
            this.labelPlayerNumberSW.Text = "labelPlayerNumberSW";
            // 
            // dataGridViewEventsBelongToPlayer
            // 
            this.dataGridViewEventsBelongToPlayer.AllowUserToAddRows = false;
            this.dataGridViewEventsBelongToPlayer.AllowUserToDeleteRows = false;
            this.dataGridViewEventsBelongToPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEventsBelongToPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventsBelongToPlayer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewEventsBelongToPlayer.Location = new System.Drawing.Point(12, 466);
            this.dataGridViewEventsBelongToPlayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewEventsBelongToPlayer.Name = "dataGridViewEventsBelongToPlayer";
            this.dataGridViewEventsBelongToPlayer.Size = new System.Drawing.Size(821, 307);
            this.dataGridViewEventsBelongToPlayer.TabIndex = 47;
            // 
            // bindingSourceSearchedPlayers
            // 
            this.bindingSourceSearchedPlayers.DataSource = typeof(SportsMeet.Models.Player);
            // 
            // SearchPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 781);
            this.Controls.Add(this.dataGridViewEventsBelongToPlayer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelPlayerAgeSW);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelPlayerGenderSW);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelPlayerFullNameSW);
            this.Controls.Add(this.labelPlayerNumberSW);
            this.Controls.Add(this.groupBoxEvent);
            this.Controls.Add(this.groupBoxPlayer);
            this.Controls.Add(this.btnSearchSW);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchPlayer";
            this.Text = "Search Player";
            this.Load += new System.EventHandler(this.SearchPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgeSW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEventAgeLimit)).EndInit();
            this.groupBoxPlayer.ResumeLayout(false);
            this.groupBoxPlayer.PerformLayout();
            this.groupBoxEvent.ResumeLayout(false);
            this.groupBoxEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventsBelongToPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSearchedPlayers)).EndInit();
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
        private System.Windows.Forms.ComboBox cbxGenderSW;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnSearchSW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxRegionsSW;
        private System.Windows.Forms.NumericUpDown numericUpDownEventAgeLimit;
        private System.Windows.Forms.Label labelEventsAgeLimit;
        private System.Windows.Forms.TextBox tbNewEventsName;
        private System.Windows.Forms.TextBox tbNewEventsNumber;
        private System.Windows.Forms.Label lblNewEventsName;
        private System.Windows.Forms.Label lblNewEventsNumber;
        private System.Windows.Forms.GroupBox groupBoxPlayer;
        private System.Windows.Forms.GroupBox groupBoxEvent;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPlayerAgeSW;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelPlayerGenderSW;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelPlayerFullNameSW;
        private System.Windows.Forms.Label labelPlayerNumberSW;
        private System.Windows.Forms.DataGridView dataGridViewEventsBelongToPlayer;
        private System.Windows.Forms.BindingSource bindingSourceSearchedPlayers;
    }
}