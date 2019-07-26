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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceSchools = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewAllSchools = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceAllSchools = new System.Windows.Forms.BindingSource(this.components);
            this.tbNewSchoolName = new System.Windows.Forms.TextBox();
            this.lblNewSchoolName = new System.Windows.Forms.Label();
            this.btnDeleteSchool = new System.Windows.Forms.Button();
            this.btnEditSchool = new System.Windows.Forms.Button();
            this.tbSchoolName = new System.Windows.Forms.TextBox();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.btnAddSchool = new System.Windows.Forms.Button();
            this.tbEvents = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewAllEvents = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageLimitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceAllEvents = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceEvents = new System.Windows.Forms.BindingSource(this.components);
            this.btnEeventsTabAddPlayers = new System.Windows.Forms.Button();
            this.btnEventEdit = new System.Windows.Forms.Button();
            this.btnEvetSearch = new System.Windows.Forms.Button();
            this.btnEventDelete = new System.Windows.Forms.Button();
            this.comboBoxEventsSex = new System.Windows.Forms.ComboBox();
            this.labelEventsSex = new System.Windows.Forms.Label();
            this.numericUpDownEventAgeLimit = new System.Windows.Forms.NumericUpDown();
            this.labelEventsAgeLimit = new System.Windows.Forms.Label();
            this.tbNewEventsName = new System.Windows.Forms.TextBox();
            this.tbNewEventsNumber = new System.Windows.Forms.TextBox();
            this.lblNewEventsName = new System.Windows.Forms.Label();
            this.lblNewEventsNumber = new System.Windows.Forms.Label();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.tbPlayers = new System.Windows.Forms.TabPage();
            this.comboBoxEducationZones = new System.Windows.Forms.ComboBox();
            this.bindingSourceEducationZones = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
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
            this.labelEducationZoneFBP = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFilterByPlayerDistrictOutput = new System.Windows.Forms.Label();
            this.lblFilterByPlayerSchoolOutput = new System.Windows.Forms.Label();
            this.lblFilterByPlayerNameOutput = new System.Windows.Forms.Label();
            this.dataGridViewEventsOfPlaye = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label8 = new System.Windows.Forms.Label();
            this.labelCurrentEventFBE = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewFBE = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewFilteredPlayers = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceFilteredPlayersOnEvent = new System.Windows.Forms.BindingSource(this.components);
            this.lblFIlterByEventPlayers = new System.Windows.Forms.Label();
            this.tbFilterByEventEventNumber = new System.Windows.Forms.TextBox();
            this.lblFilterByEventEventNumber = new System.Windows.Forms.Label();
            this.tabPageEventsManagement = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewCurrentPlayerEvents = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageLimitDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceEventsBelongToPlayer = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveEventFromPlayer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridViewCurrentPlayerNewEvents = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageLimitDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceEventsDoesNotBelongToPlayer = new System.Windows.Forms.BindingSource(this.components);
            this.playerevents = new System.Windows.Forms.Label();
            this.btnChangePlayerPlayerEventsMgt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelAddEventsPlayerAge = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelAddEventsPlayerGender = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelAddEventsPlayerFullName = new System.Windows.Forms.Label();
            this.labelAddEventsPlayerNumber = new System.Windows.Forms.Label();
            this.tabPageReports = new System.Windows.Forms.TabPage();
            this.progressBarReports = new System.Windows.Forms.ProgressBar();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonChangeReportFolder = new System.Windows.Forms.Button();
            this.treeViewSaveReportPath = new System.Windows.Forms.TreeView();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxSaveReportPath = new System.Windows.Forms.TextBox();
            this.buttonReportPlayers = new System.Windows.Forms.Button();
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
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemImport = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSourceFilterByPlayerEvents = new System.Windows.Forms.BindingSource(this.components);
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTime = new System.Windows.Forms.Timer(this.components);
            this.eventBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialogSaveReports = new System.Windows.Forms.SaveFileDialog();
            this.fileSystemWatcherReportPath = new System.IO.FileSystemWatcher();
            this.tcMainForm.SuspendLayout();
            this.tbSchool.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSchools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllSchools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllSchools)).BeginInit();
            this.tbEvents.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEventAgeLimit)).BeginInit();
            this.tbPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEducationZones)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFBE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilteredPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFilteredPlayersOnEvent)).BeginInit();
            this.tabPageEventsManagement.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrentPlayerEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventsBelongToPlayer)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrentPlayerNewEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventsDoesNotBelongToPlayer)).BeginInit();
            this.tabPageReports.SuspendLayout();
            this.toolStripStatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFilterByPlayerEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherReportPath)).BeginInit();
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
            this.tcMainForm.Controls.Add(this.tabPageEventsManagement);
            this.tcMainForm.Controls.Add(this.tabPageReports);
            this.tcMainForm.ImageList = this.imageListForTabs;
            this.tcMainForm.Location = new System.Drawing.Point(0, 9);
            this.tcMainForm.Margin = new System.Windows.Forms.Padding(0);
            this.tcMainForm.Name = "tcMainForm";
            this.tcMainForm.Padding = new System.Drawing.Point(0, 0);
            this.tcMainForm.SelectedIndex = 0;
            this.tcMainForm.Size = new System.Drawing.Size(1033, 683);
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
            this.tbSchool.Location = new System.Drawing.Point(4, 25);
            this.tbSchool.Margin = new System.Windows.Forms.Padding(4);
            this.tbSchool.Name = "tbSchool";
            this.tbSchool.Size = new System.Drawing.Size(1025, 654);
            this.tbSchool.TabIndex = 2;
            this.tbSchool.Text = "Schools";
            this.tbSchool.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(699, 641);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(343, 635);
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
            // dataGridViewAllSchools
            // 
            this.dataGridViewAllSchools.AllowUserToAddRows = false;
            this.dataGridViewAllSchools.AllowUserToDeleteRows = false;
            this.dataGridViewAllSchools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAllSchools.AutoGenerateColumns = false;
            this.dataGridViewAllSchools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllSchools.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn2});
            this.dataGridViewAllSchools.DataSource = this.bindingSourceAllSchools;
            this.dataGridViewAllSchools.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAllSchools.Location = new System.Drawing.Point(352, 3);
            this.dataGridViewAllSchools.MultiSelect = false;
            this.dataGridViewAllSchools.Name = "dataGridViewAllSchools";
            this.dataGridViewAllSchools.ReadOnly = true;
            this.dataGridViewAllSchools.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewAllSchools.RowTemplate.Height = 28;
            this.dataGridViewAllSchools.Size = new System.Drawing.Size(344, 635);
            this.dataGridViewAllSchools.TabIndex = 13;
            this.dataGridViewAllSchools.TabStop = false;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // bindingSourceAllSchools
            // 
            this.bindingSourceAllSchools.DataSource = typeof(SportsMeet.Models.School);
            // 
            // tbNewSchoolName
            // 
            this.tbNewSchoolName.Enabled = false;
            this.tbNewSchoolName.Location = new System.Drawing.Point(164, 35);
            this.tbNewSchoolName.Name = "tbNewSchoolName";
            this.tbNewSchoolName.Size = new System.Drawing.Size(139, 22);
            this.tbNewSchoolName.TabIndex = 12;
            this.tbNewSchoolName.TextChanged += new System.EventHandler(this.tbNewSchoolName_TextChanged);
            // 
            // lblNewSchoolName
            // 
            this.lblNewSchoolName.AutoSize = true;
            this.lblNewSchoolName.Location = new System.Drawing.Point(3, 38);
            this.lblNewSchoolName.Name = "lblNewSchoolName";
            this.lblNewSchoolName.Size = new System.Drawing.Size(123, 17);
            this.lblNewSchoolName.TabIndex = 11;
            this.lblNewSchoolName.Text = "New School Name";
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
            this.tbSchoolName.Location = new System.Drawing.Point(164, 7);
            this.tbSchoolName.Margin = new System.Windows.Forms.Padding(6);
            this.tbSchoolName.Name = "tbSchoolName";
            this.tbSchoolName.Size = new System.Drawing.Size(139, 22);
            this.tbSchoolName.TabIndex = 0;
            this.tbSchoolName.TextChanged += new System.EventHandler(this.tbSchoolName_TextChanged);
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Location = new System.Drawing.Point(6, 10);
            this.lblSchoolName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(92, 17);
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
            this.tbEvents.Location = new System.Drawing.Point(4, 25);
            this.tbEvents.Margin = new System.Windows.Forms.Padding(0);
            this.tbEvents.Name = "tbEvents";
            this.tbEvents.Size = new System.Drawing.Size(1025, 654);
            this.tbEvents.TabIndex = 0;
            this.tbEvents.Text = "Events";
            this.tbEvents.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(671, 648);
            this.tableLayoutPanel1.TabIndex = 15;
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
            this.dataGridViewAllEvents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAllEvents.Location = new System.Drawing.Point(338, 3);
            this.dataGridViewAllEvents.Name = "dataGridViewAllEvents";
            this.dataGridViewAllEvents.RowTemplate.Height = 28;
            this.dataGridViewAllEvents.Size = new System.Drawing.Size(330, 642);
            this.dataGridViewAllEvents.TabIndex = 14;
            this.dataGridViewAllEvents.TabStop = false;
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
            // bindingSourceAllEvents
            // 
            this.bindingSourceAllEvents.DataSource = typeof(SportsMeet.Models.Event);
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
            this.dataGridViewEvents.Size = new System.Drawing.Size(329, 642);
            this.dataGridViewEvents.TabIndex = 8;
            this.dataGridViewEvents.TabStop = false;
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
            // bindingSourceEvents
            // 
            this.bindingSourceEvents.DataSource = typeof(SportsMeet.Models.Event);
            this.bindingSourceEvents.Sort = "Number";
            // 
            // btnEeventsTabAddPlayers
            // 
            this.btnEeventsTabAddPlayers.Location = new System.Drawing.Point(96, 252);
            this.btnEeventsTabAddPlayers.Margin = new System.Windows.Forms.Padding(6);
            this.btnEeventsTabAddPlayers.Name = "btnEeventsTabAddPlayers";
            this.btnEeventsTabAddPlayers.Size = new System.Drawing.Size(170, 28);
            this.btnEeventsTabAddPlayers.TabIndex = 13;
            this.btnEeventsTabAddPlayers.Text = "Player Events Management ";
            this.btnEeventsTabAddPlayers.UseVisualStyleBackColor = true;
            this.btnEeventsTabAddPlayers.Click += new System.EventHandler(this.btnEeventsTabAddPlayers_Click);
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
            this.comboBoxEventsSex.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEventsSex.TabIndex = 3;
            // 
            // labelEventsSex
            // 
            this.labelEventsSex.AutoSize = true;
            this.labelEventsSex.Location = new System.Drawing.Point(8, 105);
            this.labelEventsSex.Name = "labelEventsSex";
            this.labelEventsSex.Size = new System.Drawing.Size(56, 17);
            this.labelEventsSex.TabIndex = 9;
            this.labelEventsSex.Text = "Gender";
            // 
            // numericUpDownEventAgeLimit
            // 
            this.numericUpDownEventAgeLimit.Location = new System.Drawing.Point(109, 71);
            this.numericUpDownEventAgeLimit.Name = "numericUpDownEventAgeLimit";
            this.numericUpDownEventAgeLimit.Size = new System.Drawing.Size(120, 22);
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
            this.labelEventsAgeLimit.Size = new System.Drawing.Size(66, 17);
            this.labelEventsAgeLimit.TabIndex = 6;
            this.labelEventsAgeLimit.Text = "Age Limit";
            // 
            // tbNewEventsName
            // 
            this.tbNewEventsName.Location = new System.Drawing.Point(109, 41);
            this.tbNewEventsName.Margin = new System.Windows.Forms.Padding(6);
            this.tbNewEventsName.Name = "tbNewEventsName";
            this.tbNewEventsName.Size = new System.Drawing.Size(196, 22);
            this.tbNewEventsName.TabIndex = 1;
            // 
            // tbNewEventsNumber
            // 
            this.tbNewEventsNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbNewEventsNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbNewEventsNumber.Location = new System.Drawing.Point(109, 11);
            this.tbNewEventsNumber.Margin = new System.Windows.Forms.Padding(6);
            this.tbNewEventsNumber.Name = "tbNewEventsNumber";
            this.tbNewEventsNumber.Size = new System.Drawing.Size(196, 22);
            this.tbNewEventsNumber.TabIndex = 0;
            this.tbNewEventsNumber.TextChanged += new System.EventHandler(this.EventsNumberTextChanged);
            // 
            // lblNewEventsName
            // 
            this.lblNewEventsName.AutoSize = true;
            this.lblNewEventsName.Location = new System.Drawing.Point(8, 45);
            this.lblNewEventsName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNewEventsName.Name = "lblNewEventsName";
            this.lblNewEventsName.Size = new System.Drawing.Size(85, 17);
            this.lblNewEventsName.TabIndex = 2;
            this.lblNewEventsName.Text = "Event Name";
            // 
            // lblNewEventsNumber
            // 
            this.lblNewEventsNumber.AutoSize = true;
            this.lblNewEventsNumber.Location = new System.Drawing.Point(7, 15);
            this.lblNewEventsNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNewEventsNumber.Name = "lblNewEventsNumber";
            this.lblNewEventsNumber.Size = new System.Drawing.Size(98, 17);
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
            this.tbPlayers.Controls.Add(this.comboBoxEducationZones);
            this.tbPlayers.Controls.Add(this.label4);
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
            this.tbPlayers.Location = new System.Drawing.Point(4, 25);
            this.tbPlayers.Margin = new System.Windows.Forms.Padding(6);
            this.tbPlayers.Name = "tbPlayers";
            this.tbPlayers.Padding = new System.Windows.Forms.Padding(6);
            this.tbPlayers.Size = new System.Drawing.Size(1025, 654);
            this.tbPlayers.TabIndex = 1;
            this.tbPlayers.Text = "Players";
            this.tbPlayers.UseVisualStyleBackColor = true;
            // 
            // comboBoxEducationZones
            // 
            this.comboBoxEducationZones.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxEducationZones.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEducationZones.DataSource = this.bindingSourceEducationZones;
            this.comboBoxEducationZones.DisplayMember = "Name";
            this.comboBoxEducationZones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEducationZones.FormattingEnabled = true;
            this.comboBoxEducationZones.Location = new System.Drawing.Point(105, 283);
            this.comboBoxEducationZones.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxEducationZones.Name = "comboBoxEducationZones";
            this.comboBoxEducationZones.Size = new System.Drawing.Size(180, 24);
            this.comboBoxEducationZones.TabIndex = 7;
            // 
            // bindingSourceEducationZones
            // 
            this.bindingSourceEducationZones.DataSource = typeof(SportsMeet.Models.EducationZone);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 287);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Education Zone";
            // 
            // textBoxPlayerSearch
            // 
            this.textBoxPlayerSearch.Location = new System.Drawing.Point(352, 39);
            this.textBoxPlayerSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPlayerSearch.Name = "textBoxPlayerSearch";
            this.textBoxPlayerSearch.Size = new System.Drawing.Size(545, 22);
            this.textBoxPlayerSearch.TabIndex = 40;
            this.textBoxPlayerSearch.TabStop = false;
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
            this.checkBoxDeleteSelection.Size = new System.Drawing.Size(119, 27);
            this.checkBoxDeleteSelection.TabIndex = 39;
            this.checkBoxDeleteSelection.TabStop = false;
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
            this.checkBoxLoadSelection.Size = new System.Drawing.Size(110, 27);
            this.checkBoxLoadSelection.TabIndex = 38;
            this.checkBoxLoadSelection.TabStop = false;
            this.checkBoxLoadSelection.Text = "Load selection";
            this.checkBoxLoadSelection.UseVisualStyleBackColor = true;
            this.checkBoxLoadSelection.CheckedChanged += new System.EventHandler(this.checkBoxLoadSelection_CheckedChanged);
            // 
            // checkBoxAddtoanEvent
            // 
            this.checkBoxAddtoanEvent.AutoSize = true;
            this.checkBoxAddtoanEvent.Location = new System.Drawing.Point(105, 353);
            this.checkBoxAddtoanEvent.Name = "checkBoxAddtoanEvent";
            this.checkBoxAddtoanEvent.Size = new System.Drawing.Size(131, 21);
            this.checkBoxAddtoanEvent.TabIndex = 8;
            this.checkBoxAddtoanEvent.Text = "Add to an Event";
            this.checkBoxAddtoanEvent.UseVisualStyleBackColor = true;
            // 
            // btnAddEventsToPlayer
            // 
            this.btnAddEventsToPlayer.Location = new System.Drawing.Point(105, 377);
            this.btnAddEventsToPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEventsToPlayer.Name = "btnAddEventsToPlayer";
            this.btnAddEventsToPlayer.Size = new System.Drawing.Size(180, 28);
            this.btnAddEventsToPlayer.TabIndex = 9;
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
            this.btnPlayerEdit.TabIndex = 11;
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
            this.btnDeletePlayer.TabIndex = 12;
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
            this.dataGridViewPlayers.Size = new System.Drawing.Size(598, 575);
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
            this.numericUpDownAge.Size = new System.Drawing.Size(120, 22);
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
            this.lblDistrict.Location = new System.Drawing.Point(8, 249);
            this.lblDistrict.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(63, 17);
            this.lblDistrict.TabIndex = 24;
            this.lblDistrict.Text = "Province";
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
            this.cbxDistrict.Size = new System.Drawing.Size(180, 24);
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
            this.cbxSchool.Size = new System.Drawing.Size(180, 24);
            this.cbxSchool.TabIndex = 3;
            // 
            // bindingSourceSchoolsFixed
            // 
            this.bindingSourceSchoolsFixed.DataSource = typeof(SportsMeet.Models.School);
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Location = new System.Drawing.Point(8, 144);
            this.lblSchool.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(51, 17);
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
            this.cbxGender.Size = new System.Drawing.Size(120, 24);
            this.cbxGender.TabIndex = 5;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(8, 214);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 17);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(8, 179);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(33, 17);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Age";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(8, 109);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(8, 74);
            this.lbFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(76, 17);
            this.lbFirstName.TabIndex = 7;
            this.lbFirstName.Text = "First Name";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(105, 106);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(212, 22);
            this.tbLastName.TabIndex = 2;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(105, 71);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(212, 22);
            this.tbFirstName.TabIndex = 1;
            // 
            // lblPlayerNumber
            // 
            this.lblPlayerNumber.AutoSize = true;
            this.lblPlayerNumber.Location = new System.Drawing.Point(8, 39);
            this.lblPlayerNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerNumber.Name = "lblPlayerNumber";
            this.lblPlayerNumber.Size = new System.Drawing.Size(102, 17);
            this.lblPlayerNumber.TabIndex = 2;
            this.lblPlayerNumber.Text = "Player Number";
            // 
            // tbPlayerNumber
            // 
            this.tbPlayerNumber.Location = new System.Drawing.Point(105, 36);
            this.tbPlayerNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbPlayerNumber.Name = "tbPlayerNumber";
            this.tbPlayerNumber.Size = new System.Drawing.Size(212, 22);
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
            this.tbFilterByPlayer.Controls.Add(this.labelEducationZoneFBP);
            this.tbFilterByPlayer.Controls.Add(this.label5);
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
            this.tbFilterByPlayer.Location = new System.Drawing.Point(4, 25);
            this.tbFilterByPlayer.Margin = new System.Windows.Forms.Padding(6);
            this.tbFilterByPlayer.Name = "tbFilterByPlayer";
            this.tbFilterByPlayer.Padding = new System.Windows.Forms.Padding(6);
            this.tbFilterByPlayer.Size = new System.Drawing.Size(1025, 654);
            this.tbFilterByPlayer.TabIndex = 3;
            this.tbFilterByPlayer.Text = "Filter By Player";
            this.tbFilterByPlayer.UseVisualStyleBackColor = true;
            // 
            // labelEducationZoneFBP
            // 
            this.labelEducationZoneFBP.AutoSize = true;
            this.labelEducationZoneFBP.Location = new System.Drawing.Point(144, 92);
            this.labelEducationZoneFBP.Name = "labelEducationZoneFBP";
            this.labelEducationZoneFBP.Size = new System.Drawing.Size(39, 17);
            this.labelEducationZoneFBP.TabIndex = 15;
            this.labelEducationZoneFBP.Text = "zone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Education Zone";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Player Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Player Details";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Players";
            // 
            // lblFilterByPlayerDistrictOutput
            // 
            this.lblFilterByPlayerDistrictOutput.AutoSize = true;
            this.lblFilterByPlayerDistrictOutput.Location = new System.Drawing.Point(142, 70);
            this.lblFilterByPlayerDistrictOutput.Name = "lblFilterByPlayerDistrictOutput";
            this.lblFilterByPlayerDistrictOutput.Size = new System.Drawing.Size(49, 17);
            this.lblFilterByPlayerDistrictOutput.TabIndex = 10;
            this.lblFilterByPlayerDistrictOutput.Text = "district";
            // 
            // lblFilterByPlayerSchoolOutput
            // 
            this.lblFilterByPlayerSchoolOutput.AutoSize = true;
            this.lblFilterByPlayerSchoolOutput.Location = new System.Drawing.Point(142, 48);
            this.lblFilterByPlayerSchoolOutput.Name = "lblFilterByPlayerSchoolOutput";
            this.lblFilterByPlayerSchoolOutput.Size = new System.Drawing.Size(49, 17);
            this.lblFilterByPlayerSchoolOutput.TabIndex = 9;
            this.lblFilterByPlayerSchoolOutput.Text = "school";
            // 
            // lblFilterByPlayerNameOutput
            // 
            this.lblFilterByPlayerNameOutput.AutoSize = true;
            this.lblFilterByPlayerNameOutput.Location = new System.Drawing.Point(142, 26);
            this.lblFilterByPlayerNameOutput.Name = "lblFilterByPlayerNameOutput";
            this.lblFilterByPlayerNameOutput.Size = new System.Drawing.Size(43, 17);
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
            this.genderDataGridViewTextBoxColumn1,
            this.AgeLimit});
            this.dataGridViewEventsOfPlaye.DataSource = this.bindingSourceFilteredEventsOnPlayers;
            this.dataGridViewEventsOfPlaye.Location = new System.Drawing.Point(28, 154);
            this.dataGridViewEventsOfPlaye.Name = "dataGridViewEventsOfPlaye";
            this.dataGridViewEventsOfPlaye.Size = new System.Drawing.Size(308, 533);
            this.dataGridViewEventsOfPlaye.TabIndex = 7;
            this.dataGridViewEventsOfPlaye.TabStop = false;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            // 
            // genderDataGridViewTextBoxColumn1
            // 
            this.genderDataGridViewTextBoxColumn1.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn1.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn1.Name = "genderDataGridViewTextBoxColumn1";
            this.genderDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // AgeLimit
            // 
            this.AgeLimit.DataPropertyName = "AgeLimit";
            this.AgeLimit.HeaderText = "Age Limit";
            this.AgeLimit.Name = "AgeLimit";
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
            this.dataGridPlayerFiltering.Location = new System.Drawing.Point(342, 92);
            this.dataGridPlayerFiltering.Name = "dataGridPlayerFiltering";
            this.dataGridPlayerFiltering.Size = new System.Drawing.Size(676, 559);
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
            this.lblFilterByPlayerEvents.Location = new System.Drawing.Point(13, 131);
            this.lblFilterByPlayerEvents.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFilterByPlayerEvents.Name = "lblFilterByPlayerEvents";
            this.lblFilterByPlayerEvents.Size = new System.Drawing.Size(51, 17);
            this.lblFilterByPlayerEvents.TabIndex = 1;
            this.lblFilterByPlayerEvents.Text = "Events";
            // 
            // lblFilterByPlayerDistrict
            // 
            this.lblFilterByPlayerDistrict.AutoSize = true;
            this.lblFilterByPlayerDistrict.Location = new System.Drawing.Point(13, 70);
            this.lblFilterByPlayerDistrict.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFilterByPlayerDistrict.Name = "lblFilterByPlayerDistrict";
            this.lblFilterByPlayerDistrict.Size = new System.Drawing.Size(51, 17);
            this.lblFilterByPlayerDistrict.TabIndex = 4;
            this.lblFilterByPlayerDistrict.Text = "District";
            // 
            // lblFilterByPlayerSchool
            // 
            this.lblFilterByPlayerSchool.AutoSize = true;
            this.lblFilterByPlayerSchool.Location = new System.Drawing.Point(12, 48);
            this.lblFilterByPlayerSchool.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFilterByPlayerSchool.Name = "lblFilterByPlayerSchool";
            this.lblFilterByPlayerSchool.Size = new System.Drawing.Size(51, 17);
            this.lblFilterByPlayerSchool.TabIndex = 3;
            this.lblFilterByPlayerSchool.Text = "School";
            // 
            // lblFilerByPlayerName
            // 
            this.lblFilerByPlayerName.AutoSize = true;
            this.lblFilerByPlayerName.Location = new System.Drawing.Point(13, 26);
            this.lblFilerByPlayerName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFilerByPlayerName.Name = "lblFilerByPlayerName";
            this.lblFilerByPlayerName.Size = new System.Drawing.Size(45, 17);
            this.lblFilerByPlayerName.TabIndex = 2;
            this.lblFilerByPlayerName.Text = "Name";
            // 
            // tbFilterByPlayersNumber
            // 
            this.tbFilterByPlayersNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilterByPlayersNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbFilterByPlayersNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbFilterByPlayersNumber.Location = new System.Drawing.Point(341, 28);
            this.tbFilterByPlayersNumber.Margin = new System.Windows.Forms.Padding(6);
            this.tbFilterByPlayersNumber.Name = "tbFilterByPlayersNumber";
            this.tbFilterByPlayersNumber.Size = new System.Drawing.Size(672, 22);
            this.tbFilterByPlayersNumber.TabIndex = 0;
            this.tbFilterByPlayersNumber.TextChanged += new System.EventHandler(this.tbFilterByPlayersNumber_TextChanged);
            this.tbFilterByPlayersNumber.Leave += new System.EventHandler(this.tbPlayerSearch_Leave);
            // 
            // tbFilterByEvent
            // 
            this.tbFilterByEvent.Controls.Add(this.label8);
            this.tbFilterByEvent.Controls.Add(this.labelCurrentEventFBE);
            this.tbFilterByEvent.Controls.Add(this.label6);
            this.tbFilterByEvent.Controls.Add(this.dataGridViewFBE);
            this.tbFilterByEvent.Controls.Add(this.dataGridViewFilteredPlayers);
            this.tbFilterByEvent.Controls.Add(this.lblFIlterByEventPlayers);
            this.tbFilterByEvent.Controls.Add(this.tbFilterByEventEventNumber);
            this.tbFilterByEvent.Controls.Add(this.lblFilterByEventEventNumber);
            this.tbFilterByEvent.Location = new System.Drawing.Point(4, 25);
            this.tbFilterByEvent.Margin = new System.Windows.Forms.Padding(6);
            this.tbFilterByEvent.Name = "tbFilterByEvent";
            this.tbFilterByEvent.Padding = new System.Windows.Forms.Padding(6);
            this.tbFilterByEvent.Size = new System.Drawing.Size(1025, 654);
            this.tbFilterByEvent.TabIndex = 4;
            this.tbFilterByEvent.Text = "Filter By Event";
            this.tbFilterByEvent.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Current Event :";
            // 
            // labelCurrentEventFBE
            // 
            this.labelCurrentEventFBE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentEventFBE.AutoSize = true;
            this.labelCurrentEventFBE.Location = new System.Drawing.Point(116, 73);
            this.labelCurrentEventFBE.Name = "labelCurrentEventFBE";
            this.labelCurrentEventFBE.Size = new System.Drawing.Size(51, 17);
            this.labelCurrentEventFBE.TabIndex = 6;
            this.labelCurrentEventFBE.Text = "Events";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Events";
            // 
            // dataGridViewFBE
            // 
            this.dataGridViewFBE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFBE.AutoGenerateColumns = false;
            this.dataGridViewFBE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFBE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn4,
            this.fullNameDataGridViewTextBoxColumn});
            this.dataGridViewFBE.DataSource = this.bindingSourceAllEvents;
            this.dataGridViewFBE.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewFBE.Location = new System.Drawing.Point(12, 117);
            this.dataGridViewFBE.Name = "dataGridViewFBE";
            this.dataGridViewFBE.RowTemplate.Height = 24;
            this.dataGridViewFBE.Size = new System.Drawing.Size(301, 528);
            this.dataGridViewFBE.TabIndex = 4;
            this.dataGridViewFBE.TabStop = false;
            this.dataGridViewFBE.SelectionChanged += new System.EventHandler(this.dataGridViewFBE_SelectionChanged);
            // 
            // numberDataGridViewTextBoxColumn4
            // 
            this.numberDataGridViewTextBoxColumn4.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn4.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn4.Name = "numberDataGridViewTextBoxColumn4";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewFilteredPlayers
            // 
            this.dataGridViewFilteredPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFilteredPlayers.AutoGenerateColumns = false;
            this.dataGridViewFilteredPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilteredPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn3,
            this.firstNameDataGridViewTextBoxColumn2,
            this.lastNameDataGridViewTextBoxColumn2,
            this.ageDataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewFilteredPlayers.DataSource = this.bindingSourceFilteredPlayersOnEvent;
            this.dataGridViewFilteredPlayers.Location = new System.Drawing.Point(319, 27);
            this.dataGridViewFilteredPlayers.Name = "dataGridViewFilteredPlayers";
            this.dataGridViewFilteredPlayers.Size = new System.Drawing.Size(697, 618);
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
            // lblFIlterByEventPlayers
            // 
            this.lblFIlterByEventPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFIlterByEventPlayers.AutoSize = true;
            this.lblFIlterByEventPlayers.Location = new System.Drawing.Point(316, 6);
            this.lblFIlterByEventPlayers.Name = "lblFIlterByEventPlayers";
            this.lblFIlterByEventPlayers.Size = new System.Drawing.Size(55, 17);
            this.lblFIlterByEventPlayers.TabIndex = 2;
            this.lblFIlterByEventPlayers.Text = "Players";
            // 
            // tbFilterByEventEventNumber
            // 
            this.tbFilterByEventEventNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbFilterByEventEventNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbFilterByEventEventNumber.Location = new System.Drawing.Point(125, 24);
            this.tbFilterByEventEventNumber.Name = "tbFilterByEventEventNumber";
            this.tbFilterByEventEventNumber.Size = new System.Drawing.Size(178, 22);
            this.tbFilterByEventEventNumber.TabIndex = 0;
            this.tbFilterByEventEventNumber.TextChanged += new System.EventHandler(this.tbFilterByEventEventNumber_TextChanged);
            // 
            // lblFilterByEventEventNumber
            // 
            this.lblFilterByEventEventNumber.AutoSize = true;
            this.lblFilterByEventEventNumber.Location = new System.Drawing.Point(9, 27);
            this.lblFilterByEventEventNumber.Name = "lblFilterByEventEventNumber";
            this.lblFilterByEventEventNumber.Size = new System.Drawing.Size(98, 17);
            this.lblFilterByEventEventNumber.TabIndex = 0;
            this.lblFilterByEventEventNumber.Text = "Event Number";
            // 
            // tabPageEventsManagement
            // 
            this.tabPageEventsManagement.Controls.Add(this.tableLayoutPanel3);
            this.tabPageEventsManagement.Controls.Add(this.btnChangePlayerPlayerEventsMgt);
            this.tabPageEventsManagement.Controls.Add(this.label7);
            this.tabPageEventsManagement.Controls.Add(this.label9);
            this.tabPageEventsManagement.Controls.Add(this.labelAddEventsPlayerAge);
            this.tabPageEventsManagement.Controls.Add(this.label10);
            this.tabPageEventsManagement.Controls.Add(this.labelAddEventsPlayerGender);
            this.tabPageEventsManagement.Controls.Add(this.label11);
            this.tabPageEventsManagement.Controls.Add(this.labelAddEventsPlayerFullName);
            this.tabPageEventsManagement.Controls.Add(this.labelAddEventsPlayerNumber);
            this.tabPageEventsManagement.Location = new System.Drawing.Point(4, 25);
            this.tabPageEventsManagement.Name = "tabPageEventsManagement";
            this.tabPageEventsManagement.Size = new System.Drawing.Size(1025, 654);
            this.tabPageEventsManagement.TabIndex = 5;
            this.tabPageEventsManagement.Text = "Events Management";
            this.tabPageEventsManagement.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridViewCurrentPlayerEvents, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataGridViewCurrentPlayerNewEvents, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.playerevents, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 154);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1011, 497);
            this.tableLayoutPanel3.TabIndex = 30;
            // 
            // dataGridViewCurrentPlayerEvents
            // 
            this.dataGridViewCurrentPlayerEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCurrentPlayerEvents.AutoGenerateColumns = false;
            this.dataGridViewCurrentPlayerEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCurrentPlayerEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn7,
            this.nameDataGridViewTextBoxColumn5,
            this.genderDataGridViewTextBoxColumn4,
            this.ageLimitDataGridViewTextBoxColumn3});
            this.dataGridViewCurrentPlayerEvents.DataSource = this.bindingSourceEventsBelongToPlayer;
            this.dataGridViewCurrentPlayerEvents.Location = new System.Drawing.Point(3, 43);
            this.dataGridViewCurrentPlayerEvents.Name = "dataGridViewCurrentPlayerEvents";
            this.dataGridViewCurrentPlayerEvents.RowTemplate.Height = 28;
            this.dataGridViewCurrentPlayerEvents.Size = new System.Drawing.Size(448, 451);
            this.dataGridViewCurrentPlayerEvents.TabIndex = 1;
            // 
            // numberDataGridViewTextBoxColumn7
            // 
            this.numberDataGridViewTextBoxColumn7.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn7.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn7.Name = "numberDataGridViewTextBoxColumn7";
            // 
            // nameDataGridViewTextBoxColumn5
            // 
            this.nameDataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn5.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn5.Name = "nameDataGridViewTextBoxColumn5";
            // 
            // genderDataGridViewTextBoxColumn4
            // 
            this.genderDataGridViewTextBoxColumn4.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn4.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn4.Name = "genderDataGridViewTextBoxColumn4";
            this.genderDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // ageLimitDataGridViewTextBoxColumn3
            // 
            this.ageLimitDataGridViewTextBoxColumn3.DataPropertyName = "AgeLimit";
            this.ageLimitDataGridViewTextBoxColumn3.HeaderText = "AgeLimit";
            this.ageLimitDataGridViewTextBoxColumn3.Name = "ageLimitDataGridViewTextBoxColumn3";
            // 
            // bindingSourceEventsBelongToPlayer
            // 
            this.bindingSourceEventsBelongToPlayer.DataSource = typeof(SportsMeet.Models.Event);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnRemoveEventFromPlayer, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(457, 50);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(95, 436);
            this.tableLayoutPanel4.TabIndex = 31;
            // 
            // btnRemoveEventFromPlayer
            // 
            this.btnRemoveEventFromPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveEventFromPlayer.Location = new System.Drawing.Point(13, 91);
            this.btnRemoveEventFromPlayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveEventFromPlayer.Name = "btnRemoveEventFromPlayer";
            this.btnRemoveEventFromPlayer.Size = new System.Drawing.Size(69, 35);
            this.btnRemoveEventFromPlayer.TabIndex = 17;
            this.btnRemoveEventFromPlayer.Text = ">>";
            this.btnRemoveEventFromPlayer.UseVisualStyleBackColor = true;
            this.btnRemoveEventFromPlayer.Click += new System.EventHandler(this.btnRemoveEventFromPlayer_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(13, 309);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(742, 11);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "New events";
            // 
            // dataGridViewCurrentPlayerNewEvents
            // 
            this.dataGridViewCurrentPlayerNewEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCurrentPlayerNewEvents.AutoGenerateColumns = false;
            this.dataGridViewCurrentPlayerNewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCurrentPlayerNewEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn6,
            this.nameDataGridViewTextBoxColumn4,
            this.genderDataGridViewTextBoxColumn3,
            this.ageLimitDataGridViewTextBoxColumn2});
            this.dataGridViewCurrentPlayerNewEvents.DataSource = this.bindingSourceEventsDoesNotBelongToPlayer;
            this.dataGridViewCurrentPlayerNewEvents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCurrentPlayerNewEvents.Location = new System.Drawing.Point(558, 43);
            this.dataGridViewCurrentPlayerNewEvents.Name = "dataGridViewCurrentPlayerNewEvents";
            this.dataGridViewCurrentPlayerNewEvents.RowTemplate.Height = 28;
            this.dataGridViewCurrentPlayerNewEvents.Size = new System.Drawing.Size(450, 451);
            this.dataGridViewCurrentPlayerNewEvents.TabIndex = 0;
            // 
            // numberDataGridViewTextBoxColumn6
            // 
            this.numberDataGridViewTextBoxColumn6.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn6.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn6.Name = "numberDataGridViewTextBoxColumn6";
            // 
            // nameDataGridViewTextBoxColumn4
            // 
            this.nameDataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn4.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn4.Name = "nameDataGridViewTextBoxColumn4";
            // 
            // genderDataGridViewTextBoxColumn3
            // 
            this.genderDataGridViewTextBoxColumn3.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn3.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn3.Name = "genderDataGridViewTextBoxColumn3";
            this.genderDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // ageLimitDataGridViewTextBoxColumn2
            // 
            this.ageLimitDataGridViewTextBoxColumn2.DataPropertyName = "AgeLimit";
            this.ageLimitDataGridViewTextBoxColumn2.HeaderText = "AgeLimit";
            this.ageLimitDataGridViewTextBoxColumn2.Name = "ageLimitDataGridViewTextBoxColumn2";
            // 
            // bindingSourceEventsDoesNotBelongToPlayer
            // 
            this.bindingSourceEventsDoesNotBelongToPlayer.DataSource = typeof(SportsMeet.Models.Event);
            // 
            // playerevents
            // 
            this.playerevents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerevents.AutoSize = true;
            this.playerevents.Location = new System.Drawing.Point(155, 11);
            this.playerevents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerevents.Name = "playerevents";
            this.playerevents.Size = new System.Drawing.Size(144, 17);
            this.playerevents.TabIndex = 26;
            this.playerevents.Text = "Current player events";
            // 
            // btnChangePlayerPlayerEventsMgt
            // 
            this.btnChangePlayerPlayerEventsMgt.Location = new System.Drawing.Point(15, 111);
            this.btnChangePlayerPlayerEventsMgt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChangePlayerPlayerEventsMgt.Name = "btnChangePlayerPlayerEventsMgt";
            this.btnChangePlayerPlayerEventsMgt.Size = new System.Drawing.Size(158, 35);
            this.btnChangePlayerPlayerEventsMgt.TabIndex = 28;
            this.btnChangePlayerPlayerEventsMgt.Text = "Change Player";
            this.btnChangePlayerPlayerEventsMgt.UseVisualStyleBackColor = true;
            this.btnChangePlayerPlayerEventsMgt.Click += new System.EventHandler(this.btnChangePlayerPlayerEventsMgt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Player Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Full Name";
            // 
            // labelAddEventsPlayerAge
            // 
            this.labelAddEventsPlayerAge.AutoSize = true;
            this.labelAddEventsPlayerAge.Location = new System.Drawing.Point(135, 71);
            this.labelAddEventsPlayerAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddEventsPlayerAge.Name = "labelAddEventsPlayerAge";
            this.labelAddEventsPlayerAge.Size = new System.Drawing.Size(46, 17);
            this.labelAddEventsPlayerAge.TabIndex = 25;
            this.labelAddEventsPlayerAge.Text = "label7";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 70);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Age";
            // 
            // labelAddEventsPlayerGender
            // 
            this.labelAddEventsPlayerGender.AutoSize = true;
            this.labelAddEventsPlayerGender.Location = new System.Drawing.Point(135, 51);
            this.labelAddEventsPlayerGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddEventsPlayerGender.Name = "labelAddEventsPlayerGender";
            this.labelAddEventsPlayerGender.Size = new System.Drawing.Size(46, 17);
            this.labelAddEventsPlayerGender.TabIndex = 24;
            this.labelAddEventsPlayerGender.Text = "label6";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 50);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Gender";
            // 
            // labelAddEventsPlayerFullName
            // 
            this.labelAddEventsPlayerFullName.AutoSize = true;
            this.labelAddEventsPlayerFullName.Location = new System.Drawing.Point(135, 30);
            this.labelAddEventsPlayerFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddEventsPlayerFullName.Name = "labelAddEventsPlayerFullName";
            this.labelAddEventsPlayerFullName.Size = new System.Drawing.Size(46, 17);
            this.labelAddEventsPlayerFullName.TabIndex = 23;
            this.labelAddEventsPlayerFullName.Text = "label5";
            // 
            // labelAddEventsPlayerNumber
            // 
            this.labelAddEventsPlayerNumber.AutoSize = true;
            this.labelAddEventsPlayerNumber.Location = new System.Drawing.Point(135, 10);
            this.labelAddEventsPlayerNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddEventsPlayerNumber.Name = "labelAddEventsPlayerNumber";
            this.labelAddEventsPlayerNumber.Size = new System.Drawing.Size(46, 17);
            this.labelAddEventsPlayerNumber.TabIndex = 22;
            this.labelAddEventsPlayerNumber.Text = "label4";
            // 
            // tabPageReports
            // 
            this.tabPageReports.Controls.Add(this.progressBarReports);
            this.tabPageReports.Controls.Add(this.button4);
            this.tabPageReports.Controls.Add(this.button3);
            this.tabPageReports.Controls.Add(this.button2);
            this.tabPageReports.Controls.Add(this.buttonChangeReportFolder);
            this.tabPageReports.Controls.Add(this.treeViewSaveReportPath);
            this.tabPageReports.Controls.Add(this.label13);
            this.tabPageReports.Controls.Add(this.textBoxSaveReportPath);
            this.tabPageReports.Controls.Add(this.buttonReportPlayers);
            this.tabPageReports.Location = new System.Drawing.Point(4, 25);
            this.tabPageReports.Name = "tabPageReports";
            this.tabPageReports.Size = new System.Drawing.Size(1025, 654);
            this.tabPageReports.TabIndex = 6;
            this.tabPageReports.Text = "Reports";
            this.tabPageReports.UseVisualStyleBackColor = true;
            // 
            // progressBarReports
            // 
            this.progressBarReports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarReports.Location = new System.Drawing.Point(8, 529);
            this.progressBarReports.Name = "progressBarReports";
            this.progressBarReports.Size = new System.Drawing.Size(997, 23);
            this.progressBarReports.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.Location = new System.Drawing.Point(732, 572);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 56);
            this.button4.TabIndex = 7;
            this.button4.Text = "Report Players";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Location = new System.Drawing.Point(510, 572);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 56);
            this.button3.TabIndex = 6;
            this.button3.Text = "Report Events";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(288, 572);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 56);
            this.button2.TabIndex = 5;
            this.button2.Text = "Report Zones";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonChangeReportFolder
            // 
            this.buttonChangeReportFolder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonChangeReportFolder.Location = new System.Drawing.Point(930, 41);
            this.buttonChangeReportFolder.Name = "buttonChangeReportFolder";
            this.buttonChangeReportFolder.Size = new System.Drawing.Size(75, 30);
            this.buttonChangeReportFolder.TabIndex = 4;
            this.buttonChangeReportFolder.Text = "Browse";
            this.buttonChangeReportFolder.UseVisualStyleBackColor = true;
            this.buttonChangeReportFolder.Click += new System.EventHandler(this.buttonChangeReportFolder_Click);
            // 
            // treeViewSaveReportPath
            // 
            this.treeViewSaveReportPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewSaveReportPath.Location = new System.Drawing.Point(8, 75);
            this.treeViewSaveReportPath.Name = "treeViewSaveReportPath";
            this.treeViewSaveReportPath.Size = new System.Drawing.Size(997, 438);
            this.treeViewSaveReportPath.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Path";
            // 
            // textBoxSaveReportPath
            // 
            this.textBoxSaveReportPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSaveReportPath.Location = new System.Drawing.Point(66, 43);
            this.textBoxSaveReportPath.Name = "textBoxSaveReportPath";
            this.textBoxSaveReportPath.Size = new System.Drawing.Size(849, 22);
            this.textBoxSaveReportPath.TabIndex = 1;
            // 
            // buttonReportPlayers
            // 
            this.buttonReportPlayers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonReportPlayers.Location = new System.Drawing.Point(66, 572);
            this.buttonReportPlayers.Name = "buttonReportPlayers";
            this.buttonReportPlayers.Size = new System.Drawing.Size(182, 56);
            this.buttonReportPlayers.TabIndex = 0;
            this.buttonReportPlayers.Text = "Report Provinces";
            this.buttonReportPlayers.UseVisualStyleBackColor = true;
            this.buttonReportPlayers.Click += new System.EventHandler(this.buttonReportPlayers_Click);
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
            this.toolStripStatusBar.AutoSize = false;
            this.toolStripStatusBar.CanOverflow = false;
            this.toolStripStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            this.toolStripButtonAbout,
            this.toolStripSeparator5,
            this.toolStripDropDownButton1});
            this.toolStripStatusBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripStatusBar.Location = new System.Drawing.Point(0, 701);
            this.toolStripStatusBar.Name = "toolStripStatusBar";
            this.toolStripStatusBar.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripStatusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripStatusBar.Size = new System.Drawing.Size(1039, 71);
            this.toolStripStatusBar.Stretch = true;
            this.toolStripStatusBar.TabIndex = 1;
            this.toolStripStatusBar.Text = "toolStrip";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripLabel1.Size = new System.Drawing.Size(99, 68);
            this.toolStripLabel1.Text = "Total Players :";
            // 
            // toolStripLabelTotalPlayerCount
            // 
            this.toolStripLabelTotalPlayerCount.Name = "toolStripLabelTotalPlayerCount";
            this.toolStripLabelTotalPlayerCount.Size = new System.Drawing.Size(17, 68);
            this.toolStripLabelTotalPlayerCount.Text = "0";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 71);
            // 
            // toolStripLabelSchools
            // 
            this.toolStripLabelSchools.Name = "toolStripLabelSchools";
            this.toolStripLabelSchools.Size = new System.Drawing.Size(104, 68);
            this.toolStripLabelSchools.Text = "Total Schools :";
            // 
            // toolStripLabelSchoolCount
            // 
            this.toolStripLabelSchoolCount.Name = "toolStripLabelSchoolCount";
            this.toolStripLabelSchoolCount.Size = new System.Drawing.Size(17, 68);
            this.toolStripLabelSchoolCount.Text = "0";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 71);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(95, 68);
            this.toolStripLabel2.Text = "Total Events :";
            // 
            // toolStripLabelTotalEvents
            // 
            this.toolStripLabelTotalEvents.Name = "toolStripLabelTotalEvents";
            this.toolStripLabelTotalEvents.Size = new System.Drawing.Size(17, 68);
            this.toolStripLabelTotalEvents.Text = "0";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
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
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 71);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(54, 68);
            this.toolStripButtonAbout.Text = "About";
            this.toolStripButtonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 71);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExport,
            this.toolStripMenuItemImport});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(46, 68);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // toolStripMenuItemExport
            // 
            this.toolStripMenuItemExport.Name = "toolStripMenuItemExport";
            this.toolStripMenuItemExport.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItemExport.Text = "Export";
            this.toolStripMenuItemExport.Click += new System.EventHandler(this.toolStripMenuItemExport_Click);
            // 
            // toolStripMenuItemImport
            // 
            this.toolStripMenuItemImport.Name = "toolStripMenuItemImport";
            this.toolStripMenuItemImport.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItemImport.Text = "Import";
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
            // eventBindingSource1
            // 
            this.eventBindingSource1.DataSource = typeof(SportsMeet.Models.Event);
            // 
            // saveFileDialogSaveReports
            // 
            this.saveFileDialogSaveReports.FileName = "SportsMeet";
            this.saveFileDialogSaveReports.RestoreDirectory = true;
            // 
            // fileSystemWatcherReportPath
            // 
            this.fileSystemWatcherReportPath.EnableRaisingEvents = true;
            this.fileSystemWatcherReportPath.IncludeSubdirectories = true;
            this.fileSystemWatcherReportPath.SynchronizingObject = this;
            this.fileSystemWatcherReportPath.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcherReportPath_Changed);
            this.fileSystemWatcherReportPath.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcherReportPath_Changed);
            this.fileSystemWatcherReportPath.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcherReportPath_Changed);
            this.fileSystemWatcherReportPath.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcherReportPath_Renamed);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1039, 772);
            this.Controls.Add(this.toolStripStatusBar);
            this.Controls.Add(this.tcMainForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1057, 819);
            this.Name = "MainForm";
            this.Text = "Sports Meet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcMainForm.ResumeLayout(false);
            this.tbSchool.ResumeLayout(false);
            this.tbSchool.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSchools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllSchools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllSchools)).EndInit();
            this.tbEvents.ResumeLayout(false);
            this.tbEvents.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEventAgeLimit)).EndInit();
            this.tbPlayers.ResumeLayout(false);
            this.tbPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEducationZones)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFBE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilteredPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFilteredPlayersOnEvent)).EndInit();
            this.tabPageEventsManagement.ResumeLayout(false);
            this.tabPageEventsManagement.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrentPlayerEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventsBelongToPlayer)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrentPlayerNewEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventsDoesNotBelongToPlayer)).EndInit();
            this.tabPageReports.ResumeLayout(false);
            this.tabPageReports.PerformLayout();
            this.toolStripStatusBar.ResumeLayout(false);
            this.toolStripStatusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFilterByPlayerEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherReportPath)).EndInit();
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
        private StatusViewer statusViewer;
        private Timer statusTime;
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
        private ComboBox comboBoxEducationZones;
        private Label label4;
        private BindingSource bindingSourceEducationZones;
        private Label labelEducationZoneFBP;
        private Label label5;
        private DataGridView dataGridViewFBE;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private Label label6;
        private Label label8;
        private Label labelCurrentEventFBE;
        private TabPage tabPageEventsManagement;
        private DataGridView dataGridViewCurrentPlayerEvents;
        private DataGridView dataGridViewCurrentPlayerNewEvents;
        private Button button1;
        private Button btnRemoveEventFromPlayer;
        private Label playerevents;
        private Label label7;
        internal Label label9;
        private Label labelAddEventsPlayerAge;
        private Label label10;
        private Label labelAddEventsPlayerGender;
        private Label label11;
        private Label labelAddEventsPlayerFullName;
        private Label labelAddEventsPlayerNumber;
        private Button btnChangePlayerPlayerEventsMgt;
        private Label label12;
        private BindingSource bindingSourceEventsBelongToPlayer;
        private BindingSource bindingSourceEventsDoesNotBelongToPlayer;
        private TabPage tabPageReports;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn AgeLimit;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private BindingSource eventBindingSource1;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn ageLimitDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn ageLimitDataGridViewTextBoxColumn3;
        private Button buttonReportPlayers;
        private Button buttonChangeReportFolder;
        private TreeView treeViewSaveReportPath;
        private Label label13;
        private TextBox textBoxSaveReportPath;
        private Button button3;
        private Button button2;
        private Button button4;
        private SaveFileDialog saveFileDialogSaveReports;
        private ProgressBar progressBarReports;
        private System.IO.FileSystemWatcher fileSystemWatcherReportPath;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem toolStripMenuItemExport;
        private ToolStripMenuItem toolStripMenuItemImport;
    }
    
}
