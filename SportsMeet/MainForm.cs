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
using SportsMeet.Utils;

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
            else
            {
                Util.SexEnum sexByteEnum = Util.SexStringToEnum(cbxGender.Text);

                long districtId = 0;
                District district = DataBase.GetDistrictByName(cbxDistrict.Text);
                if (district != null)
                {
                    districtId = district.Id;
                }

                Player newPlayer = new Player(0, tbPlayerNumber.Text, tbFirstName.Text, tbLastName.Text, age, (byte)sexByteEnum, 0, districtId);

                Player existingPlayer = DataBase.FindPlayer(newPlayer);

                if (existingPlayer != null)
                {
                    Console.WriteLine(existingPlayer.Id);
                    tbPlayerSearch.Text = existingPlayer.Number;
                    DialogResult result = MessageBox.Show("Player already exists. Do you want to override ?",
                        "Existing ID !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        newPlayer.Id = existingPlayer.Id;
                        DataBase.EditPlayer(newPlayer);
                    }
                    tbPlayerSearch.Clear();
                    LoadPlayerList();
                    return;
                }

                DataBase.SavePlayer(newPlayer);

                LoadPlayerList();

                CleanupPlayerTabTextBoxes();
            }
        }

        private void tbPlayerSearch_TextChanged(object sender, EventArgs e)
        {
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
            if (dataGridViewPlayers.CurrentRow != null)
            {
                Player currentPlayer = (Player)dataGridViewPlayers.CurrentRow.DataBoundItem;
                DataBase.RemovePlayer(currentPlayer);
                LoadPlayerList();
            }
        }

        private void RefreshGui()
        {
            tbPlayerSearch.Text = Resources.DefaultSearchString;
            tbPlayerSearch.ForeColor = Color.DimGray;
            tbPlayerNumber.Clear();
            CleanupFilterByPlayerTabLabels();
            comboBoxEventsSex.SelectedIndex = 0;
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
            tbPlayerSearch.AutoCompleteCustomSource = autoComplete;
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
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            EventsTab.AddEvent(tbNewEventsNumber.Text, numericUpDownEventAgeLimit.Text, tbNewEventsName.Text, comboBoxEventsSex.Text);
            LoadEventList();
        }

        private void LoadEventList()
        {
            _events = DataBase.LoadEvents().ToList();
            bindingSourceEvents.DataSource = _events;
            bindingSourceEvents.ResetBindings(false);

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

        private void tcMainForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabControlMain = sender as TabControl;
            if (tabControlMain == null) return;
          
            if (tabControlMain.SelectedIndex == 1)
            {
                LoadEventList();
            } else if (tabControlMain.SelectedIndex == 0)
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
            }

        }

    }
}
