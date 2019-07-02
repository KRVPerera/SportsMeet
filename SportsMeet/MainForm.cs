﻿using SportsMeet.Data;
using SportsMeet.Models;
using SportsMeet.Properties;
using SportsMeet.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using SportsMeet.View;

namespace SportsMeet
{
    public partial class MainForm : Form
    {
        #region MainForm uicontrols

        public MainForm()
        {
            InitializeComponent();
            DataInit();
            LoadPlayerList();
            LoadSchoolList();
            LoadDistrictList();
            LoadEventList();
            RefreshGui();
        }

        private void tbPlayers_Click(object sender, EventArgs e)
        {
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbPlayerNumber.Text.Trim()))
            {
                MessageBox.Show("Invalid player number", "Invalid number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (!Int32.TryParse(numericUpDownAge.Text, out var age))
            {
                MessageBox.Show("Please enter a valid age", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(tbFirstName.Text.Trim()) || String.IsNullOrEmpty(tbLastName.Text.Trim()))
            {
                MessageBox.Show("Please enter both first name and last name.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(cbxDistrict.Text.Trim()))
            {
                MessageBox.Show("Please choose a valid district.", "Invalid District", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Util.ValidHumanSexString(cbxGender.Text.Trim()))
            {
                MessageBox.Show("Please choose a valid gender.", "Invalid Gender", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                long districtId = 0;
                District district = DataBase.GetDistrictByName(cbxDistrict.Text);
                if (district != null)
                {
                    districtId = district.Id;
                }

                long schoolId = 0;
                School school = DataBase.GetSchool(cbxSchool.Text);
                if (school != null)
                {
                    schoolId = school.Id;
                }

                Player newPlayer = new Player(0, tbPlayerNumber.Text, tbFirstName.Text, tbLastName.Text, age, (byte)Util.SexStringToEnum(cbxGender.Text), schoolId, districtId);
                var result = PlayersTab.AddPlayer(newPlayer);
                if (result.Item1)
                {
                    statusViewer.Update("Player saved sucecssfully...!", Status.INFO);
                    LoadPlayerList();

                    if (checkBoxAddtoanEvent.Checked)
                    {
                        Player existingPlayer = DataBase.FindPlayerByNumber(newPlayer);
                        if (existingPlayer != null)
                        {
                            Form eventForm = new AddMultipleEventsToPlayer(existingPlayer);
                            eventForm.ShowDialog();
                            // TODO get event Form status
                        }
                        else
                        {
                            // TODO: update status bar to player not found
                            statusViewer.Update("Player not found...!", Status.ERROR);
                        }
                        CleanupPlayerTabTextBoxes();
                    }
                }
            }
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            using (Form abForm = new AboutBox())
            {
                abForm.ShowDialog();
            }
        }

        private void deletePlayer_Click(object sender, EventArgs e)
        {
            Player currentPlayer = null;

            if (checkBoxDeleteSelection.Checked && dataGridViewPlayers.CurrentRow != null)
            {
                currentPlayer = (Player)dataGridViewPlayers.CurrentRow.DataBoundItem;
            }

            if (currentPlayer == null)
            {
                MessageBox.Show("Player not found!", "Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("Are you sure you want to delete the player [");
            sb.Append(currentPlayer.Number);
            sb.Append("] - Name :");
            sb.Append(currentPlayer.FullName());
            string message = sb.ToString();

            var result = MessageBox.Show(message, "Deleting player", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (DialogResult.Yes != result)
            {
                return;
            }

            DataBase.RemovePlayer(currentPlayer);
            LoadPlayerList();
        }

        private void RefreshGui()
        {
            textBoxPlayerSearch.Clear();
            tbPlayerNumber.Clear();
            textBoxPlayerSearch.Text = Resources.DefaultSearchString;
            textBoxPlayerSearch.ForeColor = Color.DimGray;
            CleanupFilterByPlayerTabLabels();
            comboBoxEventsSex.SelectedIndex = 1;
            cbxGender.SelectedIndex = 1;
            statusViewer = new StatusViewer(this.statusLabel, this.statusTime, this.toolStripStatusBar);
            statusViewer.Update("Program Loaded", Status.SUCCESS);
        }

        private void tbPlayerSearch_Leave(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            {
                if (String.IsNullOrEmpty(textbox?.Text))
                {
                    textbox.Text = Resources.DefaultSearchString;
                    textbox.ForeColor = Color.DimGray;
                    bindingSourcePlayers.DataSource = _players;
                    bindingSourcePlayers.ResetBindings(false);
                }
            }
        }

        private void tbPlayerSearch_Enter(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            {
                if (textbox != null)
                {
                    textbox.Text = "";
                    textbox.ForeColor = DefaultForeColor;
                }
            }
            CleanupPlayerTabTextBoxes();
        }

        #endregion MainForm uicontrols

        #region DataRegion

        private List<Player> _players = new List<Player>();
        private List<School> _schools = new List<School>();
        private List<District> _districts = new List<District>();
        private List<Event> _events = new List<Event>();

        #endregion DataRegion

        #region DataProcessing

        private void DataInit()
        {
        }

        private void LoadPlayerList()
        {
            _players = DataBase.LoadPlayers().ToList();
            bindingSourcePlayers.DataSource = _players;
            bindingSourcePlayers.ResetBindings(false);
            toolStripLabelTotalPlayerCount.Text = _players.Count.ToString();

            var autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(DataBase.LoadPlayerNumbers().ToArray());
            tbPlayerNumber.AutoCompleteCustomSource = autoComplete;
            tbFilterByPlayersNumber.AutoCompleteCustomSource = autoComplete;
        }

        private void LoadSchoolList()
        {
            _schools = DataBase.LoadSchools();
            bindingSourceSchools.DataSource = _schools;
            bindingSourceSchools.ResetBindings(false);
            toolStripLabelSchoolCount.Text = _schools.Count.ToString();

            bindingSourceSchoolsFixed.DataSource = _schools;
            bindingSourceSchoolsFixed.ResetBindings(false);

            var autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(DataBase.LoadSchoolNames().ToArray());
            tbSchoolName.AutoCompleteCustomSource = autoComplete;
        }

        private void LoadDistrictList()
        {
            _districts = DataBase.LoadDistricts();
            bindingSourceDistricts.DataSource = _districts;
            bindingSourceDistricts.ResetBindings(false);
        }

        #endregion DataProcessing

        private void btnAddSchool_Click(object sender, EventArgs e)
        {
            try
            {
                if (SchoolsTab.AddSchool(tbSchoolName.Text.Trim(),
                        tbNewSchoolName.Text.Trim()))
                {
                    statusViewer.Update("School saved successfully...!", Status.INFO);
                }
                else
                {
                    statusViewer.Update("Failed to save school...!", Status.ERROR);
                }
                LoadSchoolList();
                CleanupSchoolTabTextBoxes();
            }
            catch (Exception exception)
            {
                statusViewer.Update(exception.Message, Status.WARNING);
            }
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            if (EventsTab.AddEvent(tbNewEventsNumber.Text.Trim(),
                numericUpDownEventAgeLimit.Text.Trim(),
                tbNewEventsName.Text.Trim(),
                comboBoxEventsSex.Text.Trim()))
            {

                statusViewer.Update("Event added !", Status.SUCCESS);
                LoadEventList();
                ClearEventsTab();
            }

        }

        private void ClearEventsTab()
        {
            tbNewEventsNumber.Clear();
            tbNewEventsName.Clear();
        }

        private void LoadEventList()
        {
            _events = DataBase.LoadEvents().ToList();
            bindingSourceEvents.DataSource = _events;
            bindingSourceEvents.ResetBindings(false);

            toolStripLabelTotalEvents.Text = _events.Count.ToString();

            var autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(DataBase.LoadEventNumbers().ToArray());
            tbNewEventsNumber.AutoCompleteCustomSource = autoComplete;
            tbFilterByEventEventNumber.AutoCompleteCustomSource = autoComplete;
        }

        //TODO: refactor and remove duplicate code
        private void tbFilterByPlayersNumber_TextChanged(object sender, EventArgs e)
        {
            CleanupFilterByPlayerTabLabels();

            List<Event> el = new List<Event>();
            bindingSourceFilteredEventsOnPlayers.DataSource = el;
            bindingSourceFilteredEventsOnPlayers.ResetBindings(false);
            lblFilterByPlayerNameOutput.Text = "Not found";

            var textbox = sender as TextBox;
            if (textbox != null)
            {
                String searchString = textbox.Text.Trim();

                if (searchString != Resources.DefaultSearchString)
                {
                    var playerList = DataBase.LoadPlayers();
                    var myRegex = new Regex(@"^" + searchString + ".*$");
                    IEnumerable<Player> searchedPlayers = playerList.Where(player => myRegex.IsMatch(player.Number));

                    
                    List<Player> players = searchedPlayers.ToList();
                    bindingSourcePlayers.DataSource = players;
                    bindingSourcePlayers.ResetBindings(false);

                    Player searchedPlayer = players.FirstOrDefault();

                    if (searchedPlayer != null)
                    {
                        Player searchMe = new Player(searchString);
                        Player searchByNumber = DataBase.FindPlayerByNumber(searchMe);
                        if (searchByNumber != null)
                        {
                            lblFilterByPlayerNameOutput.Text = searchedPlayer.FullName();

                            District district = DataBase.GetDistrict(searchedPlayer.DistrictId);
                            if (district != null)
                            {
                                lblFilterByPlayerDistrictOutput.Text = district.Name;
                            }
                            else
                            {
                                lblFilterByPlayerDistrictOutput.Text = "UNKNOWN";
                            }

                            School school = DataBase.GetSchool(searchedPlayer.SchoolId);
                            if (school != null)
                            {
                                lblFilterByPlayerSchoolOutput.Text = school.Name;
                            }
                            else
                            {
                                lblFilterByPlayerSchoolOutput.Text = "UNKNOWN";
                            }

                            PlayerEvent searchPlayerEvents = new PlayerEvent(0, searchedPlayer.Id);
                            List<PlayerEvent> playerEventList = DataBase.GetPlayerEventsByPlayer(searchPlayerEvents);
                            List<Event> eventList = DataBase.GetEventsForPlayerEvents(playerEventList);
                            bindingSourceFilteredEventsOnPlayers.DataSource = eventList;
                            bindingSourceFilteredEventsOnPlayers.ResetBindings(false);
                        }
                    }
                }
            }
        }

        private void CleanupFilterByPlayerTabLabels()
        {
            lblFilterByPlayerNameOutput.Text = "";
            lblFilterByPlayerDistrictOutput.Text = "";
            lblFilterByPlayerSchoolOutput.Text = "";
        }

        private void CleanupPlayerTabTextBoxes()
        {
            tbPlayerNumber.Clear();
            tbFirstName.Clear();
            tbLastName.Clear();
        }

        private void CleanupSchoolTabTextBoxes()
        {
            tbSchoolName.Clear();
            tbNewSchoolName.Clear();
            tbNewSchoolName.Enabled = false;
            btnEditSchool.Enabled = false;
        }

        private void tcMainForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabControlMain = sender as TabControl;
            if (tabControlMain == null) return;

            if (tabControlMain.SelectedIndex == 1)
            {
                LoadEventList();
            }
            else if (tabControlMain.SelectedIndex == 0)
            {
                LoadPlayerList();
            }
        }

        private void EventsNumberTextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null) return;
            var searchString = textBox.Text.Trim();
            var eventList = DataBase.LoadEvents();
            var myRegex = new Regex(@"^" + searchString + ".*$");
            IEnumerable<Event> result = eventList.Where(curEvent => myRegex.IsMatch(curEvent.Number));
            bindingSourceEvents.DataSource = result.ToList();
            bindingSourceEvents.ResetBindings(false);
        }

        private void EventSearchClick(object sender, EventArgs e)
        {
            Event searchedEvent = EventsTab.SearchEvent(
                tbNewEventsNumber.Text,
                numericUpDownEventAgeLimit.Text,
                tbNewEventsName.Text,
                comboBoxEventsSex.Text);

            if (searchedEvent != null)
            {
                tbNewEventsNumber.Text = searchedEvent.Number;
                tbNewEventsName.Text = searchedEvent.Name;
                comboBoxEventsSex.Text = searchedEvent.Gender;
                numericUpDownEventAgeLimit.Text = searchedEvent.AgeLimit.ToString();
            }
        }

        private void btnEventEdit_Click(object sender, EventArgs e)
        {
            if (EventsTab.AddEvent(
                tbNewEventsNumber.Text.Trim(),
                numericUpDownEventAgeLimit.Text.Trim(),
                tbNewEventsName.Text.Trim(),
                comboBoxEventsSex.Text.Trim(),
                editMode: true))
            {
                LoadEventList();
            }
        }

        private void btnEventDelete_Click(object sender, EventArgs e)
        {
            if (EventsTab.DeleteEvent(
                tbNewEventsNumber.Text.Trim(),
                numericUpDownEventAgeLimit.Text.Trim(),
                tbNewEventsName.Text.Trim(),
                comboBoxEventsSex.Text.Trim()))
            {
                LoadEventList();
            }
        }

        private void btnPlayerSearch_Click(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            if (textbox == null) return;
            {
                String searchString = textbox.Text.Trim();

                if (searchString != Resources.DefaultSearchString)
                {
                    var playerList = DataBase.LoadPlayers();
                    var myRegex = new Regex(@"^" + searchString + ".*$");
                    IEnumerable<Player> result = playerList.Where(player => myRegex.IsMatch(player.Number));
                    //                    Player searchedPlayer =
                }
            }
        }

        private void checkBoxPlayerAutoFilter_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox == null) return;
            if (!checkBox.Checked)
            {
                LoadPlayerList();
            }
            else
            {
                String searchString = tbPlayerNumber.Text.Trim();

                if (searchString != Resources.DefaultSearchString)
                {
                    var playerList = DataBase.LoadPlayers();
                    var myRegex = new Regex(@"^" + searchString + ".*$");
                    IEnumerable<Player> result = playerList.Where(player => myRegex.IsMatch(player.Number));
                    bindingSourcePlayers.DataSource = result.ToList();
                    bindingSourcePlayers.ResetBindings(false);
                }
            }
        }

        private void dataGridViewPlayers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPlayers.CurrentRow != null)
            {
                if (checkBoxDeleteSelection.Checked && dataGridViewPlayers.CurrentRow != null)
                {
                    btnDeletePlayer.Enabled = true;
                }
                if (!checkBoxLoadSelection.Checked) return;
                Player currentPlayer = (Player)dataGridViewPlayers.CurrentRow.DataBoundItem;
                LoadPlayerToPLayerTab(currentPlayer);
            }
        }

        private void LoadPlayerToPLayerTab(Player player)
        {
            tbPlayerNumber.Text = player.Number;
            tbFirstName.Text = player.FirstName;
            tbLastName.Text = player.LastName;
            /*School school = DataBase.getSchoolById(player.SchoolId);
            if (school != null)
            {
                cbxSchool.SelectedText = school.Name;
            }*/

            numericUpDownAge.Text = player.Age.ToString();
            cbxGender.SelectedIndex = player.Sex;

            District district = DataBase.GetDistrict(player.DistrictId);
            if (district != null)
            {
                cbxDistrict.SelectedText = district.Name;
            }
        }

        private void checkBoxLoadSelection_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (!checkBox.Checked)
            {
                CleanupPlayerTabTextBoxes();
            }
        }

        private void checkBoxDeleteSelection_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox.Checked && dataGridViewPlayers.CurrentRow != null)
            {
                btnDeletePlayer.Enabled = true;
            }
            else
            {
                btnDeletePlayer.Enabled = false;
            }
        }

        private void btnEditSchool_Click(object sender, EventArgs e)
        {
            if (SchoolsTab.AddSchool(tbSchoolName.Text.Trim(), tbNewSchoolName.Text.Trim(), editMode: true))
            {
                LoadSchoolList();
            }
            CleanupSchoolTabTextBoxes();
        }

        private void btnDeleteSchool_Click(object sender, EventArgs e)
        {
            if (SchoolsTab.DeleteSchool(
                tbSchoolName.Text.Trim()))
            {
                LoadSchoolList();
            }
            CleanupSchoolTabTextBoxes();
        }

        private void tbSchoolName_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null) return;

            var searchString = textBox.Text.Trim();
            var schoolList = DataBase.LoadSchools();
            var myRegex = new Regex(@"^" + searchString + ".*$");
            IEnumerable<School> result = schoolList.Where(curSchool => myRegex.IsMatch(curSchool.Name));

            if (result.Any())
            {
                bindingSourceSchools.DataSource = result.ToList();
                bindingSourceSchools.ResetBindings(false);
            }

            try
            {
                School newSchool = new School(0, searchString);

                School searchedSchool = DataBase.GetSchool(searchString);
                if (searchedSchool != null)
                {
                    tbNewSchoolName.Enabled = true;
                }
                else
                {
                    tbNewSchoolName.Enabled = false;
                }
            }
            catch (Exception exception)
            {
                statusViewer.Update(exception.Message, Status.WARNING);
            }
        }

        private void btnAddEventsToPlayer_Click(object sender, EventArgs e)
        {
            Player newPlayer = new Player(0, tbPlayerNumber.Text, tbFirstName.Text, tbLastName.Text, 0, (byte)Util.SexStringToEnum(cbxGender.Text), 0, 0);
            Player existingPlayer = DataBase.FindPlayerByNumber(newPlayer);
            if (existingPlayer != null)
            {
                Form eventForm = new AddMultipleEventsToPlayer(existingPlayer);
                eventForm.ShowDialog();
            }
            else
            {
                // TODO: update status bar to player not found
            }
        }

        private void btnPlayerEdit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbPlayerNumber.Text.Trim()))
            {
                MessageBox.Show("Invalid player number", "Invalid number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!Int32.TryParse(numericUpDownAge.Text, out var age))
            {
                MessageBox.Show("Please enter a valid age", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(tbFirstName.Text.Trim()) || String.IsNullOrEmpty(tbLastName.Text.Trim()))
            {
                MessageBox.Show("Please enter both first name and last name.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(cbxDistrict.Text.Trim()))
            {
                MessageBox.Show("Please choose a valid district.", "Invalid District", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Util.ValidHumanSexString(cbxGender.Text.Trim()))
            {
                MessageBox.Show("Please choose a valid gender.", "Invalid Gender", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                long districtId = 0;
                District district = DataBase.GetDistrictByName(cbxDistrict.Text);
                if (district != null)
                {
                    districtId = district.Id;
                }

                long schoolId = 0;
                School school = DataBase.GetSchool(cbxSchool.Text);
                if (school != null)
                {
                    schoolId = school.Id;
                }

                string searchString = tbPlayerNumber.Text.Trim();
                Player searchMe = new Player(searchString);
                Player searchByNumber = DataBase.FindPlayerByNumber(searchMe);
                if (searchByNumber != null)
                {
                    Player newPlayer = new Player(searchByNumber.Id, tbPlayerNumber.Text, tbFirstName.Text, tbLastName.Text, age, (byte)Util.SexStringToEnum(cbxGender.Text), schoolId, districtId);
                    if (PlayersTab.SavePlayer(newPlayer))
                    {
                        LoadPlayerList();
                    }
                }
            }
        }

        private void textBoxPlayerSearch_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            {
                String searchString = textbox.Text.Trim();

                if (searchString != Resources.DefaultSearchString)
                {
                    var playerList = DataBase.LoadPlayers();
                    var myRegex = new Regex(@"^" + searchString + ".*$");
                    IEnumerable<Player> result = playerList.Where(player => myRegex.IsMatch(player.Number));
                    if (result.Any())
                    {
                        bindingSourcePlayers.DataSource = result.ToList();
                        bindingSourcePlayers.ResetBindings(false);
                    }
                }
            }
        }

        private void textBoxPlayerSearch_Leave(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            {
                if (String.IsNullOrEmpty(textbox?.Text))
                {
                    textbox.Text = Resources.DefaultSearchString;
                    textbox.ForeColor = Color.DimGray;
                    bindingSourcePlayers.DataSource = _players;
                    bindingSourcePlayers.ResetBindings(false);
                }
            }
        }

        private void textBoxPlayerSearch_Enter(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            {
                if (textbox != null)
                {
                    textbox.Text = "";
                    textbox.ForeColor = DefaultForeColor;
                }
            }
        }

        private void btnFilterByEventFilter_Click(object sender, EventArgs e)
        {
            Event sEventByNumber = DataBase.GetEventByNumber(tbFilterByEventEventNumber.Text);

            if (sEventByNumber != null)
            {
                PlayerEvent searchMe = new PlayerEvent(sEventByNumber.Id, 0);
                List<PlayerEvent> playerEventsByEvent = DataBase.GetPlayerEventsByEvent(searchMe);
                List<Player> players = DataBase.GetPlayersForPlayerEvents(playerEventsByEvent);

                if (players.Count > 0)
                {
                    bindingSourceFilteredPlayersOnEvent.DataSource = players;
                    bindingSourceFilteredPlayersOnEvent.ResetBindings(false);
                }
            }
        }

        private void tbNewSchoolName_TextChanged(object sender, EventArgs e)
        {
            var searchString = tbSchoolName.Text.Trim();

            School searchedSchool = DataBase.GetSchool(searchString);

            if (searchedSchool != null)
            {
                if (tbNewSchoolName.Text.Trim() == tbSchoolName.Text.Trim())
                {
                    btnEditSchool.Enabled = false;
                }
                else if (!String.IsNullOrEmpty(tbNewSchoolName.Text.Trim()))
                {
                    btnEditSchool.Enabled = true;
                }
            }
            else
            {
                btnEditSchool.Enabled = false;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.playersTabLoadSelectionSettings = checkBoxLoadSelection.Checked;
            Settings.Default.playersTabDeleteSelectionSetting = checkBoxDeleteSelection.Checked;
            Settings.Default.playersTabDeleteSelectionSetting = checkBoxAddtoanEvent.Checked;
            Settings.Default.Save();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            checkBoxLoadSelection.Checked = Settings.Default.playersTabLoadSelectionSettings;
            checkBoxDeleteSelection.Checked = Settings.Default.playersTabDeleteSelectionSetting;
            checkBoxAddtoanEvent.Checked = Settings.Default.playersTabDeleteSelectionSetting;
        }

        private void statusTime_Tick(object sender, EventArgs e)
        {
            statusViewer.Reset();
        }
    }
}