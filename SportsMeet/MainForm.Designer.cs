using SportsMeet.Data;
using SportsMeet.Models;
using SportsMeet.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SportsMeet
{
    public partial class MainForm : Form
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
            this.deletePlayer = new System.Windows.Forms.Button();
            this.lblAgeUnderValue = new System.Windows.Forms.Label();
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourcePlayers = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.tbPlayerSearch = new System.Windows.Forms.TextBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.cbxDistrict = new System.Windows.Forms.ComboBox();
            this.bindingSourceDistricts = new System.Windows.Forms.BindingSource(this.components);
            this.cbxEvent = new System.Windows.Forms.ComboBox();
            this.tbEventNumber = new System.Windows.Forms.TextBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblEventNumber = new System.Windows.Forms.Label();
            this.lblAgeUnder = new System.Windows.Forms.Label();
            this.cbxSchool = new System.Windows.Forms.ComboBox();
            this.bindingSourceSchools = new System.Windows.Forms.BindingSource(this.components);
            this.lblSchool = new System.Windows.Forms.Label();
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
            this.tbEvents = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbNewEventsName = new System.Windows.Forms.TextBox();
            this.tbNewEventsNumber = new System.Windows.Forms.TextBox();
            this.lblNewEventsName = new System.Windows.Forms.Label();
            this.lblNewEventsNumber = new System.Windows.Forms.Label();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.tbSchool = new System.Windows.Forms.TabPage();
            this.cbxNewSchoolsDistrict = new System.Windows.Forms.ComboBox();
            this.tbNewSchoolsName = new System.Windows.Forms.TextBox();
            this.lblNewSchoolsDistrict = new System.Windows.Forms.Label();
            this.lblNewSchoolsName = new System.Windows.Forms.Label();
            this.btnAddSchool = new System.Windows.Forms.Button();
            this.tbFilterByPlayer = new System.Windows.Forms.TabPage();
            this.btnFilterByPlayerFilter = new System.Windows.Forms.Button();
            this.lblFilterByPlayerEvents = new System.Windows.Forms.Label();
            this.lblFilterByPlayerDistrict = new System.Windows.Forms.Label();
            this.lblFilterByPlayerSchool = new System.Windows.Forms.Label();
            this.lblFilerByPlayerName = new System.Windows.Forms.Label();
            this.tbPlayersNumber = new System.Windows.Forms.TextBox();
            this.lblFilterByPlayerPlayerNumber = new System.Windows.Forms.Label();
            this.tbFilterByEvent = new System.Windows.Forms.TabPage();
            this.btnFilterByEventFilter = new System.Windows.Forms.Button();
            this.lblFIlterByEventPlayers = new System.Windows.Forms.Label();
            this.tbFilterByEventEventNumber = new System.Windows.Forms.TextBox();
            this.lblFilterByEventEventNumber = new System.Windows.Forms.Label();
            this.imageListForTabs = new System.Windows.Forms.ImageList(this.components);
            this.toolStripStatusBar = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelTotalPlayerCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelSchools = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelSchoolCount = new System.Windows.Forms.ToolStripLabel();
            this.tcMainForm.SuspendLayout();
            this.tbPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDistricts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSchools)).BeginInit();
            this.tbEvents.SuspendLayout();
            this.tbSchool.SuspendLayout();
            this.tbFilterByPlayer.SuspendLayout();
            this.tbFilterByEvent.SuspendLayout();
            this.toolStripStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMainForm
            // 
            this.tcMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMainForm.Controls.Add(this.tbPlayers);
            this.tcMainForm.Controls.Add(this.tbEvents);
            this.tcMainForm.Controls.Add(this.tbSchool);
            this.tcMainForm.Controls.Add(this.tbFilterByPlayer);
            this.tcMainForm.Controls.Add(this.tbFilterByEvent);
            this.tcMainForm.ImageList = this.imageListForTabs;
            this.tcMainForm.Location = new System.Drawing.Point(0, 9);
            this.tcMainForm.Margin = new System.Windows.Forms.Padding(0);
            this.tcMainForm.Name = "tcMainForm";
            this.tcMainForm.Padding = new System.Drawing.Point(0, 0);
            this.tcMainForm.SelectedIndex = 0;
            this.tcMainForm.Size = new System.Drawing.Size(1118, 567);
            this.tcMainForm.TabIndex = 0;
            // 
            // tbPlayers
            // 
            this.tbPlayers.Controls.Add(this.deletePlayer);
            this.tbPlayers.Controls.Add(this.lblAgeUnderValue);
            this.tbPlayers.Controls.Add(this.dataGridViewPlayers);
            this.tbPlayers.Controls.Add(this.numericUpDownAge);
            this.tbPlayers.Controls.Add(this.tbPlayerSearch);
            this.tbPlayers.Controls.Add(this.lblDistrict);
            this.tbPlayers.Controls.Add(this.cbxDistrict);
            this.tbPlayers.Controls.Add(this.cbxEvent);
            this.tbPlayers.Controls.Add(this.tbEventNumber);
            this.tbPlayers.Controls.Add(this.lblEvent);
            this.tbPlayers.Controls.Add(this.lblEventNumber);
            this.tbPlayers.Controls.Add(this.lblAgeUnder);
            this.tbPlayers.Controls.Add(this.cbxSchool);
            this.tbPlayers.Controls.Add(this.lblSchool);
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
            this.tbPlayers.ImageIndex = 1;
            this.tbPlayers.Location = new System.Drawing.Point(4, 29);
            this.tbPlayers.Margin = new System.Windows.Forms.Padding(6);
            this.tbPlayers.Name = "tbPlayers";
            this.tbPlayers.Padding = new System.Windows.Forms.Padding(6);
            this.tbPlayers.Size = new System.Drawing.Size(1110, 534);
            this.tbPlayers.TabIndex = 1;
            this.tbPlayers.Text = "Players";
            this.tbPlayers.UseVisualStyleBackColor = true;
            this.tbPlayers.Click += new System.EventHandler(this.tbPlayers_Click);
            // 
            // deletePlayer
            // 
            this.deletePlayer.Location = new System.Drawing.Point(188, 430);
            this.deletePlayer.Name = "deletePlayer";
            this.deletePlayer.Size = new System.Drawing.Size(164, 54);
            this.deletePlayer.TabIndex = 29;
            this.deletePlayer.Text = "Delete";
            this.deletePlayer.UseVisualStyleBackColor = true;
            this.deletePlayer.Click += new System.EventHandler(this.deletePlayer_Click);
            // 
            // lblAgeUnderValue
            // 
            this.lblAgeUnderValue.AutoSize = true;
            this.lblAgeUnderValue.Location = new System.Drawing.Point(183, 355);
            this.lblAgeUnderValue.Name = "lblAgeUnderValue";
            this.lblAgeUnderValue.Size = new System.Drawing.Size(18, 20);
            this.lblAgeUnderValue.TabIndex = 28;
            this.lblAgeUnderValue.Text = "0";
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.AllowUserToAddRows = false;
            this.dataGridViewPlayers.AllowUserToDeleteRows = false;
            this.dataGridViewPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPlayers.AutoGenerateColumns = false;
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.schoolIdDataGridViewTextBoxColumn});
            this.dataGridViewPlayers.DataSource = this.bindingSourcePlayers;
            this.dataGridViewPlayers.Location = new System.Drawing.Point(453, 90);
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.RowTemplate.Height = 33;
            this.dataGridViewPlayers.Size = new System.Drawing.Size(647, 434);
            this.dataGridViewPlayers.TabIndex = 27;
            this.dataGridViewPlayers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlayers_CellContentClick);
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // schoolIdDataGridViewTextBoxColumn
            // 
            this.schoolIdDataGridViewTextBoxColumn.DataPropertyName = "SchoolId";
            this.schoolIdDataGridViewTextBoxColumn.HeaderText = "SchoolId";
            this.schoolIdDataGridViewTextBoxColumn.Name = "schoolIdDataGridViewTextBoxColumn";
            // 
            // bindingSourcePlayers
            // 
            this.bindingSourcePlayers.DataSource = typeof(SportsMeet.Models.Player);
            this.bindingSourcePlayers.Sort = "Number";
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(183, 176);
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownAge.TabIndex = 26;
            // 
            // tbPlayerSearch
            // 
            this.tbPlayerSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlayerSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbPlayerSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbPlayerSearch.Location = new System.Drawing.Point(453, 43);
            this.tbPlayerSearch.Name = "tbPlayerSearch";
            this.tbPlayerSearch.Size = new System.Drawing.Size(647, 26);
            this.tbPlayerSearch.TabIndex = 25;
            this.tbPlayerSearch.TextChanged += new System.EventHandler(this.tbPlayerSearch_TextChanged);
            this.tbPlayerSearch.Enter += new System.EventHandler(this.tbPlayerSearch_Enter);
            this.tbPlayerSearch.Leave += new System.EventHandler(this.tbPlayerSearch_Leave);
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Location = new System.Drawing.Point(21, 249);
            this.lblDistrict.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(58, 20);
            this.lblDistrict.TabIndex = 24;
            this.lblDistrict.Text = "District";
            // 
            // cbxDistrict
            // 
            this.cbxDistrict.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxDistrict.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxDistrict.DataSource = this.bindingSourceDistricts;
            this.cbxDistrict.DisplayMember = "Name";
            this.cbxDistrict.FormattingEnabled = true;
            this.cbxDistrict.Location = new System.Drawing.Point(183, 245);
            this.cbxDistrict.Margin = new System.Windows.Forms.Padding(6);
            this.cbxDistrict.Name = "cbxDistrict";
            this.cbxDistrict.Size = new System.Drawing.Size(180, 28);
            this.cbxDistrict.TabIndex = 23;
            // 
            // bindingSourceDistricts
            // 
            this.bindingSourceDistricts.DataSource = typeof(SportsMeet.Models.District);
            // 
            // cbxEvent
            // 
            this.cbxEvent.FormattingEnabled = true;
            this.cbxEvent.Location = new System.Drawing.Point(183, 280);
            this.cbxEvent.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEvent.Name = "cbxEvent";
            this.cbxEvent.Size = new System.Drawing.Size(180, 28);
            this.cbxEvent.TabIndex = 22;
            // 
            // tbEventNumber
            // 
            this.tbEventNumber.Location = new System.Drawing.Point(183, 316);
            this.tbEventNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbEventNumber.Name = "tbEventNumber";
            this.tbEventNumber.Size = new System.Drawing.Size(148, 26);
            this.tbEventNumber.TabIndex = 21;
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(21, 319);
            this.lblEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(50, 20);
            this.lblEvent.TabIndex = 20;
            this.lblEvent.Text = "Event";
            // 
            // lblEventNumber
            // 
            this.lblEventNumber.AutoSize = true;
            this.lblEventNumber.Location = new System.Drawing.Point(21, 284);
            this.lblEventNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventNumber.Name = "lblEventNumber";
            this.lblEventNumber.Size = new System.Drawing.Size(110, 20);
            this.lblEventNumber.TabIndex = 19;
            this.lblEventNumber.Text = "Event Number";
            // 
            // lblAgeUnder
            // 
            this.lblAgeUnder.AutoSize = true;
            this.lblAgeUnder.Location = new System.Drawing.Point(21, 354);
            this.lblAgeUnder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgeUnder.Name = "lblAgeUnder";
            this.lblAgeUnder.Size = new System.Drawing.Size(86, 20);
            this.lblAgeUnder.TabIndex = 17;
            this.lblAgeUnder.Text = "Age Under";
            // 
            // cbxSchool
            // 
            this.cbxSchool.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSchool.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSchool.DataSource = this.bindingSourceSchools;
            this.cbxSchool.DisplayMember = "Name";
            this.cbxSchool.FormattingEnabled = true;
            this.cbxSchool.Location = new System.Drawing.Point(183, 140);
            this.cbxSchool.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSchool.Name = "cbxSchool";
            this.cbxSchool.Size = new System.Drawing.Size(180, 28);
            this.cbxSchool.TabIndex = 16;
            // 
            // bindingSourceSchools
            // 
            this.bindingSourceSchools.DataSource = typeof(SportsMeet.Models.School);
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Location = new System.Drawing.Point(21, 144);
            this.lblSchool.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(58, 20);
            this.lblSchool.TabIndex = 15;
            this.lblSchool.Text = "School";
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxGender.Location = new System.Drawing.Point(183, 210);
            this.cbxGender.Margin = new System.Windows.Forms.Padding(4);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(120, 28);
            this.cbxGender.TabIndex = 11;
            this.cbxGender.Text = "Male";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(21, 214);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 20);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(21, 179);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 20);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Age";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(21, 109);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 20);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(21, 74);
            this.lbFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(86, 20);
            this.lbFirstName.TabIndex = 7;
            this.lbFirstName.Text = "First Name";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(183, 106);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(212, 26);
            this.tbLastName.TabIndex = 4;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(183, 71);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(212, 26);
            this.tbFirstName.TabIndex = 3;
            // 
            // lblPlayerNumber
            // 
            this.lblPlayerNumber.AutoSize = true;
            this.lblPlayerNumber.Location = new System.Drawing.Point(21, 39);
            this.lblPlayerNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerNumber.Name = "lblPlayerNumber";
            this.lblPlayerNumber.Size = new System.Drawing.Size(112, 20);
            this.lblPlayerNumber.TabIndex = 2;
            this.lblPlayerNumber.Text = "Player Number";
            // 
            // tbPlayerNumber
            // 
            this.tbPlayerNumber.Location = new System.Drawing.Point(183, 36);
            this.tbPlayerNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbPlayerNumber.Name = "tbPlayerNumber";
            this.tbPlayerNumber.Size = new System.Drawing.Size(212, 26);
            this.tbPlayerNumber.TabIndex = 1;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(11, 430);
            this.btnAddPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(164, 54);
            this.btnAddPlayer.TabIndex = 0;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // tbEvents
            // 
            this.tbEvents.AutoScroll = true;
            this.tbEvents.Controls.Add(this.label1);
            this.tbEvents.Controls.Add(this.textBox1);
            this.tbEvents.Controls.Add(this.tbNewEventsName);
            this.tbEvents.Controls.Add(this.tbNewEventsNumber);
            this.tbEvents.Controls.Add(this.lblNewEventsName);
            this.tbEvents.Controls.Add(this.lblNewEventsNumber);
            this.tbEvents.Controls.Add(this.btnAddEvent);
            this.tbEvents.ImageIndex = 0;
            this.tbEvents.Location = new System.Drawing.Point(4, 29);
            this.tbEvents.Margin = new System.Windows.Forms.Padding(0);
            this.tbEvents.Name = "tbEvents";
            this.tbEvents.Size = new System.Drawing.Size(1110, 534);
            this.tbEvents.TabIndex = 0;
            this.tbEvents.Text = "Events";
            this.tbEvents.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Age Under";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 5;
            // 
            // tbNewEventsName
            // 
            this.tbNewEventsName.Location = new System.Drawing.Point(240, 58);
            this.tbNewEventsName.Margin = new System.Windows.Forms.Padding(6);
            this.tbNewEventsName.Name = "tbNewEventsName";
            this.tbNewEventsName.Size = new System.Drawing.Size(196, 26);
            this.tbNewEventsName.TabIndex = 4;
            // 
            // tbNewEventsNumber
            // 
            this.tbNewEventsNumber.Location = new System.Drawing.Point(240, 15);
            this.tbNewEventsNumber.Margin = new System.Windows.Forms.Padding(6);
            this.tbNewEventsNumber.Name = "tbNewEventsNumber";
            this.tbNewEventsNumber.Size = new System.Drawing.Size(196, 26);
            this.tbNewEventsNumber.TabIndex = 3;
            // 
            // lblNewEventsName
            // 
            this.lblNewEventsName.AutoSize = true;
            this.lblNewEventsName.Location = new System.Drawing.Point(7, 58);
            this.lblNewEventsName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNewEventsName.Name = "lblNewEventsName";
            this.lblNewEventsName.Size = new System.Drawing.Size(142, 20);
            this.lblNewEventsName.TabIndex = 2;
            this.lblNewEventsName.Text = "New Event\'s Name";
            // 
            // lblNewEventsNumber
            // 
            this.lblNewEventsNumber.AutoSize = true;
            this.lblNewEventsNumber.Location = new System.Drawing.Point(7, 15);
            this.lblNewEventsNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNewEventsNumber.Name = "lblNewEventsNumber";
            this.lblNewEventsNumber.Size = new System.Drawing.Size(156, 20);
            this.lblNewEventsNumber.TabIndex = 1;
            this.lblNewEventsNumber.Text = "New Event\'s Number";
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(240, 199);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(150, 44);
            this.btnAddEvent.TabIndex = 0;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            // 
            // tbSchool
            // 
            this.tbSchool.Controls.Add(this.cbxNewSchoolsDistrict);
            this.tbSchool.Controls.Add(this.tbNewSchoolsName);
            this.tbSchool.Controls.Add(this.lblNewSchoolsDistrict);
            this.tbSchool.Controls.Add(this.lblNewSchoolsName);
            this.tbSchool.Controls.Add(this.btnAddSchool);
            this.tbSchool.ImageIndex = 2;
            this.tbSchool.Location = new System.Drawing.Point(4, 29);
            this.tbSchool.Margin = new System.Windows.Forms.Padding(4);
            this.tbSchool.Name = "tbSchool";
            this.tbSchool.Size = new System.Drawing.Size(1110, 534);
            this.tbSchool.TabIndex = 2;
            this.tbSchool.Text = "School";
            this.tbSchool.UseVisualStyleBackColor = true;
            // 
            // cbxNewSchoolsDistrict
            // 
            this.cbxNewSchoolsDistrict.FormattingEnabled = true;
            this.cbxNewSchoolsDistrict.Items.AddRange(new object[] {
            "Matara",
            "Galle",
            "Hambanthota"});
            this.cbxNewSchoolsDistrict.Location = new System.Drawing.Point(205, 86);
            this.cbxNewSchoolsDistrict.Margin = new System.Windows.Forms.Padding(6);
            this.cbxNewSchoolsDistrict.Name = "cbxNewSchoolsDistrict";
            this.cbxNewSchoolsDistrict.Size = new System.Drawing.Size(196, 28);
            this.cbxNewSchoolsDistrict.TabIndex = 9;
            // 
            // tbNewSchoolsName
            // 
            this.tbNewSchoolsName.Location = new System.Drawing.Point(205, 32);
            this.tbNewSchoolsName.Margin = new System.Windows.Forms.Padding(6);
            this.tbNewSchoolsName.Name = "tbNewSchoolsName";
            this.tbNewSchoolsName.Size = new System.Drawing.Size(196, 26);
            this.tbNewSchoolsName.TabIndex = 8;
            // 
            // lblNewSchoolsDistrict
            // 
            this.lblNewSchoolsDistrict.AutoSize = true;
            this.lblNewSchoolsDistrict.Location = new System.Drawing.Point(31, 89);
            this.lblNewSchoolsDistrict.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNewSchoolsDistrict.Name = "lblNewSchoolsDistrict";
            this.lblNewSchoolsDistrict.Size = new System.Drawing.Size(157, 20);
            this.lblNewSchoolsDistrict.TabIndex = 7;
            this.lblNewSchoolsDistrict.Text = "New School\'s District";
            // 
            // lblNewSchoolsName
            // 
            this.lblNewSchoolsName.AutoSize = true;
            this.lblNewSchoolsName.Location = new System.Drawing.Point(31, 35);
            this.lblNewSchoolsName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNewSchoolsName.Name = "lblNewSchoolsName";
            this.lblNewSchoolsName.Size = new System.Drawing.Size(150, 20);
            this.lblNewSchoolsName.TabIndex = 6;
            this.lblNewSchoolsName.Text = "New School\'s Name";
            // 
            // btnAddSchool
            // 
            this.btnAddSchool.Location = new System.Drawing.Point(158, 151);
            this.btnAddSchool.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddSchool.Name = "btnAddSchool";
            this.btnAddSchool.Size = new System.Drawing.Size(150, 44);
            this.btnAddSchool.TabIndex = 5;
            this.btnAddSchool.Text = "Add School";
            this.btnAddSchool.UseVisualStyleBackColor = true;
            this.btnAddSchool.Click += new System.EventHandler(this.btnAddSchool_Click);
            // 
            // tbFilterByPlayer
            // 
            this.tbFilterByPlayer.Controls.Add(this.btnFilterByPlayerFilter);
            this.tbFilterByPlayer.Controls.Add(this.lblFilterByPlayerEvents);
            this.tbFilterByPlayer.Controls.Add(this.lblFilterByPlayerDistrict);
            this.tbFilterByPlayer.Controls.Add(this.lblFilterByPlayerSchool);
            this.tbFilterByPlayer.Controls.Add(this.lblFilerByPlayerName);
            this.tbFilterByPlayer.Controls.Add(this.tbPlayersNumber);
            this.tbFilterByPlayer.Controls.Add(this.lblFilterByPlayerPlayerNumber);
            this.tbFilterByPlayer.Location = new System.Drawing.Point(4, 29);
            this.tbFilterByPlayer.Margin = new System.Windows.Forms.Padding(6);
            this.tbFilterByPlayer.Name = "tbFilterByPlayer";
            this.tbFilterByPlayer.Padding = new System.Windows.Forms.Padding(6);
            this.tbFilterByPlayer.Size = new System.Drawing.Size(1110, 534);
            this.tbFilterByPlayer.TabIndex = 3;
            this.tbFilterByPlayer.Text = "Filter By Player";
            this.tbFilterByPlayer.UseVisualStyleBackColor = true;
            // 
            // btnFilterByPlayerFilter
            // 
            this.btnFilterByPlayerFilter.Location = new System.Drawing.Point(395, 102);
            this.btnFilterByPlayerFilter.Name = "btnFilterByPlayerFilter";
            this.btnFilterByPlayerFilter.Size = new System.Drawing.Size(110, 29);
            this.btnFilterByPlayerFilter.TabIndex = 5;
            this.btnFilterByPlayerFilter.Text = "Filter";
            this.btnFilterByPlayerFilter.UseVisualStyleBackColor = true;
            // 
            // lblFilterByPlayerEvents
            // 
            this.lblFilterByPlayerEvents.AutoSize = true;
            this.lblFilterByPlayerEvents.Location = new System.Drawing.Point(60, 246);
            this.lblFilterByPlayerEvents.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFilterByPlayerEvents.Name = "lblFilterByPlayerEvents";
            this.lblFilterByPlayerEvents.Size = new System.Drawing.Size(58, 20);
            this.lblFilterByPlayerEvents.TabIndex = 1;
            this.lblFilterByPlayerEvents.Text = "Events";
            // 
            // lblFilterByPlayerDistrict
            // 
            this.lblFilterByPlayerDistrict.AutoSize = true;
            this.lblFilterByPlayerDistrict.Location = new System.Drawing.Point(60, 214);
            this.lblFilterByPlayerDistrict.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFilterByPlayerDistrict.Name = "lblFilterByPlayerDistrict";
            this.lblFilterByPlayerDistrict.Size = new System.Drawing.Size(58, 20);
            this.lblFilterByPlayerDistrict.TabIndex = 4;
            this.lblFilterByPlayerDistrict.Text = "District";
            // 
            // lblFilterByPlayerSchool
            // 
            this.lblFilterByPlayerSchool.AutoSize = true;
            this.lblFilterByPlayerSchool.Location = new System.Drawing.Point(60, 181);
            this.lblFilterByPlayerSchool.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFilterByPlayerSchool.Name = "lblFilterByPlayerSchool";
            this.lblFilterByPlayerSchool.Size = new System.Drawing.Size(58, 20);
            this.lblFilterByPlayerSchool.TabIndex = 3;
            this.lblFilterByPlayerSchool.Text = "School";
            // 
            // lblFilerByPlayerName
            // 
            this.lblFilerByPlayerName.AutoSize = true;
            this.lblFilerByPlayerName.Location = new System.Drawing.Point(60, 145);
            this.lblFilerByPlayerName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFilerByPlayerName.Name = "lblFilerByPlayerName";
            this.lblFilerByPlayerName.Size = new System.Drawing.Size(51, 20);
            this.lblFilerByPlayerName.TabIndex = 2;
            this.lblFilerByPlayerName.Text = "Name";
            // 
            // tbPlayersNumber
            // 
            this.tbPlayersNumber.Location = new System.Drawing.Point(247, 67);
            this.tbPlayersNumber.Margin = new System.Windows.Forms.Padding(6);
            this.tbPlayersNumber.Name = "tbPlayersNumber";
            this.tbPlayersNumber.Size = new System.Drawing.Size(196, 26);
            this.tbPlayersNumber.TabIndex = 1;
            // 
            // lblFilterByPlayerPlayerNumber
            // 
            this.lblFilterByPlayerPlayerNumber.AutoSize = true;
            this.lblFilterByPlayerPlayerNumber.Location = new System.Drawing.Point(60, 73);
            this.lblFilterByPlayerPlayerNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFilterByPlayerPlayerNumber.Name = "lblFilterByPlayerPlayerNumber";
            this.lblFilterByPlayerPlayerNumber.Size = new System.Drawing.Size(112, 20);
            this.lblFilterByPlayerPlayerNumber.TabIndex = 0;
            this.lblFilterByPlayerPlayerNumber.Text = "Player Number";
            // 
            // tbFilterByEvent
            // 
            this.tbFilterByEvent.Controls.Add(this.btnFilterByEventFilter);
            this.tbFilterByEvent.Controls.Add(this.lblFIlterByEventPlayers);
            this.tbFilterByEvent.Controls.Add(this.tbFilterByEventEventNumber);
            this.tbFilterByEvent.Controls.Add(this.lblFilterByEventEventNumber);
            this.tbFilterByEvent.Location = new System.Drawing.Point(4, 29);
            this.tbFilterByEvent.Margin = new System.Windows.Forms.Padding(6);
            this.tbFilterByEvent.Name = "tbFilterByEvent";
            this.tbFilterByEvent.Padding = new System.Windows.Forms.Padding(6);
            this.tbFilterByEvent.Size = new System.Drawing.Size(1110, 534);
            this.tbFilterByEvent.TabIndex = 4;
            this.tbFilterByEvent.Text = "Filter By Event";
            this.tbFilterByEvent.UseVisualStyleBackColor = true;
            // 
            // btnFilterByEventFilter
            // 
            this.btnFilterByEventFilter.Location = new System.Drawing.Point(351, 106);
            this.btnFilterByEventFilter.Name = "btnFilterByEventFilter";
            this.btnFilterByEventFilter.Size = new System.Drawing.Size(82, 28);
            this.btnFilterByEventFilter.TabIndex = 3;
            this.btnFilterByEventFilter.Text = "Filter";
            this.btnFilterByEventFilter.UseVisualStyleBackColor = true;
            // 
            // lblFIlterByEventPlayers
            // 
            this.lblFIlterByEventPlayers.AutoSize = true;
            this.lblFIlterByEventPlayers.Location = new System.Drawing.Point(89, 141);
            this.lblFIlterByEventPlayers.Name = "lblFIlterByEventPlayers";
            this.lblFIlterByEventPlayers.Size = new System.Drawing.Size(60, 20);
            this.lblFIlterByEventPlayers.TabIndex = 2;
            this.lblFIlterByEventPlayers.Text = "Players";
            // 
            // tbFilterByEventEventNumber
            // 
            this.tbFilterByEventEventNumber.Location = new System.Drawing.Point(253, 74);
            this.tbFilterByEventEventNumber.Name = "tbFilterByEventEventNumber";
            this.tbFilterByEventEventNumber.Size = new System.Drawing.Size(122, 26);
            this.tbFilterByEventEventNumber.TabIndex = 1;
            // 
            // lblFilterByEventEventNumber
            // 
            this.lblFilterByEventEventNumber.AutoSize = true;
            this.lblFilterByEventEventNumber.Location = new System.Drawing.Point(89, 80);
            this.lblFilterByEventEventNumber.Name = "lblFilterByEventEventNumber";
            this.lblFilterByEventEventNumber.Size = new System.Drawing.Size(110, 20);
            this.lblFilterByEventEventNumber.TabIndex = 0;
            this.lblFilterByEventEventNumber.Text = "Event Number";
            // 
            // imageListForTabs
            // 
            this.imageListForTabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListForTabs.ImageStream")));
            this.imageListForTabs.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListForTabs.Images.SetKeyName(0, "Icons8-Windows-8-Sports-Football-2.ico");
            this.imageListForTabs.Images.SetKeyName(1, "Icons8-Windows-8-Sports-Running-Man.ico");
            this.imageListForTabs.Images.SetKeyName(2, "Icons8-Windows-8-Science-School.ico");
            // 
            // toolStripStatusBar
            // 
            this.toolStripStatusBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripStatusBar.AutoSize = false;
            this.toolStripStatusBar.CanOverflow = false;
            this.toolStripStatusBar.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripStatusBar.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripStatusBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabelTotalPlayerCount,
            this.toolStripButtonAbout,
            this.toolStripLabelSchools,
            this.toolStripLabelSchoolCount});
            this.toolStripStatusBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripStatusBar.Location = new System.Drawing.Point(8, 576);
            this.toolStripStatusBar.Name = "toolStripStatusBar";
            this.toolStripStatusBar.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripStatusBar.Size = new System.Drawing.Size(1110, 45);
            this.toolStripStatusBar.Stretch = true;
            this.toolStripStatusBar.TabIndex = 1;
            this.toolStripStatusBar.Text = "toolStrip";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripLabel1.Size = new System.Drawing.Size(118, 42);
            this.toolStripLabel1.Text = "Total Players :";
            // 
            // toolStripLabelTotalPlayerCount
            // 
            this.toolStripLabelTotalPlayerCount.Name = "toolStripLabelTotalPlayerCount";
            this.toolStripLabelTotalPlayerCount.Size = new System.Drawing.Size(22, 42);
            this.toolStripLabelTotalPlayerCount.Text = "0";
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(66, 42);
            this.toolStripButtonAbout.Text = "About";
            this.toolStripButtonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // toolStripLabelSchools
            // 
            this.toolStripLabelSchools.Name = "toolStripLabelSchools";
            this.toolStripLabelSchools.Size = new System.Drawing.Size(125, 42);
            this.toolStripLabelSchools.Text = "Total Schools :";
            // 
            // toolStripLabelSchoolCount
            // 
            this.toolStripLabelSchoolCount.Name = "toolStripLabelSchoolCount";
            this.toolStripLabelSchoolCount.Size = new System.Drawing.Size(22, 42);
            this.toolStripLabelSchoolCount.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1119, 630);
            this.Controls.Add(this.toolStripStatusBar);
            this.Controls.Add(this.tcMainForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Sports Meet";
            this.tcMainForm.ResumeLayout(false);
            this.tbPlayers.ResumeLayout(false);
            this.tbPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDistricts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSchools)).EndInit();
            this.tbEvents.ResumeLayout(false);
            this.tbEvents.PerformLayout();
            this.tbSchool.ResumeLayout(false);
            this.tbSchool.PerformLayout();
            this.tbFilterByPlayer.ResumeLayout(false);
            this.tbFilterByPlayer.PerformLayout();
            this.tbFilterByEvent.ResumeLayout(false);
            this.tbFilterByEvent.PerformLayout();
            this.toolStripStatusBar.ResumeLayout(false);
            this.toolStripStatusBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMainForm;
        private System.Windows.Forms.TabPage tbEvents;
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
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.ComboBox cbxSchool;
        private System.Windows.Forms.Label lblAgeUnder;
        private System.Windows.Forms.TabPage tbSchool;
        private System.Windows.Forms.ComboBox cbxEvent;
        private System.Windows.Forms.TextBox tbEventNumber;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblEventNumber;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.ComboBox cbxDistrict;
        private System.Windows.Forms.TextBox tbNewEventsName;
        private System.Windows.Forms.TextBox tbNewEventsNumber;
        private System.Windows.Forms.Label lblNewEventsName;
        private System.Windows.Forms.Label lblNewEventsNumber;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.ComboBox cbxNewSchoolsDistrict;
        private System.Windows.Forms.TextBox tbNewSchoolsName;
        private System.Windows.Forms.Label lblNewSchoolsDistrict;
        private System.Windows.Forms.Label lblNewSchoolsName;
        private System.Windows.Forms.Button btnAddSchool;
        private System.Windows.Forms.TabPage tbFilterByPlayer;
        private System.Windows.Forms.TabPage tbFilterByEvent;
        private System.Windows.Forms.Label lblFilterByPlayerDistrict;
        private System.Windows.Forms.Label lblFilterByPlayerSchool;
        private System.Windows.Forms.Label lblFilerByPlayerName;
        private System.Windows.Forms.TextBox tbPlayersNumber;
        private System.Windows.Forms.Label lblFilterByPlayerPlayerNumber;
        private System.Windows.Forms.Label lblFilterByPlayerEvents;
        private ToolStrip toolStripStatusBar;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabelTotalPlayerCount;
        private ToolStripButton toolStripButtonAbout;
        private NumericUpDown numericUpDownAge;
        private Label label1;
        private TextBox textBox1;
        private TextBox tbPlayerSearch;
        private DataGridView dataGridViewPlayers;
        private Label lblAgeUnderValue;
        private Button deletePlayer;
        private ImageList imageListForTabs;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn schoolIdDataGridViewTextBoxColumn;
        private BindingSource bindingSourcePlayers;
        private BindingSource bindingSourceSchools;
        private ToolStripLabel toolStripLabelSchools;
        private ToolStripLabel toolStripLabelSchoolCount;
        private BindingSource bindingSourceDistricts;
        private Button btnFilterByPlayerFilter;
        private Button btnFilterByEventFilter;
        private Label lblFIlterByEventPlayers;
        private TextBox tbFilterByEventEventNumber;
        private Label lblFilterByEventEventNumber;
    }
    
}
