﻿using SportsMeet.Data;
using SportsMeet.Models;
using SportsMeet.Properties;
using SportsMeet.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
            if (String.IsNullOrEmpty(tbPlayerNumber.Text))
            {
                MessageBox.Show("Invalid player number", "Invalid number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (!Int32.TryParse(numericUpDownAge.Text, out var age))
            {
                MessageBox.Show("Please enter a valid age", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(tbFirstName.Text) || String.IsNullOrEmpty(tbLastName.Text))
            {
                MessageBox.Show("Please enter both first name and last name.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(cbxDistrict.Text))
            {
                MessageBox.Show("Please choose a valid district.", "Invalid District", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                long districtId = 0;
                District district = DataBase.GetDistrictByName(cbxDistrict.Text);
                if (district != null)
                {
                    districtId = district.Id;
                }

                /*
                long schoolId = 0;
                School school = DataBase.GetSchoolByName(cbxDistrict.Text);
                if (district != null)
                {
                    schoolId = school.Id;
                }*/

                Event currentEvent = DataBase.GetEventByNumber(cbxEvent.Text.Trim());

                if (currentEvent != null)
                {
                    if (currentEvent.AgeLimit <= age)
                    {
                        MessageBox.Show("Player exceeds events age limit!",
                            "Player age exceeds!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    return;
                }

                Player newPlayer = new Player(0, tbPlayerNumber.Text, tbFirstName.Text, tbLastName.Text, age, (byte)Util.SexStringToEnum(cbxGender.Text), 0, districtId);
                var result = PlayersTab.AddPlayer(newPlayer);
                if (result.Item1)
                {
                    LoadPlayerList();
                    CleanupPlayerTabTextBoxes();
                }
            }
        }

        private void tbPlayerSearch_TextChanged(object sender, EventArgs e)
        {
            if (!checkBoxPlayerAutoFilter.Checked) return;

            var textbox = sender as TextBox;
            {
                String searchString = textbox.Text.Trim();

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

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            using (Form abForm = new formAbout())
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
            tbPlayerNumber.Text = Resources.DefaultSearchString;
            tbPlayerNumber.ForeColor = Color.DimGray;
            tbPlayerNumber.Clear();
            CleanupFilterByPlayerTabLabels();
            comboBoxEventsSex.SelectedIndex = 1;
            cbxGender.SelectedIndex = 1;
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
            School newSchool = new School(0, tbNewSchoolsName.Text, cbxNewSchoolsDistrict.SelectedIndex);

            DataBase.SaveSchool(newSchool);

            LoadSchoolList();

            CleanupSchoolTabTextBoxes();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            EventsTab.AddEvent(tbNewEventsNumber.Text.Trim(),
                numericUpDownEventAgeLimit.Text.Trim(),
                tbNewEventsName.Text.Trim(),
                comboBoxEventsSex.Text.Trim());
            LoadEventList();
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
        }

        //TODO: refactor and remove duplicate code
        private void tbFilterByPlayersNumber_TextChanged(object sender, EventArgs e)
        {
            CleanupFilterByPlayerTabLabels();
            var textbox = sender as TextBox;
            {
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

                        if (players.Count > 1)
                        {
                            return;
                        }

                        Player searchedPlayer = players.SingleOrDefault();

                        if (searchedPlayer != null)
                        {
                            lblFilterByPlayerNameOutput.Text = searchedPlayer.FullName();

                            District district = DataBase.GetDistrict(searchedPlayer.DistrictId);
                            if (district != null)
                            {
                                lblFilterByPlayerDistrictOutput.Text = district.Name;
                            }
                            lblFilterByPlayerSchoolOutput.Text = searchedPlayer.SchoolId.ToString();

                            Int64 playerId = searchedPlayer.Id;
                            //List<Event>
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
            tbNewSchoolsName.Clear();
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

        private void cbxEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbx = sender as ComboBox;
            if (cbx == null) return;
            Event searchedEvent = DataBase.GetEventByNumber(cbx.Text);
            if (searchedEvent != null)
            {
                lblAgeUnderValue.Text = searchedEvent.AgeLimit.ToString();
                labelEventNamePlayerstab.Text = searchedEvent.Name;
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

        private void checkBoxHideEvent_CheckedChanged(object sender, EventArgs e)
        {
            var checkBoxAddEvent = sender as CheckBox;
            if (checkBoxAddEvent == null) return;

            if (checkBoxAddEvent.Checked)
            {
                groupBoxFirstEvent.Visible = true;
            }
            else
            {
                groupBoxFirstEvent.Visible = false;
                labelEventNamePlayerstab.Text = "";
                lblAgeUnderValue.Text = "0";
                foreach (Control ctr in checkBoxAddEvent.Controls)
                {
                    if (ctr is TextBox)
                    {
                        ctr.Text = "";
                    }
                    else if (ctr is CheckedListBox)
                    {
                        CheckedListBox clb = (CheckedListBox)ctr;
                        foreach (int checkedItemIndex in clb.CheckedIndices)
                        {
                            clb.SetItemChecked(checkedItemIndex, false);
                        }
                    }
                    else if (ctr is CheckBox)
                    {
                        ((CheckBox)ctr).Checked = false;
                    }
                    else if (ctr is ComboBox)
                    {
                        ((ComboBox)ctr).SelectedIndex = 0;
                    }
                }
            }
        }

        private void btnPlayerSearch_Click(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
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
            if (!checkBoxLoadSelection.Checked) return;
            if (dataGridViewPlayers.CurrentRow != null)
            {
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
    }
}