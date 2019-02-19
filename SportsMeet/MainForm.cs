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
        #region MainForm uicontrols

        public MainForm()
        {
            InitializeComponent();
            DataInit();
            LoadPlayerList();
            LoadSchoolList();
            LoadDistrictList();
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
                MessageBox.Show("Invalid Age", "Please enter a valid age");
            }
            else if (String.IsNullOrEmpty(tbFirstName.Text) || String.IsNullOrEmpty(tbLastName.Text))
            {
                MessageBox.Show("Please enter both first name and last name.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Player newPlayer = new Player(tbPlayerNumber.Text, tbFirstName.Text, tbLastName.Text, age);

                DataBase.SavePlayer(newPlayer);

                LoadPlayerList();
            }
        }

        private void tbPlayerSearch_TextChanged(object sender, EventArgs e)
        {
            String searchString = tbPlayerSearch.Text.Trim();

            if (searchString != Resources.DefaultSearchString)
            {
                var myRegex = new Regex(@"^" + searchString + ".*$");
                IEnumerable<Player> result = _players.Where(player => myRegex.IsMatch(player.Number));
                dataGridViewPlayers.DataSource = null;
                dataGridViewPlayers.DataSource = result.ToList();
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
        }

        private void tbPlayerSearch_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbPlayerSearch.Text))
            {
                tbPlayerSearch.Text = Resources.DefaultSearchString;
                tbPlayerSearch.ForeColor = Color.DimGray;
            }
        }

        private void tbPlayerSearch_Enter(object sender, EventArgs e)
        {
            tbPlayerSearch.Text = "";
            tbPlayerSearch.ForeColor = DefaultForeColor;
        }

        #endregion MainForm uicontrols

        #region DataRegion

        private List<Player> _players = new List<Player>();
        private List<School> _schools = new List<School>();
        private List<District> _districts = new List<District>();

        #endregion DataRegion

        #region DataProcessing

        private void DataInit()
        {
        }

        private void LoadPlayerList()
        {
            _players = DataBase.LoadPlayers();
            bindingSourcePlayers.DataSource = _players;
            bindingSourcePlayers.ResetBindings(false);
            toolStripLabelTotalPlayerCount.Text = _players.Count.ToString();
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

    }
}