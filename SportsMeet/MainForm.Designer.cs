using SportsMeet.Data;
using SportsMeet.Models;
using SportsMeet.Properties;
using SportsMeet.View;
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
            this.tbSchool = new System.Windows.Forms.TabPage();
            this.dataGridViewAllSchools = new System.Windows.Forms.DataGridView();
            this.tbNewSchoolName = new System.Windows.Forms.TextBox();
            this.lblNewSchoolName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceSchools = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteSchool = new System.Windows.Forms.Button();
            this.btnEditSchool = new System.Windows.Forms.Button();
            this.tbSchoolName = new System.Windows.Forms.TextBox();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.btnAddSchool = new System.Windows.Forms.Button();
            this.tbEvents = new System.Windows.Forms.TabPage();
            this.dataGridViewAllEvents = new System.Windows.Forms.DataGridView();
            this.bindingSourceAllEvents = new System.Windows.Forms.BindingSource(this.components);
            this.btnEeventsTabAddPlayers = new System.Windows.Forms.Button();
            this.btnEventEdit = new System.Windows.Forms.Button();
            this.btnEvetSearch = new System.Windows.Forms.Button();
            this.btnEventDelete = new System.Windows.Forms.Button();
            this.comboBoxEventsSex = new System.Windows.Forms.ComboBox();
            this.labelEventsSex = new System.Windows.Forms.Label();
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.bindingSourceEvents = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDownEventAgeLimit = new System.Windows.Forms.NumericUpDown();
            this.labelEventsAgeLimit = new System.Windows.Forms.Label();
            this.tbNewEventsName = new System.Windows.Forms.TextBox();
            this.tbNewEventsNumber = new System.Windows.Forms.TextBox();
            this.lblNewEventsName = new System.Windows.Forms.Label();
            this.lblNewEventsNumber = new System.Windows.Forms.Label();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.tbPlayers = new System.Windows.Forms.TabPage();
            this.textBoxPlayerSearch = new System.Windows.Forms.TextBox();
            this.checkBoxDeleteSelection = new System.Windows.Forms.CheckBox();
            this.checkBoxLoadSelection = new System.Windows.Forms.CheckBox();
            this.checkBoxAddtoanEvent = new System.Windows.Forms.CheckBox();
            this.btnAddEventsToPlayer = new System.Windows.Forms.Button();
            this.btnPlayerEdit = new System.Windows.Forms.Button();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourcePlayers = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.cbxDistrict = new System.Windows.Forms.ComboBox();
            this.bindingSourceDistricts = new System.Windows.Forms.BindingSource(this.components);
            this.cbxSchool = new System.Windows.Forms.ComboBox();
            this.bindingSourceSchoolsFixed = new System.Windows.Forms.BindingSource(this.components);
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
            this.tbFilterByPlayer = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFilterByPlayerDistrictOutput = new System.Windows.Forms.Label();
            this.lblFilterByPlayerSchoolOutput = new System.Windows.Forms.Label();
            this.lblFilterByPlayerNameOutput = new System.Windows.Forms.Label();
            this.dataGridViewEventsOfPlaye = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceFilteredEventsOnPlayers = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridPlayerFiltering = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFilterByPlayerEvents = new System.Windows.Forms.Label();
            this.lblFilterByPlayerDistrict = new System.Windows.Forms.Label();
            this.lblFilterByPlayerSchool = new System.Windows.Forms.Label();
            this.lblFilerByPlayerName = new System.Windows.Forms.Label();
            this.tbFilterByPlayersNumber = new System.Windows.Forms.TextBox();
            this.tbFilterByEvent = new System.Windows.Forms.TabPage();
            this.dataGridViewFilteredPlayers = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceFilteredPlayersOnEvent = new System.Windows.Forms.BindingSource(this.components);
            this.btnFilterByEventFilter = new System.Windows.Forms.Button();
            this.lblFIlterByEventPlayers = new System.Windows.Forms.Label();
            this.tbFilterByEventEventNumber = new System.Windows.Forms.TextBox();
            this.lblFilterByEventEventNumber = new System.Windows.Forms.Label();
            this.reportTab = new System.Windows.Forms.TabPage();
            this.imageListForTabs = new System.Windows.Forms.ImageList(this.components);
            this.toolStripStatusBar = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelTotalPlayerCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelSchools = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelSchoolCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelTotalEvents = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.bindingSourceFilterByPlayerEvents = new System.Windows.Forms.BindingSource(this.components);
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTime = new System.Windows.Forms.Timer(this.components);
            this.bindingSourceAllSchools = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageLimitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tcMainForm.SuspendLayout();
            this.tbSchool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllSchools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSchools)).BeginInit();
            this.tbEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEventAgeLimit)).BeginInit();
            this.tbPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDistricts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSchoolsFixed)).BeginInit();
            this.tbFilterByPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventsOfPlaye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFilteredEventsOnPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlayerFiltering)).BeginInit();
            this.tbFilterByEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilteredPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFilteredPlayersOnEvent)).BeginInit();
            this.toolStripStatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFilterByPlayerEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllSchools)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMainForm
            // 
            this.tcMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMainForm.Controls.Add(this.tbSchool);
            this.tcMainForm.Controls.Add(this.tbEvents);
            this.tcMainForm.Controls.Add(this.tbPlayers);
            this.tcMainForm.Controls.Add(this.tbFilterByPlayer);
            this.tcMainForm.Controls.Add(this.tbFilterByEvent);
            this.tcMainForm.Controls.Add(this.reportTab);
            this.tcMainForm.ImageList = this.imageListForTabs;
            this.tcMainForm.Location = new System.Drawing.Point(0, 9);
            this.tcMainForm.Margin = new System.Windows.Forms.Padding(0);
            this.tcMainForm.Name = "tcMainForm";
            this.tcMainForm.Padding = new System.Drawing.Point(0, 0);
            this.tcMainForm.SelectedIndex = 0;
            this.tcMainForm.Size = new System.Drawing.Size(1310, 758);
            this.tcMainForm.TabIndex = 0;
            this.tcMainForm.SelectedIndexChanged += new System.EventHandler(this.tcMainForm_SelectedIndexChanged);
            // 
            // tbSchool
            // 
            this.tbSchool.Controls.Add(this.tableLayoutPanel2);
            this.tbSchool.Controls.Add(this.tbNewSchoolName);
            this.tbSchool.Controls.Add(this.lblNewSchoolName);
            this.tbSchool.Controls.Add(this.btnDeleteSchool);
            this.tbSchool.Controls.Add(this.btnEditSchool);
            this.tbSchool.Controls.Add(this.tbSchoolName);
            this.tbSchool.Controls.Add(this.lblSchoolName);
            this.tbSchool.Controls.Add(this.btnAddSchool);
            this.tbSchool.ImageIndex = 2;
            this.tbSchool.Location = new System.Drawing.Point(4, 29);
            this.tbSchool.Margin = new System.Windows.Forms.Padding(4);
            this.tbSchool.Name = "tbSchool";
            this.tbSchool.Size = new System.Drawing.Size(1302, 725);
            this.tbSchool.TabIndex = 2;
            this.tbSchool.Text = "Schools";
            this.tbSchool.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAllSchools
            // 
            this.dataGridViewAllSchools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAllSchools.AutoGenerateColumns = false;
            this.dataGridViewAllSchools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllSchools.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn2});
            this.dataGridViewAllSchools.DataSource = this.bindingSourceAllSchools;
            this.dataGridViewAllSchools.Location = new System.Drawing.Point(491, 3);
            this.dataGridViewAllSchools.Name = "dataGridViewAllSchools";
            this.dataGridViewAllSchools.RowTemplate.Height = 28;
            this.dataGridViewAllSchools.Size = new System.Drawing.Size(482, 706);
            this.dataGridViewAllSchools.TabIndex = 13;
            // 
            // tbNewSchoolName
            // 
            this.tbNewSchoolName.Enabled = false;
            this.tbNewSchoolName.Location = new System.Drawing.Point(164, 45);
            this.tbNewSchoolName.Name = "tbNewSchoolName";
            this.tbNewSchoolName.Size = new System.Drawing.Size(139, 26);
            this.tbNewSchoolName.TabIndex = 12;
            this.tbNewSchoolName.TextChanged += new System.EventHandler(this.tbNewSchoolName_TextChanged);
            // 
            // lblNewSchoolName
            // 
            this.lblNewSchoolName.AutoSize = true;
            this.lblNewSchoolName.Location = new System.Drawing.Point(3, 38);
            this.lblNewSchoolName.Name = "lblNewSchoolName";
            this.lblNewSchoolName.Size = new System.Drawing.Size(139, 20);
            this.lblNewSchoolName.TabIndex = 11;
            this.lblNewSchoolName.Text = "New School Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.bindingSourceSchools;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(482, 706);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.TabStop = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // bindingSourceSchools
            // 
            this.bindingSourceSchools.DataSource = typeof(SportsMeet.Models.School);
            // 
            // btnDeleteSchool
            // 
            this.btnDeleteSchool.Location = new System.Drawing.Point(214, 99);
            this.btnDeleteSchool.Name = "btnDeleteSchool";
            this.btnDeleteSchool.Size = new System.Drawing.Size(68, 30);
            this.btnDeleteSchool.TabIndex = 9;
            this.btnDeleteSchool.TabStop = false;
            this.btnDeleteSchool.Text = "Delete";
            this.btnDeleteSchool.UseVisualStyleBackColor = true;
            this.btnDeleteSchool.Click += new System.EventHandler(this.btnDeleteSchool_Click);
            // 
            // btnEditSchool
            // 
            this.btnEditSchool.Enabled = false;
            this.btnEditSchool.Location = new System.Drawing.Point(125, 99);
            this.btnEditSchool.Name = "btnEditSchool";
            this.btnEditSchool.Size = new System.Drawing.Size(70, 30);
            this.btnEditSchool.TabIndex = 8;
            this.btnEditSchool.TabStop = false;
            this.btnEditSchool.Text = "Edit";
            this.btnEditSchool.UseVisualStyleBackColor = true;
            this.btnEditSchool.Click += new System.EventHandler(this.btnEditSchool_Click);
            // 
            // tbSchoolName
            // 
            this.tbSchoolName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbSchoolName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbSchoolName.Location = new System.Drawing.Point(164, 10);
            this.tbSchoolName.Margin = new System.Windows.Forms.Padding(6);
            this.tbSchoolName.Name = "tbSchoolName";
            this.tbSchoolName.Size = new System.Drawing.Size(139, 26);
            this.tbSchoolName.TabIndex = 0;
            this.tbSchoolName.TextChanged += new System.EventHandler(this.tbSchoolName_TextChanged);
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Location = new System.Drawing.Point(6, 10);
            this.lblSchoolName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(104, 20);
            this.lblSchoolName.TabIndex = 6;
            this.lblSchoolName.Text = "School Name";
            // 
            // btnAddSchool
            // 
            this.btnAddSchool.Location = new System.Drawing.Point(34, 99);
            this.btnAddSchool.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddSchool.Name = "btnAddSchool";
            this.btnAddSchool.Size = new System.Drawing.Size(70, 30);
            this.btnAddSchool.TabIndex = 1;
            this.btnAddSchool.Text = "Add";
            this.btnAddSchool.UseVisualStyleBackColor = true;
            this.btnAddSchool.Click += new System.EventHandler(this.btnAddSchool_Click);
            // 
            // tbEvents
            // 
            this.tbEvents.AutoScroll = true;
            this.tbEvents.Controls.Add(this.tableLayoutPanel1);
            this.tbEvents.Controls.Add(this.btnEeventsTabAddPlayers);
            this.tbEvents.Controls.Add(this.btnEventEdit);
            this.tbEvents.Controls.Add(this.btnEvetSearch);
            this.tbEvents.Controls.Add(this.btnEventDelete);
            this.tbEvents.Controls.Add(this.comboBoxEventsSex);
            this.tbEvents.Controls.Add(this.labelEventsSex);
            this.tbEvents.Controls.Add(this.numericUpDownEventAgeLimit);
            this.tbEvents.Controls.Add(this.labelEventsAgeLimit);
            this.tbEvents.Controls.Add(this.tbNewEventsName);
            this.tbEvents.Controls.Add(this.tbNewEventsNumber);
            this.tbEvents.Controls.Add(this.lblNewEventsName);
            this.tbEvents.Controls.Add(this.lblNewEventsNumber);
            this.tbEvents.Controls.Add(this.btnAddEvent);
            this.tbEvents.ImageIndex = 0;
            this.tbEvents.Location = new System.Drawing.Point(4, 29);
            this.tbEvents.Margin = new System.Windows.Forms.Padding(0);
            this.tbEvents.Name = "tbEvents";
            this.tbEvents.Size = new System.Drawing.Size(1302, 725);
            this.tbEvents.TabIndex = 0;
            this.tbEvents.Text = "Events";
            this.tbEvents.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAllEvents
            // 
            this.dataGridViewAllEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAllEvents.AutoGenerateColumns = false;
            this.dataGridViewAllEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn5,
            this.nameDataGridViewTextBoxColumn3,
            this.genderDataGridViewTextBoxColumn2,
            this.ageLimitDataGridViewTextBoxColumn1});
            this.dataGridViewAllEvents.DataSource = this.bindingSourceAllEvents;
            this.dataGridViewAllEvents.Location = new System.Drawing.Point(477, 3);
            this.dataGridViewAllEvents.Name = "dataGridViewAllEvents";
            this.dataGridViewAllEvents.RowTemplate.Height = 28;
            this.dataGridViewAllEvents.Size = new System.Drawing.Size(468, 713);
            this.dataGridViewAllEvents.TabIndex = 14;
            // 
            // bindingSourceAllEvents
            // 
            this.bindingSourceAllEvents.DataSource = typeof(SportsMeet.Models.Event);
            // 
            // btnEeventsTabAddPlayers
            // 
            this.btnEeventsTabAddPlayers.Location = new System.Drawing.Point(96, 281);
            this.btnEeventsTabAddPlayers.Margin = new System.Windows.Forms.Padding(6);
            this.btnEeventsTabAddPlayers.Name = "btnEeventsTabAddPlayers";
            this.btnEeventsTabAddPlayers.Size = new System.Drawing.Size(170, 28);
            this.btnEeventsTabAddPlayers.TabIndex = 13;
            this.btnEeventsTabAddPlayers.Text = "Event Players Management ";
            this.btnEeventsTabAddPlayers.UseVisualStyleBackColor = true;
            this.btnEeventsTabAddPlayers.Visible = false;
            // 
            // btnEventEdit
            // 
            this.btnEventEdit.Location = new System.Drawing.Point(172, 168);
            this.btnEventEdit.Margin = new System.Windows.Forms.Padding(6);
            this.btnEventEdit.Name = "btnEventEdit";
            this.btnEventEdit.Size = new System.Drawing.Size(66, 28);
            this.btnEventEdit.TabIndex = 12;
            this.btnEventEdit.Text = "Edit";
            this.btnEventEdit.UseVisualStyleBackColor = true;
            this.btnEventEdit.Click += new System.EventHandler(this.btnEventEdit_Click);
            // 
            // btnEvetSearch
            // 
            this.btnEvetSearch.Location = new System.Drawing.Point(96, 168);
            this.btnEvetSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnEvetSearch.Name = "btnEvetSearch";
            this.btnEvetSearch.Size = new System.Drawing.Size(66, 28);
            this.btnEvetSearch.TabIndex = 11;
            this.btnEvetSearch.Text = "Search";
            this.btnEvetSearch.UseVisualStyleBackColor = true;
            this.btnEvetSearch.Click += new System.EventHandler(this.EventSearchClick);
            // 
            // btnEventDelete
            // 
            this.btnEventDelete.Location = new System.Drawing.Point(248, 168);
            this.btnEventDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnEventDelete.Name = "btnEventDelete";
            this.btnEventDelete.Size = new System.Drawing.Size(66, 28);
            this.btnEventDelete.TabIndex = 10;
            this.btnEventDelete.TabStop = false;
            this.btnEventDelete.Text = "Delete";
            this.btnEventDelete.UseVisualStyleBackColor = true;
            this.btnEventDelete.Click += new System.EventHandler(this.btnEventDelete_Click);
            // 
            // comboBoxEventsSex
            // 
            this.comboBoxEventsSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEventsSex.FormattingEnabled = true;
            this.comboBoxEventsSex.Items.AddRange(new object[] {
            "Not known",
            "Male",
            "Female",
            "Not applicable"});
            this.comboBoxEventsSex.Location = new System.Drawing.Point(109, 101);
            this.comboBoxEventsSex.Name = "comboBoxEventsSex";
            this.comboBoxEventsSex.Size = new System.Drawing.Size(121, 28);
            this.comboBoxEventsSex.TabIndex = 3;
            // 
            // labelEventsSex
            // 
            this.labelEventsSex.AutoSize = true;
            this.labelEventsSex.Location = new System.Drawing.Point(8, 105);
            this.labelEventsSex.Name = "labelEventsSex";
            this.labelEventsSex.Size = new System.Drawing.Size(63, 20);
            this.labelEventsSex.TabIndex = 9;
            this.labelEventsSex.Text = "Gender";
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEvents.AutoGenerateColumns = false;
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.ageLimitDataGridViewTextBoxColumn});
            this.dataGridViewEvents.DataSource = this.bindingSourceEvents;
            this.dataGridViewEvents.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.Size = new System.Drawing.Size(468, 713);
            this.dataGridViewEvents.TabIndex = 8;
            this.dataGridViewEvents.TabStop = false;
            // 
            // bindingSourceEvents
            // 
            this.bindingSourceEvents.DataSource = typeof(SportsMeet.Models.Event);
            this.bindingSourceEvents.Sort = "Number";
            // 
            // numericUpDownEventAgeLimit
            // 
            this.numericUpDownEventAgeLimit.Location = new System.Drawing.Point(109, 71);
            this.numericUpDownEventAgeLimit.Name = "numericUpDownEventAgeLimit";
            this.numericUpDownEventAgeLimit.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownEventAgeLimit.TabIndex = 2;
            this.numericUpDownEventAgeLimit.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // labelEventsAgeLimit
            // 
            this.labelEventsAgeLimit.AutoSize = true;
            this.labelEventsAgeLimit.Location = new System.Drawing.Point(8, 75);
            this.labelEventsAgeLimit.Name = "labelEventsAgeLimit";
            this.labelEventsAgeLimit.Size = new System.Drawing.Size(75, 20);
            this.labelEventsAgeLimit.TabIndex = 6;
            this.labelEventsAgeLimit.Text = "Age Limit";
            // 
            // tbNewEventsName
            // 
            this.tbNewEventsName.Location = new System.Drawing.Point(109, 41);
            this.tbNewEventsName.Margin = new System.Windows.Forms.Padding(6);
            this.tbNewEventsName.Name = "tbNewEventsName";
            this.tbNewEventsName.Size = new System.Drawing.Size(196, 26);
            this.tbNewEventsName.TabIndex = 1;
            // 
            // tbNewEventsNumber
            // 
            this.tbNewEventsNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbNewEventsNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbNewEventsNumber.Location = new System.Drawing.Point(109, 11);
            this.tbNewEventsNumber.Margin = new System.Windows.Forms.Padding(6);
            this.tbNewEventsNumber.Name = "tbNewEventsNumber";
            this.tbNewEventsNumber.Size = new System.Drawing.Size(196, 26);
            this.tbNewEventsNumber.TabIndex = 0;
            this.tbNewEventsNumber.TextChanged += new System.EventHandler(this.EventsNumberTextChanged);
            // 
            // lblNewEventsName
            // 
            this.lblNewEventsName.AutoSize = true;
            this.lblNewEventsName.Location = new System.Drawing.Point(8, 45);
            this.lblNewEventsName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNewEventsName.Name = "lblNewEventsName";
            this.lblNewEventsName.Size = new System.Drawing.Size(96, 20);
            this.lblNewEventsName.TabIndex = 2;
            this.lblNewEventsName.Text = "Event Name";
            // 
            // lblNewEventsNumber
            // 
            this.lblNewEventsNumber.AutoSize = true;
            this.lblNewEventsNumber.Location = new System.Drawing.Point(7, 15);
            this.lblNewEventsNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNewEventsNumber.Name = "lblNewEventsNumber";
            this.lblNewEventsNumber.Size = new System.Drawing.Size(110, 20);
            this.lblNewEventsNumber.TabIndex = 1;
            this.lblNewEventsNumber.Text = "Event Number";
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(20, 168);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(66, 28);
            this.btnAddEvent.TabIndex = 4;
            this.btnAddEvent.Text = "Add";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // tbPlayers
            // 
            this.tbPlayers.Controls.Add(this.textBoxPlayerSearch);
            this.tbPlayers.Controls.Add(this.checkBoxDeleteSelection);
            this.tbPlayers.Controls.Add(this.checkBoxLoadSelection);
            this.tbPlayers.Controls.Add(this.checkBoxAddtoanEvent);
            this.tbPlayers.Controls.Add(this.btnAddEventsToPlayer);
            this.tbPlayers.Controls.Add(this.btnPlayerEdit);
            this.tbPlayers.Controls.Add(this.btnDeletePlayer);
            this.tbPlayers.Controls.Add(this.dataGridViewPlayers);
            this.tbPlayers.Controls.Add(this.numericUpDownAge);
            this.tbPlayers.Controls.Add(this.lblDistrict);
            this.tbPlayers.Controls.Add(this.cbxDistrict);
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
            this.tbPlayers.Size = new System.Drawing.Size(1435, 720);
            this.tbPlayers.TabIndex = 1;
            this.tbPlayers.Text = "Players";
            this.tbPlayers.UseVisualStyleBackColor = true;
            this.tbPlayers.Click += new System.EventHandler(this.tbPlayers_Click);
            // 
            // textBoxPlayerSearch
            // 
            this.textBoxPlayerSearch.Location = new System.Drawing.Point(352, 39);
            this.textBoxPlayerSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPlayerSearch.Name = "textBoxPlayerSearch";
            this.textBoxPlayerSearch.Size = new System.Drawing.Size(545, 26);
            this.textBoxPlayerSearch.TabIndex = 40;
            this.textBoxPlayerSearch.Text = " ";
            this.textBoxPlayerSearch.TextChanged += new System.EventHandler(this.textBoxPlayerSearch_TextChanged);
            this.textBoxPlayerSearch.Enter += new System.EventHandler(this.textBoxPlayerSearch_Enter);
            this.textBoxPlayerSearch.Leave += new System.EventHandler(this.textBoxPlayerSearch_Leave);
            // 
            // checkBoxDeleteSelection
            // 
            this.checkBoxDeleteSelection.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxDeleteSelection.AutoSize = true;
            this.checkBoxDeleteSelection.Location = new System.Drawing.Point(444, 9);
            this.checkBoxDeleteSelection.Name = "checkBoxDeleteSelection";
            this.checkBoxDeleteSelection.Size = new System.Drawing.Size(133, 30);
            this.checkBoxDeleteSelection.TabIndex = 39;
            this.checkBoxDeleteSelection.Text = "Delete selection";
            this.checkBoxDeleteSelection.UseVisualStyleBackColor = true;
            this.checkBoxDeleteSelection.CheckedChanged += new System.EventHandler(this.checkBoxDeleteSelection_CheckedChanged);
            // 
            // checkBoxLoadSelection
            // 
            this.checkBoxLoadSelection.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxLoadSelection.AutoSize = true;
            this.checkBoxLoadSelection.Checked = true;
            this.checkBoxLoadSelection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLoadSelection.Location = new System.Drawing.Point(352, 9);
            this.checkBoxLoadSelection.Name = "checkBoxLoadSelection";
            this.checkBoxLoadSelection.Size = new System.Drawing.Size(122, 30);
            this.checkBoxLoadSelection.TabIndex = 38;
            this.checkBoxLoadSelection.TabStop = false;
            this.checkBoxLoadSelection.Text = "Load selection";
            this.checkBoxLoadSelection.UseVisualStyleBackColor = true;
            this.checkBoxLoadSelection.CheckedChanged += new System.EventHandler(this.checkBoxLoadSelection_CheckedChanged);
            // 
            // checkBoxAddtoanEvent
            // 
            this.checkBoxAddtoanEvent.AutoSize = true;
            this.checkBoxAddtoanEvent.Location = new System.Drawing.Point(105, 291);
            this.checkBoxAddtoanEvent.Name = "checkBoxAddtoanEvent";
            this.checkBoxAddtoanEvent.Size = new System.Drawing.Size(149, 24);
            this.checkBoxAddtoanEvent.TabIndex = 7;
            this.checkBoxAddtoanEvent.Text = "Add to an Event";
            this.checkBoxAddtoanEvent.UseVisualStyleBackColor = true;
            // 
            // btnAddEventsToPlayer
            // 
            this.btnAddEventsToPlayer.Location = new System.Drawing.Point(105, 315);
            this.btnAddEventsToPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEventsToPlayer.Name = "btnAddEventsToPlayer";
            this.btnAddEventsToPlayer.Size = new System.Drawing.Size(180, 28);
            this.btnAddEventsToPlayer.TabIndex = 32;
            this.btnAddEventsToPlayer.TabStop = false;
            this.btnAddEventsToPlayer.Text = "Player Events Management ";
            this.btnAddEventsToPlayer.UseVisualStyleBackColor = true;
            this.btnAddEventsToPlayer.Click += new System.EventHandler(this.btnAddEventsToPlayer_Click);
            // 
            // btnPlayerEdit
            // 
            this.btnPlayerEdit.Location = new System.Drawing.Point(97, 471);
            this.btnPlayerEdit.Name = "btnPlayerEdit";
            this.btnPlayerEdit.Size = new System.Drawing.Size(66, 28);
            this.btnPlayerEdit.TabIndex = 31;
            this.btnPlayerEdit.TabStop = false;
            this.btnPlayerEdit.Text = "Edit";
            this.btnPlayerEdit.UseVisualStyleBackColor = true;
            this.btnPlayerEdit.Click += new System.EventHandler(this.btnPlayerEdit_Click);
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.Location = new System.Drawing.Point(169, 471);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(66, 28);
            this.btnDeletePlayer.TabIndex = 29;
            this.btnDeletePlayer.TabStop = false;
            this.btnDeletePlayer.Text = "Delete";
            this.btnDeletePlayer.UseVisualStyleBackColor = true;
            this.btnDeletePlayer.Click += new System.EventHandler(this.deletePlayer_Click);
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
            this.Gender});
            this.dataGridViewPlayers.DataSource = this.bindingSourcePlayers;
            this.dataGridViewPlayers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPlayers.Location = new System.Drawing.Point(352, 71);
            this.dataGridViewPlayers.MultiSelect = false;
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.RowTemplate.Height = 33;
            this.dataGridViewPlayers.Size = new System.Drawing.Size(1073, 641);
            this.dataGridViewPlayers.TabIndex = 27;
            this.dataGridViewPlayers.TabStop = false;
            this.dataGridViewPlayers.SelectionChanged += new System.EventHandler(this.dataGridViewPlayers_SelectionChanged);
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
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // bindingSourcePlayers
            // 
            this.bindingSourcePlayers.DataSource = typeof(SportsMeet.Models.Player);
            this.bindingSourcePlayers.Sort = "Number";
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(105, 176);
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownAge.TabIndex = 4;
            this.numericUpDownAge.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
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
            this.cbxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDistrict.FormattingEnabled = true;
            this.cbxDistrict.Location = new System.Drawing.Point(105, 245);
            this.cbxDistrict.Margin = new System.Windows.Forms.Padding(6);
            this.cbxDistrict.Name = "cbxDistrict";
            this.cbxDistrict.Size = new System.Drawing.Size(180, 28);
            this.cbxDistrict.TabIndex = 6;
            // 
            // bindingSourceDistricts
            // 
            this.bindingSourceDistricts.DataSource = typeof(SportsMeet.Models.District);
            // 
            // cbxSchool
            // 
            this.cbxSchool.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSchool.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSchool.DataSource = this.bindingSourceSchoolsFixed;
            this.cbxSchool.DisplayMember = "Name";
            this.cbxSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSchool.FormattingEnabled = true;
            this.cbxSchool.Location = new System.Drawing.Point(105, 140);
            this.cbxSchool.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSchool.Name = "cbxSchool";
            this.cbxSchool.Size = new System.Drawing.Size(180, 28);
            this.cbxSchool.TabIndex = 3;
            // 
            // bindingSourceSchoolsFixed
            // 
            this.bindingSourceSchoolsFixed.DataSource = typeof(SportsMeet.Models.School);
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
            this.cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Not known",
            "Male",
            "Female",
            "Not applicable"});
            this.cbxGender.Location = new System.Drawing.Point(105, 210);
            this.cbxGender.Margin = new System.Windows.Forms.Padding(4);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(120, 28);
            this.cbxGender.TabIndex = 5;
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
            this.tbLastName.Location = new System.Drawing.Point(105, 106);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(212, 26);
            this.tbLastName.TabIndex = 2;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(105, 71);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(212, 26);
            this.tbFirstName.TabIndex = 1;
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
            this.tbPlayerNumber.Location = new System.Drawing.Point(105, 36);
            this.tbPlayerNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbPlayerNumber.Name = "tbPlayerNumber";
            this.tbPlayerNumber.Size = new System.Drawing.Size(212, 26);
            this.tbPlayerNumber.TabIndex = 0;
            this.tbPlayerNumber.Text = " ";
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(24, 471);
            this.btnAddPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(66, 28);
            this.btnAddPlayer.TabIndex = 10;
            this.btnAddPlayer.Text = "Add";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // tbFilterByPlayer
            // 
            this.tbFilterByPlayer.Controls.Add(this.label3);
            this.tbFilterByPlayer.Controls.Add(this.label2);
            this.tbFilterByPlayer.Controls.Add(this.label1);
            this.tbFilterByPlayer.Controls.Add(this.lblFilterByPlayerDistrictOutput);
            this.tbFilterByPlayer.Controls.Add(this.lblFilterByPlayerSchoolOutput);
            this.tbFilterByPlayer.Controls.Add(this.lblFilterByPlayerNameOutput);
            this.tbFilterByPlayer.Controls.Add(this.dataGridViewEventsOfPlaye);
            this.tbFilterByPlayer.Controls.Add(this.dataGridPlayerFiltering);
            this.tbFilterByPlayer.Controls.Add(this.lblFilterByPlayerEvents);
            this.tbFilterByPlayer.Controls.Add(this.lblFilterByPlayerDistrict);
            this.tbFilterByPlayer.Controls.Add(this.lblFilterByPlayerSchool);
            this.tbFilterByPlayer.Controls.Add(this.lblFilerByPlayerName);
            this.tbFilterByPlayer.Controls.Add(this.tbFilterByPlayersNumber);
            this.tbFilterByPlayer.Location = new System.Drawing.Point(4, 29);
            this.tbFilterByPlayer.Margin = new System.Windows.Forms.Padding(6);
            this.tbFilterByPlayer.Name = "tbFilterByPlayer";
            this.tbFilterByPlayer.Padding = new System.Windows.Forms.Padding(6);
            this.tbFilterByPlayer.Size = new System.Drawing.Size(1435, 720);
            this.tbFilterByPlayer.TabIndex = 3;
            this.tbFilterByPlayer.Text = "Filter By Player";
            this.tbFilterByPlayer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Player Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Player Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Players";
            // 
            // lblFilterByPlayerDistrictOutput
            // 
            this.lblFilterByPlayerDistrictOutput.AutoSize = true;
            this.lblFilterByPlayerDistrictOutput.Location = new System.Drawing.Point(125, 57);
            this.lblFilterByPlayerDistrictOutput.Name = "lblFilterByPlayerDistrictOutput";
            this.lblFilterByPlayerDistrictOutput.Size = new System.Drawing.Size(55, 20);
            this.lblFilterByPlayerDistrictOutput.TabIndex = 10;
            this.lblFilterByPlayerDistrictOutput.Text = "district";
            // 
            // lblFilterByPlayerSchoolOutput
            // 
            this.lblFilterByPlayerSchoolOutput.AutoSize = true;
            this.lblFilterByPlayerSchoolOutput.Location = new System.Drawing.Point(125, 44);
            this.lblFilterByPlayerSchoolOutput.Name = "lblFilterByPlayerSchoolOutput";
            this.lblFilterByPlayerSchoolOutput.Size = new System.Drawing.Size(55, 20);
            this.lblFilterByPlayerSchoolOutput.TabIndex = 9;
            this.lblFilterByPlayerSchoolOutput.Text = "school";
            // 
            // lblFilterByPlayerNameOutput
            // 
            this.lblFilterByPlayerNameOutput.AutoSize = true;
            this.lblFilterByPlayerNameOutput.Location = new System.Drawing.Point(125, 31);
            this.lblFilterByPlayerNameOutput.Name = "lblFilterByPlayerNameOutput";
            this.lblFilterByPlayerNameOutput.Size = new System.Drawing.Size(49, 20);
            this.lblFilterByPlayerNameOutput.TabIndex = 8;
            this.lblFilterByPlayerNameOutput.Text = "name";
            // 
            // dataGridViewEventsOfPlaye
            // 
            this.dataGridViewEventsOfPlaye.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEventsOfPlaye.AutoGenerateColumns = false;
            this.dataGridViewEventsOfPlaye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventsOfPlaye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.numberDataGridViewTextBoxColumn4,
            this.sexDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn1});
            this.dataGridViewEventsOfPlaye.DataSource = this.bindingSourceFilteredEventsOnPlayers;
            this.dataGridViewEventsOfPlaye.Location = new System.Drawing.Point(28, 92);
            this.dataGridViewEventsOfPlaye.Name = "dataGridViewEventsOfPlaye";
            this.dataGridViewEventsOfPlaye.Size = new System.Drawing.Size(838, 610);
            this.dataGridViewEventsOfPlaye.TabIndex = 7;
            this.dataGridViewEventsOfPlaye.TabStop = false;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            // 
            // numberDataGridViewTextBoxColumn4
            // 
            this.numberDataGridViewTextBoxColumn4.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn4.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn4.Name = "numberDataGridViewTextBoxColumn4";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn1
            // 
            this.genderDataGridViewTextBoxColumn1.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn1.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn1.Name = "genderDataGridViewTextBoxColumn1";
            this.genderDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bindingSourceFilteredEventsOnPlayers
            // 
            this.bindingSourceFilteredEventsOnPlayers.DataSource = typeof(SportsMeet.Models.Event);
            // 
            // dataGridPlayerFiltering
            // 
            this.dataGridPlayerFiltering.AllowUserToAddRows = false;
            this.dataGridPlayerFiltering.AllowUserToDeleteRows = false;
            this.dataGridPlayerFiltering.AllowUserToOrderColumns = true;
            this.dataGridPlayerFiltering.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPlayerFiltering.AutoGenerateColumns = false;
            this.dataGridPlayerFiltering.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPlayerFiltering.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.ageDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.dataGridPlayerFiltering.DataSource = this.bindingSourcePlayers;
            this.dataGridPlayerFiltering.Location = new System.Drawing.Point(880, 92);
            this.dataGridPlayerFiltering.Name = "dataGridPlayerFiltering";
            this.dataGridPlayerFiltering.Size = new System.Drawing.Size(543, 610);
            this.dataGridPlayerFiltering.TabIndex = 6;
            this.dataGridPlayerFiltering.TabStop = false;
            // 
            // numberDataGridViewTextBoxColumn1
            // 
            this.numberDataGridViewTextBoxColumn1.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn1.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn1.Name = "numberDataGridViewTextBoxColumn1";
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            // 
            // ageDataGridViewTextBoxColumn1
            // 
            this.ageDataGridViewTextBoxColumn1.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn1.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn1.Name = "ageDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn1.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lblFilterByPlayerEvents
            // 
            this.lblFilterByPlayerEvents.AutoSize = true;
            this.lblFilterByPlayerEvents.Location = new System.Drawing.Point(13, 76);
            this.lblFilterByPlayerEvents.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFilterByPlayerEvents.Name = "lblFilterByPlayerEvents";
            this.lblFilterByPlayerEvents.Size = new System.Drawing.Size(58, 20);
            this.lblFilterByPlayerEvents.TabIndex = 1;
            this.lblFilterByPlayerEvents.Text = "Events";
            // 
            // lblFilterByPlayerDistrict
            // 
            this.lblFilterByPlayerDistrict.AutoSize = true;
            this.lblFilterByPlayerDistrict.Location = new System.Drawing.Point(13, 57);
            this.lblFilterByPlayerDistrict.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFilterByPlayerDistrict.Name = "lblFilterByPlayerDistrict";
            this.lblFilterByPlayerDistrict.Size = new System.Drawing.Size(58, 20);
            this.lblFilterByPlayerDistrict.TabIndex = 4;
            this.lblFilterByPlayerDistrict.Text = "District";
            // 
            // lblFilterByPlayerSchool
            // 
            this.lblFilterByPlayerSchool.AutoSize = true;
            this.lblFilterByPlayerSchool.Location = new System.Drawing.Point(12, 44);
            this.lblFilterByPlayerSchool.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFilterByPlayerSchool.Name = "lblFilterByPlayerSchool";
            this.lblFilterByPlayerSchool.Size = new System.Drawing.Size(58, 20);
            this.lblFilterByPlayerSchool.TabIndex = 3;
            this.lblFilterByPlayerSchool.Text = "School";
            // 
            // lblFilerByPlayerName
            // 
            this.lblFilerByPlayerName.AutoSize = true;
            this.lblFilerByPlayerName.Location = new System.Drawing.Point(12, 31);
            this.lblFilerByPlayerName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFilerByPlayerName.Name = "lblFilerByPlayerName";
            this.lblFilerByPlayerName.Size = new System.Drawing.Size(51, 20);
            this.lblFilerByPlayerName.TabIndex = 2;
            this.lblFilerByPlayerName.Text = "Name";
            // 
            // tbFilterByPlayersNumber
            // 
            this.tbFilterByPlayersNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilterByPlayersNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbFilterByPlayersNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbFilterByPlayersNumber.Location = new System.Drawing.Point(877, 28);
            this.tbFilterByPlayersNumber.Margin = new System.Windows.Forms.Padding(6);
            this.tbFilterByPlayersNumber.Name = "tbFilterByPlayersNumber";
            this.tbFilterByPlayersNumber.Size = new System.Drawing.Size(546, 26);
            this.tbFilterByPlayersNumber.TabIndex = 0;
            this.tbFilterByPlayersNumber.TextChanged += new System.EventHandler(this.tbFilterByPlayersNumber_TextChanged);
            this.tbFilterByPlayersNumber.Leave += new System.EventHandler(this.tbPlayerSearch_Leave);
            // 
            // tbFilterByEvent
            // 
            this.tbFilterByEvent.Controls.Add(this.dataGridViewFilteredPlayers);
            this.tbFilterByEvent.Controls.Add(this.btnFilterByEventFilter);
            this.tbFilterByEvent.Controls.Add(this.lblFIlterByEventPlayers);
            this.tbFilterByEvent.Controls.Add(this.tbFilterByEventEventNumber);
            this.tbFilterByEvent.Controls.Add(this.lblFilterByEventEventNumber);
            this.tbFilterByEvent.Location = new System.Drawing.Point(4, 29);
            this.tbFilterByEvent.Margin = new System.Windows.Forms.Padding(6);
            this.tbFilterByEvent.Name = "tbFilterByEvent";
            this.tbFilterByEvent.Padding = new System.Windows.Forms.Padding(6);
            this.tbFilterByEvent.Size = new System.Drawing.Size(1435, 720);
            this.tbFilterByEvent.TabIndex = 4;
            this.tbFilterByEvent.Text = "Filter By Event";
            this.tbFilterByEvent.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFilteredPlayers
            // 
            this.dataGridViewFilteredPlayers.AutoGenerateColumns = false;
            this.dataGridViewFilteredPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilteredPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn3,
            this.firstNameDataGridViewTextBoxColumn2,
            this.lastNameDataGridViewTextBoxColumn2,
            this.ageDataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewFilteredPlayers.DataSource = this.bindingSourceFilteredPlayersOnEvent;
            this.dataGridViewFilteredPlayers.Location = new System.Drawing.Point(351, 27);
            this.dataGridViewFilteredPlayers.Name = "dataGridViewFilteredPlayers";
            this.dataGridViewFilteredPlayers.Size = new System.Drawing.Size(547, 460);
            this.dataGridViewFilteredPlayers.TabIndex = 3;
            this.dataGridViewFilteredPlayers.TabStop = false;
            // 
            // numberDataGridViewTextBoxColumn3
            // 
            this.numberDataGridViewTextBoxColumn3.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn3.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn3.Name = "numberDataGridViewTextBoxColumn3";
            // 
            // firstNameDataGridViewTextBoxColumn2
            // 
            this.firstNameDataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn2.Name = "firstNameDataGridViewTextBoxColumn2";
            // 
            // lastNameDataGridViewTextBoxColumn2
            // 
            this.lastNameDataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn2.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn2.Name = "lastNameDataGridViewTextBoxColumn2";
            // 
            // ageDataGridViewTextBoxColumn2
            // 
            this.ageDataGridViewTextBoxColumn2.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn2.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn2.Name = "ageDataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn2.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // bindingSourceFilteredPlayersOnEvent
            // 
            this.bindingSourceFilteredPlayersOnEvent.DataSource = typeof(SportsMeet.Models.Player);
            // 
            // btnFilterByEventFilter
            // 
            this.btnFilterByEventFilter.Location = new System.Drawing.Point(92, 209);
            this.btnFilterByEventFilter.Name = "btnFilterByEventFilter";
            this.btnFilterByEventFilter.Size = new System.Drawing.Size(82, 28);
            this.btnFilterByEventFilter.TabIndex = 1;
            this.btnFilterByEventFilter.Text = "Filter";
            this.btnFilterByEventFilter.UseVisualStyleBackColor = true;
            this.btnFilterByEventFilter.Click += new System.EventHandler(this.btnFilterByEventFilter_Click);
            // 
            // lblFIlterByEventPlayers
            // 
            this.lblFIlterByEventPlayers.AutoSize = true;
            this.lblFIlterByEventPlayers.Location = new System.Drawing.Point(331, 6);
            this.lblFIlterByEventPlayers.Name = "lblFIlterByEventPlayers";
            this.lblFIlterByEventPlayers.Size = new System.Drawing.Size(60, 20);
            this.lblFIlterByEventPlayers.TabIndex = 2;
            this.lblFIlterByEventPlayers.Text = "Players";
            // 
            // tbFilterByEventEventNumber
            // 
            this.tbFilterByEventEventNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbFilterByEventEventNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbFilterByEventEventNumber.Location = new System.Drawing.Point(92, 24);
            this.tbFilterByEventEventNumber.Name = "tbFilterByEventEventNumber";
            this.tbFilterByEventEventNumber.Size = new System.Drawing.Size(122, 26);
            this.tbFilterByEventEventNumber.TabIndex = 0;
            // 
            // lblFilterByEventEventNumber
            // 
            this.lblFilterByEventEventNumber.AutoSize = true;
            this.lblFilterByEventEventNumber.Location = new System.Drawing.Point(9, 27);
            this.lblFilterByEventEventNumber.Name = "lblFilterByEventEventNumber";
            this.lblFilterByEventEventNumber.Size = new System.Drawing.Size(110, 20);
            this.lblFilterByEventEventNumber.TabIndex = 0;
            this.lblFilterByEventEventNumber.Text = "Event Number";
            // 
            // reportTab
            // 
            this.reportTab.Location = new System.Drawing.Point(4, 29);
            this.reportTab.Name = "reportTab";
            this.reportTab.Size = new System.Drawing.Size(1435, 720);
            this.reportTab.TabIndex = 5;
            this.reportTab.Text = "Reports";
            this.reportTab.UseVisualStyleBackColor = true;
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
            this.toolStripSeparator2,
            this.toolStripLabelSchools,
            this.toolStripLabelSchoolCount,
            this.toolStripSeparator3,
            this.toolStripLabel2,
            this.toolStripLabelTotalEvents,
            this.toolStripSeparator1,
            this.statusLabel,
            this.toolStripSeparator4,
            this.toolStripButtonAbout});
            this.toolStripStatusBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripStatusBar.Location = new System.Drawing.Point(8, 767);
            this.toolStripStatusBar.Name = "toolStripStatusBar";
            this.toolStripStatusBar.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripStatusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripStatusBar.Size = new System.Drawing.Size(1302, 45);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(114, 42);
            this.toolStripLabel2.Text = "Total Events :";
            // 
            // toolStripLabelTotalEvents
            // 
            this.toolStripLabelTotalEvents.Name = "toolStripLabelTotalEvents";
            this.toolStripLabelTotalEvents.Size = new System.Drawing.Size(22, 42);
            this.toolStripLabelTotalEvents.Text = "0";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // statusLabel
            // 
            this.statusLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.statusLabel.AutoSize = false;
            this.statusLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.statusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(500, 42);
            this.statusLabel.Text = "Status of the application";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(66, 42);
            this.toolStripButtonAbout.Text = "About";
            this.toolStripButtonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(SportsMeet.Models.Event);
            // 
            // statusTime
            // 
            this.statusTime.Interval = 4000;
            this.statusTime.Tick += new System.EventHandler(this.statusTime_Tick);
            // 
            // bindingSourceAllSchools
            // 
            this.bindingSourceAllSchools.DataSource = typeof(SportsMeet.Models.School);
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // numberDataGridViewTextBoxColumn2
            // 
            this.numberDataGridViewTextBoxColumn2.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn2.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn2.Name = "numberDataGridViewTextBoxColumn2";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageLimitDataGridViewTextBoxColumn
            // 
            this.ageLimitDataGridViewTextBoxColumn.DataPropertyName = "AgeLimit";
            this.ageLimitDataGridViewTextBoxColumn.HeaderText = "Age Limit";
            this.ageLimitDataGridViewTextBoxColumn.Name = "ageLimitDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn5
            // 
            this.numberDataGridViewTextBoxColumn5.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn5.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn5.Name = "numberDataGridViewTextBoxColumn5";
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            // 
            // genderDataGridViewTextBoxColumn2
            // 
            this.genderDataGridViewTextBoxColumn2.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn2.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn2.Name = "genderDataGridViewTextBoxColumn2";
            this.genderDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ageLimitDataGridViewTextBoxColumn1
            // 
            this.ageLimitDataGridViewTextBoxColumn1.DataPropertyName = "AgeLimit";
            this.ageLimitDataGridViewTextBoxColumn1.HeaderText = "Age Limit";
            this.ageLimitDataGridViewTextBoxColumn1.Name = "ageLimitDataGridViewTextBoxColumn1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewAllEvents, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewEvents, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(351, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(948, 719);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewAllSchools, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(323, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(976, 712);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1311, 821);
            this.Controls.Add(this.toolStripStatusBar);
            this.Controls.Add(this.tcMainForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(932, 640);
            this.Name = "MainForm";
            this.Text = "Sports Meet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcMainForm.ResumeLayout(false);
            this.tbSchool.ResumeLayout(false);
            this.tbSchool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllSchools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSchools)).EndInit();
            this.tbEvents.ResumeLayout(false);
            this.tbEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEventAgeLimit)).EndInit();
            this.tbPlayers.ResumeLayout(false);
            this.tbPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDistricts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSchoolsFixed)).EndInit();
            this.tbFilterByPlayer.ResumeLayout(false);
            this.tbFilterByPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventsOfPlaye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFilteredEventsOnPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlayerFiltering)).EndInit();
            this.tbFilterByEvent.ResumeLayout(false);
            this.tbFilterByEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilteredPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFilteredPlayersOnEvent)).EndInit();
            this.toolStripStatusBar.ResumeLayout(false);
            this.toolStripStatusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFilterByPlayerEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllSchools)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tbSchool;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.ComboBox cbxDistrict;
        private System.Windows.Forms.Label lblNewEventsName;
        private System.Windows.Forms.Label lblNewEventsNumber;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.TextBox tbSchoolName;
        private System.Windows.Forms.Label lblSchoolName;
        private System.Windows.Forms.Button btnAddSchool;
        private System.Windows.Forms.TabPage tbFilterByPlayer;
        private System.Windows.Forms.TabPage tbFilterByEvent;
        private System.Windows.Forms.Label lblFilterByPlayerDistrict;
        private System.Windows.Forms.Label lblFilterByPlayerSchool;
        private System.Windows.Forms.Label lblFilerByPlayerName;
        private System.Windows.Forms.TextBox tbFilterByPlayersNumber;
        private System.Windows.Forms.Label lblFilterByPlayerEvents;
        private ToolStrip toolStripStatusBar;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabelTotalPlayerCount;
        private ToolStripButton toolStripButtonAbout;
        private NumericUpDown numericUpDownAge;
        private Label labelEventsAgeLimit;
        private DataGridView dataGridViewPlayers;
        private Button btnDeletePlayer;
        private ImageList imageListForTabs;
        private BindingSource bindingSourcePlayers;
        private BindingSource bindingSourceSchools;
        private ToolStripLabel toolStripLabelSchools;
        private ToolStripLabel toolStripLabelSchoolCount;
        private BindingSource bindingSourceDistricts;
        private Button btnFilterByEventFilter;
        private Label lblFIlterByEventPlayers;
        private TextBox tbFilterByEventEventNumber;
        private Label lblFilterByEventEventNumber;
        private DataGridView dataGridPlayerFiltering;
        private DataGridView dataGridViewEventsOfPlaye;
        private NumericUpDown numericUpDownEventAgeLimit;
        private TextBox tbNewEventsName;
        private TextBox tbNewEventsNumber;
        private DataGridView dataGridViewEvents;
        private BindingSource bindingSourceEvents;
        private Label labelEventsSex;
        private ComboBox comboBoxEventsSex;
        private Label lblFilterByPlayerDistrictOutput;
        private Label lblFilterByPlayerSchoolOutput;
        private Label lblFilterByPlayerNameOutput;
        private BindingSource bindingSourceFilterByPlayerEvents;
        private BindingSource eventBindingSource;
        private Button btnEventEdit;
        private Button btnEvetSearch;
        private Button btnEventDelete;
        private ToolStripLabel toolStripLabel2;
        private ToolStripLabel toolStripLabelTotalEvents;
        private Button btnPlayerEdit;
        private Button btnAddEventsToPlayer;
        private CheckBox checkBoxAddtoanEvent;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel statusLabel;
        private CheckBox checkBoxLoadSelection;
        private CheckBox checkBoxDeleteSelection;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private Button btnDeleteSchool;
        private Button btnEditSchool;
   		private DataGridView dataGridView1;
        private TabPage reportTab;
        private TextBox textBoxPlayerSearch;
        private DataGridView dataGridViewFilteredPlayers;
        private BindingSource bindingSourceFilteredPlayersOnEvent;
        private BindingSource bindingSourceFilteredEventsOnPlayers;
        private TextBox tbNewSchoolName;
        private Label lblNewSchoolName;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private BindingSource bindingSourceSchoolsFixed;
        private Label label2;
        private Label label1;
        private Label label3;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Number;
        private StatusViewer statusViewer;
        private Timer statusTime;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn1;
        private Button btnEeventsTabAddPlayers;
        private DataGridView dataGridViewAllEvents;
        private BindingSource bindingSourceAllEvents;
        private DataGridView dataGridViewAllSchools;
        private BindingSource bindingSourceAllSchools;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn ageLimitDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageLimitDataGridViewTextBoxColumn;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
    
}
