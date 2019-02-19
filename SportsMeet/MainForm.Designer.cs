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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tcMainForm = new System.Windows.Forms.TabControl();
            this.tbPlayers = new System.Windows.Forms.TabPage();
            this.tbPlayerSearch = new System.Windows.Forms.TextBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.cbxDistrict = new System.Windows.Forms.ComboBox();
            this.cbxEvent = new System.Windows.Forms.ComboBox();
            this.tbEventNumber = new System.Windows.Forms.TextBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblEventNumber = new System.Windows.Forms.Label();
            this.cbxAgeUnder = new System.Windows.Forms.ComboBox();
            this.lblAgeUnder = new System.Windows.Forms.Label();
            this.cbxSchool = new System.Windows.Forms.ComboBox();
            this.lblSchool = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datetpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lstBoxPlayer = new System.Windows.Forms.ListBox();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.mtbAge = new System.Windows.Forms.MaskedTextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblPlayerNumber = new System.Windows.Forms.Label();
            this.tbPlayerNumber = new System.Windows.Forms.TextBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.tbEvents = new System.Windows.Forms.TabPage();
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbPlayersNumber = new System.Windows.Forms.TextBox();
            this.lblPlayersNumber = new System.Windows.Forms.Label();
            this.tbFilterByEvent = new System.Windows.Forms.TabPage();
            this.toolStripStatusBar = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelTotalPlayerCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.tcMainForm.SuspendLayout();
            this.tbPlayers.SuspendLayout();
            this.tbEvents.SuspendLayout();
            this.tbSchool.SuspendLayout();
            this.tbFilterByPlayer.SuspendLayout();
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
            this.tcMainForm.Location = new System.Drawing.Point(15, 15);
            this.tcMainForm.Margin = new System.Windows.Forms.Padding(0);
            this.tcMainForm.Name = "tcMainForm";
            this.tcMainForm.Padding = new System.Drawing.Point(0, 0);
            this.tcMainForm.SelectedIndex = 0;
            this.tcMainForm.Size = new System.Drawing.Size(1804, 781);
            this.tcMainForm.TabIndex = 0;
            // 
            // tbPlayers
            // 
            this.tbPlayers.Controls.Add(this.tbPlayerSearch);
            this.tbPlayers.Controls.Add(this.lblDistrict);
            this.tbPlayers.Controls.Add(this.cbxDistrict);
            this.tbPlayers.Controls.Add(this.cbxEvent);
            this.tbPlayers.Controls.Add(this.tbEventNumber);
            this.tbPlayers.Controls.Add(this.lblEvent);
            this.tbPlayers.Controls.Add(this.lblEventNumber);
            this.tbPlayers.Controls.Add(this.cbxAgeUnder);
            this.tbPlayers.Controls.Add(this.lblAgeUnder);
            this.tbPlayers.Controls.Add(this.cbxSchool);
            this.tbPlayers.Controls.Add(this.lblSchool);
            this.tbPlayers.Controls.Add(this.label1);
            this.tbPlayers.Controls.Add(this.datetpDateOfBirth);
            this.tbPlayers.Controls.Add(this.lstBoxPlayer);
            this.tbPlayers.Controls.Add(this.cbxGender);
            this.tbPlayers.Controls.Add(this.lblGender);
            this.tbPlayers.Controls.Add(this.lblAge);
            this.tbPlayers.Controls.Add(this.lblLastName);
            this.tbPlayers.Controls.Add(this.lbFirstName);
            this.tbPlayers.Controls.Add(this.mtbAge);
            this.tbPlayers.Controls.Add(this.tbLastName);
            this.tbPlayers.Controls.Add(this.tbFirstName);
            this.tbPlayers.Controls.Add(this.lblPlayerNumber);
            this.tbPlayers.Controls.Add(this.tbPlayerNumber);
            this.tbPlayers.Controls.Add(this.btnAddPlayer);
            this.tbPlayers.Location = new System.Drawing.Point(8, 43);
            this.tbPlayers.Margin = new System.Windows.Forms.Padding(6);
            this.tbPlayers.Name = "tbPlayers";
            this.tbPlayers.Padding = new System.Windows.Forms.Padding(6);
            this.tbPlayers.Size = new System.Drawing.Size(1788, 730);
            this.tbPlayers.TabIndex = 1;
            this.tbPlayers.Text = "Players";
            this.tbPlayers.UseVisualStyleBackColor = true;
            this.tbPlayers.Click += new System.EventHandler(this.tbPlayers_Click);
            // 
            // tbPlayerSearch
            // 
            this.tbPlayerSearch.Location = new System.Drawing.Point(804, 70);
            this.tbPlayerSearch.Name = "tbPlayerSearch";
            this.tbPlayerSearch.Size = new System.Drawing.Size(676, 31);
            this.tbPlayerSearch.TabIndex = 25;
            this.tbPlayerSearch.TextChanged += new System.EventHandler(this.tbPlayerSearch_TextChanged);
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Location = new System.Drawing.Point(448, 252);
            this.lblDistrict.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(78, 25);
            this.lblDistrict.TabIndex = 24;
            this.lblDistrict.Text = "District";
            // 
            // cbxDistrict
            // 
            this.cbxDistrict.FormattingEnabled = true;
            this.cbxDistrict.Items.AddRange(new object[] {
            "Matara",
            "Galle",
            "Hambanthota"});
            this.cbxDistrict.Location = new System.Drawing.Point(604, 237);
            this.cbxDistrict.Margin = new System.Windows.Forms.Padding(6);
            this.cbxDistrict.Name = "cbxDistrict";
            this.cbxDistrict.Size = new System.Drawing.Size(180, 33);
            this.cbxDistrict.TabIndex = 23;
            // 
            // cbxEvent
            // 
            this.cbxEvent.FormattingEnabled = true;
            this.cbxEvent.Location = new System.Drawing.Point(604, 123);
            this.cbxEvent.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEvent.Name = "cbxEvent";
            this.cbxEvent.Size = new System.Drawing.Size(180, 33);
            this.cbxEvent.TabIndex = 22;
            // 
            // tbEventNumber
            // 
            this.tbEventNumber.Location = new System.Drawing.Point(604, 71);
            this.tbEventNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbEventNumber.Name = "tbEventNumber";
            this.tbEventNumber.Size = new System.Drawing.Size(148, 31);
            this.tbEventNumber.TabIndex = 21;
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(448, 135);
            this.lblEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(67, 25);
            this.lblEvent.TabIndex = 20;
            this.lblEvent.Text = "Event";
            // 
            // lblEventNumber
            // 
            this.lblEventNumber.AutoSize = true;
            this.lblEventNumber.Location = new System.Drawing.Point(448, 79);
            this.lblEventNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventNumber.Name = "lblEventNumber";
            this.lblEventNumber.Size = new System.Drawing.Size(148, 25);
            this.lblEventNumber.TabIndex = 19;
            this.lblEventNumber.Text = "Event Number";
            // 
            // cbxAgeUnder
            // 
            this.cbxAgeUnder.FormattingEnabled = true;
            this.cbxAgeUnder.Items.AddRange(new object[] {
            "Under 13",
            "Under 15",
            "Under 17"});
            this.cbxAgeUnder.Location = new System.Drawing.Point(572, 306);
            this.cbxAgeUnder.Margin = new System.Windows.Forms.Padding(4);
            this.cbxAgeUnder.Name = "cbxAgeUnder";
            this.cbxAgeUnder.Size = new System.Drawing.Size(180, 33);
            this.cbxAgeUnder.TabIndex = 18;
            // 
            // lblAgeUnder
            // 
            this.lblAgeUnder.AutoSize = true;
            this.lblAgeUnder.Location = new System.Drawing.Point(394, 317);
            this.lblAgeUnder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgeUnder.Name = "lblAgeUnder";
            this.lblAgeUnder.Size = new System.Drawing.Size(114, 25);
            this.lblAgeUnder.TabIndex = 17;
            this.lblAgeUnder.Text = "Age Under";
            // 
            // cbxSchool
            // 
            this.cbxSchool.FormattingEnabled = true;
            this.cbxSchool.Items.AddRange(new object[] {
            "Test"});
            this.cbxSchool.Location = new System.Drawing.Point(222, 240);
            this.cbxSchool.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSchool.Name = "cbxSchool";
            this.cbxSchool.Size = new System.Drawing.Size(180, 33);
            this.cbxSchool.TabIndex = 16;
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Location = new System.Drawing.Point(44, 252);
            this.lblSchool.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(78, 25);
            this.lblSchool.TabIndex = 15;
            this.lblSchool.Text = "School";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 460);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Date of Birth";
            // 
            // datetpDateOfBirth
            // 
            this.datetpDateOfBirth.Enabled = false;
            this.datetpDateOfBirth.Location = new System.Drawing.Point(266, 456);
            this.datetpDateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.datetpDateOfBirth.Name = "datetpDateOfBirth";
            this.datetpDateOfBirth.Size = new System.Drawing.Size(356, 31);
            this.datetpDateOfBirth.TabIndex = 13;
            // 
            // lstBoxPlayer
            // 
            this.lstBoxPlayer.FormattingEnabled = true;
            this.lstBoxPlayer.ItemHeight = 25;
            this.lstBoxPlayer.Location = new System.Drawing.Point(804, 146);
            this.lstBoxPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.lstBoxPlayer.Name = "lstBoxPlayer";
            this.lstBoxPlayer.Size = new System.Drawing.Size(676, 504);
            this.lstBoxPlayer.TabIndex = 12;
            this.lstBoxPlayer.SelectedIndexChanged += new System.EventHandler(this.lstBoxPlayer_SelectedIndexChanged);
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxGender.Location = new System.Drawing.Point(266, 392);
            this.cbxGender.Margin = new System.Windows.Forms.Padding(4);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(120, 33);
            this.cbxGender.TabIndex = 11;
            this.cbxGender.Text = "Male";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(44, 396);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(83, 25);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(44, 317);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(50, 25);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Age";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(44, 192);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(115, 25);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(44, 135);
            this.lbFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(116, 25);
            this.lbFirstName.TabIndex = 7;
            this.lbFirstName.Text = "First Name";
            // 
            // mtbAge
            // 
            this.mtbAge.Location = new System.Drawing.Point(222, 310);
            this.mtbAge.Margin = new System.Windows.Forms.Padding(4);
            this.mtbAge.Mask = "00";
            this.mtbAge.Name = "mtbAge";
            this.mtbAge.Size = new System.Drawing.Size(100, 31);
            this.mtbAge.TabIndex = 6;
            this.mtbAge.ValidatingType = typeof(int);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(222, 185);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(212, 31);
            this.tbLastName.TabIndex = 4;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(222, 127);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(212, 31);
            this.tbFirstName.TabIndex = 3;
            // 
            // lblPlayerNumber
            // 
            this.lblPlayerNumber.AutoSize = true;
            this.lblPlayerNumber.Location = new System.Drawing.Point(44, 79);
            this.lblPlayerNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerNumber.Name = "lblPlayerNumber";
            this.lblPlayerNumber.Size = new System.Drawing.Size(154, 25);
            this.lblPlayerNumber.TabIndex = 2;
            this.lblPlayerNumber.Text = "Player Number";
            // 
            // tbPlayerNumber
            // 
            this.tbPlayerNumber.Location = new System.Drawing.Point(222, 71);
            this.tbPlayerNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbPlayerNumber.Name = "tbPlayerNumber";
            this.tbPlayerNumber.Size = new System.Drawing.Size(212, 31);
            this.tbPlayerNumber.TabIndex = 1;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(266, 554);
            this.btnAddPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(244, 54);
            this.btnAddPlayer.TabIndex = 0;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // tbEvents
            // 
            this.tbEvents.AutoScroll = true;
            this.tbEvents.Controls.Add(this.tbNewEventsName);
            this.tbEvents.Controls.Add(this.tbNewEventsNumber);
            this.tbEvents.Controls.Add(this.lblNewEventsName);
            this.tbEvents.Controls.Add(this.lblNewEventsNumber);
            this.tbEvents.Controls.Add(this.btnAddEvent);
            this.tbEvents.Location = new System.Drawing.Point(8, 43);
            this.tbEvents.Margin = new System.Windows.Forms.Padding(0);
            this.tbEvents.Name = "tbEvents";
            this.tbEvents.Size = new System.Drawing.Size(1767, 726);
            this.tbEvents.TabIndex = 0;
            this.tbEvents.Text = "Events";
            this.tbEvents.UseVisualStyleBackColor = true;
            // 
            // tbNewEventsName
            // 
            this.tbNewEventsName.Location = new System.Drawing.Point(336, 235);
            this.tbNewEventsName.Margin = new System.Windows.Forms.Padding(6);
            this.tbNewEventsName.Name = "tbNewEventsName";
            this.tbNewEventsName.Size = new System.Drawing.Size(196, 31);
            this.tbNewEventsName.TabIndex = 4;
            // 
            // tbNewEventsNumber
            // 
            this.tbNewEventsNumber.Location = new System.Drawing.Point(336, 158);
            this.tbNewEventsNumber.Margin = new System.Windows.Forms.Padding(6);
            this.tbNewEventsNumber.Name = "tbNewEventsNumber";
            this.tbNewEventsNumber.Size = new System.Drawing.Size(196, 31);
            this.tbNewEventsNumber.TabIndex = 3;
            // 
            // lblNewEventsName
            // 
            this.lblNewEventsName.AutoSize = true;
            this.lblNewEventsName.Location = new System.Drawing.Point(110, 240);
            this.lblNewEventsName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNewEventsName.Name = "lblNewEventsName";
            this.lblNewEventsName.Size = new System.Drawing.Size(192, 25);
            this.lblNewEventsName.TabIndex = 2;
            this.lblNewEventsName.Text = "New Event\'s Name";
            // 
            // lblNewEventsNumber
            // 
            this.lblNewEventsNumber.AutoSize = true;
            this.lblNewEventsNumber.Location = new System.Drawing.Point(110, 163);
            this.lblNewEventsNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNewEventsNumber.Name = "lblNewEventsNumber";
            this.lblNewEventsNumber.Size = new System.Drawing.Size(211, 25);
            this.lblNewEventsNumber.TabIndex = 1;
            this.lblNewEventsNumber.Text = "New Event\'s Number";
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(634, 563);
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
            this.tbSchool.Location = new System.Drawing.Point(8, 43);
            this.tbSchool.Margin = new System.Windows.Forms.Padding(4);
            this.tbSchool.Name = "tbSchool";
            this.tbSchool.Size = new System.Drawing.Size(1767, 726);
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
            this.cbxNewSchoolsDistrict.Location = new System.Drawing.Point(408, 254);
            this.cbxNewSchoolsDistrict.Margin = new System.Windows.Forms.Padding(6);
            this.cbxNewSchoolsDistrict.Name = "cbxNewSchoolsDistrict";
            this.cbxNewSchoolsDistrict.Size = new System.Drawing.Size(196, 33);
            this.cbxNewSchoolsDistrict.TabIndex = 9;
            // 
            // tbNewSchoolsName
            // 
            this.tbNewSchoolsName.Location = new System.Drawing.Point(408, 177);
            this.tbNewSchoolsName.Margin = new System.Windows.Forms.Padding(6);
            this.tbNewSchoolsName.Name = "tbNewSchoolsName";
            this.tbNewSchoolsName.Size = new System.Drawing.Size(196, 31);
            this.tbNewSchoolsName.TabIndex = 8;
            // 
            // lblNewSchoolsDistrict
            // 
            this.lblNewSchoolsDistrict.AutoSize = true;
            this.lblNewSchoolsDistrict.Location = new System.Drawing.Point(182, 260);
            this.lblNewSchoolsDistrict.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNewSchoolsDistrict.Name = "lblNewSchoolsDistrict";
            this.lblNewSchoolsDistrict.Size = new System.Drawing.Size(213, 25);
            this.lblNewSchoolsDistrict.TabIndex = 7;
            this.lblNewSchoolsDistrict.Text = "New School\'s District";
            // 
            // lblNewSchoolsName
            // 
            this.lblNewSchoolsName.AutoSize = true;
            this.lblNewSchoolsName.Location = new System.Drawing.Point(182, 183);
            this.lblNewSchoolsName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNewSchoolsName.Name = "lblNewSchoolsName";
            this.lblNewSchoolsName.Size = new System.Drawing.Size(203, 25);
            this.lblNewSchoolsName.TabIndex = 6;
            this.lblNewSchoolsName.Text = "New School\'s Name";
            // 
            // btnAddSchool
            // 
            this.btnAddSchool.Location = new System.Drawing.Point(706, 583);
            this.btnAddSchool.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddSchool.Name = "btnAddSchool";
            this.btnAddSchool.Size = new System.Drawing.Size(150, 44);
            this.btnAddSchool.TabIndex = 5;
            this.btnAddSchool.Text = "Add School";
            this.btnAddSchool.UseVisualStyleBackColor = true;
            // 
            // tbFilterByPlayer
            // 
            this.tbFilterByPlayer.Controls.Add(this.label5);
            this.tbFilterByPlayer.Controls.Add(this.label4);
            this.tbFilterByPlayer.Controls.Add(this.label3);
            this.tbFilterByPlayer.Controls.Add(this.lblName);
            this.tbFilterByPlayer.Controls.Add(this.tbPlayersNumber);
            this.tbFilterByPlayer.Controls.Add(this.lblPlayersNumber);
            this.tbFilterByPlayer.Location = new System.Drawing.Point(8, 43);
            this.tbFilterByPlayer.Margin = new System.Windows.Forms.Padding(6);
            this.tbFilterByPlayer.Name = "tbFilterByPlayer";
            this.tbFilterByPlayer.Padding = new System.Windows.Forms.Padding(6);
            this.tbFilterByPlayer.Size = new System.Drawing.Size(1767, 726);
            this.tbFilterByPlayer.TabIndex = 3;
            this.tbFilterByPlayer.Text = "Filter By Player";
            this.tbFilterByPlayer.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 312);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(60, 133);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // tbPlayersNumber
            // 
            this.tbPlayersNumber.Location = new System.Drawing.Point(298, 67);
            this.tbPlayersNumber.Margin = new System.Windows.Forms.Padding(6);
            this.tbPlayersNumber.Name = "tbPlayersNumber";
            this.tbPlayersNumber.Size = new System.Drawing.Size(196, 31);
            this.tbPlayersNumber.TabIndex = 1;
            // 
            // lblPlayersNumber
            // 
            this.lblPlayersNumber.AutoSize = true;
            this.lblPlayersNumber.Location = new System.Drawing.Point(60, 73);
            this.lblPlayersNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPlayersNumber.Name = "lblPlayersNumber";
            this.lblPlayersNumber.Size = new System.Drawing.Size(169, 25);
            this.lblPlayersNumber.TabIndex = 0;
            this.lblPlayersNumber.Text = "Player\'s Number";
            // 
            // tbFilterByEvent
            // 
            this.tbFilterByEvent.Location = new System.Drawing.Point(8, 43);
            this.tbFilterByEvent.Margin = new System.Windows.Forms.Padding(6);
            this.tbFilterByEvent.Name = "tbFilterByEvent";
            this.tbFilterByEvent.Padding = new System.Windows.Forms.Padding(6);
            this.tbFilterByEvent.Size = new System.Drawing.Size(1767, 726);
            this.tbFilterByEvent.TabIndex = 4;
            this.tbFilterByEvent.Text = "Filter By Event";
            this.tbFilterByEvent.UseVisualStyleBackColor = true;
            // 
            // toolStripStatusBar
            // 
            this.toolStripStatusBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripStatusBar.AutoSize = false;
            this.toolStripStatusBar.CanOverflow = false;
            this.toolStripStatusBar.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripStatusBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabelTotalPlayerCount,
            this.toolStripButtonAbout});
            this.toolStripStatusBar.Location = new System.Drawing.Point(9, 878);
            this.toolStripStatusBar.Name = "toolStripStatusBar";
            this.toolStripStatusBar.Size = new System.Drawing.Size(1693, 45);
            this.toolStripStatusBar.TabIndex = 1;
            this.toolStripStatusBar.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(174, 42);
            this.toolStripLabel1.Text = "Total Players :";
            // 
            // toolStripLabelTotalPlayerCount
            // 
            this.toolStripLabelTotalPlayerCount.Name = "toolStripLabelTotalPlayerCount";
            this.toolStripLabelTotalPlayerCount.Size = new System.Drawing.Size(28, 42);
            this.toolStripLabelTotalPlayerCount.Text = "0";
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(84, 42);
            this.toolStripButtonAbout.Text = "About";
            this.toolStripButtonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1828, 932);
            this.Controls.Add(this.toolStripStatusBar);
            this.Controls.Add(this.tcMainForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Sports Meet";
            this.tcMainForm.ResumeLayout(false);
            this.tbPlayers.ResumeLayout(false);
            this.tbPlayers.PerformLayout();
            this.tbEvents.ResumeLayout(false);
            this.tbEvents.PerformLayout();
            this.tbSchool.ResumeLayout(false);
            this.tbSchool.PerformLayout();
            this.tbFilterByPlayer.ResumeLayout(false);
            this.tbFilterByPlayer.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox mtbAge;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblPlayerNumber;
        private System.Windows.Forms.TextBox tbPlayerNumber;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.ListBox lstBoxPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datetpDateOfBirth;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.ComboBox cbxSchool;
        private System.Windows.Forms.ComboBox cbxAgeUnder;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbPlayersNumber;
        private System.Windows.Forms.Label lblPlayersNumber;
        private System.Windows.Forms.Label label5;
        private TextBox tbPlayerSearch;
        private ToolStrip toolStripStatusBar;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabelTotalPlayerCount;
        private ToolStripButton toolStripButtonAbout;
    }
    
}
