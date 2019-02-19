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
            LoadPlayerList();
        }

        private void tbPlayers_Click(object sender, EventArgs e)
        {
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DBConnection.Instance.Connection.Close();
        }

        #region button clicks

        private void toolStripMainAbout_Click(object sender, EventArgs e)
        {
            using (formAbout aboutForm = new formAbout())
            {
                aboutForm.ShowDialog();
            }
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            Player currentPlayer = (Player)gridViewPlayers.CurrentRow.DataBoundItem;
            DataBase.RemovePlayer(currentPlayer);
            LoadPlayerList();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbPlayerNumber.Text))
            {
                MessageBox.Show("Invalid player number", "Please enter a valid number");
            }
            else
            if (!Int32.TryParse(numUpDownAge.Text, out var age))
            {
                MessageBox.Show("Invalid Age", "Please enter a valid name");
            }
            else if (String.IsNullOrEmpty(tbFirstName.Text) || String.IsNullOrEmpty(tbLastName.Text))
            {
                MessageBox.Show("Invalid Name", "Please enter the name.");
            }
            else
            {
                Player newPlayer = new Player(tbPlayerNumber.Text.Trim(),
                    tbFirstName.Text.Trim(),
                    tbLastName.Text.Trim(),
                    age);

                DataBase.SavePlayer(newPlayer);

                LoadPlayerList();
            }
        }

        #endregion button clicks

        #region player search

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            String searchString = tbSearch.Text.Trim();

            if (searchString != Resources.DefaultSearchString)
            {
                var myRegex = new Regex(@"^" + searchString + ".*$");
                IEnumerable<Player> result = _players.Where(player => myRegex.IsMatch(player.Number));
                gridViewPlayers.DataSource = null;
                gridViewPlayers.DataSource = result.ToList();
            }
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbSearch.Text))
            {
                tbSearch.Text = Resources.DefaultSearchString;
                tbSearch.ForeColor = Color.DimGray;
            }
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            tbSearch.ForeColor = DefaultForeColor;
        }

        #endregion player search

        #endregion MainForm uicontrols

        #region DataRegion

        private List<Player> _players = new List<Player>();

        #endregion DataRegion

        #region DataProcessing

        private void DataInit()
        {
            _players = DataBase.LoadPlayers();
        }

        private void LoadPlayerList()
        {
            _players = DataBase.LoadPlayers();
            RefreshGui();
        }

        private void RefreshGui()
        {
            _players.Sort();
            gridViewPlayers.DataSource = null;
            gridViewPlayers.DataSource = _players;
            tspLblPlayerCount.Text = _players.Count.ToString();
        }

        #endregion DataProcessing
    }
}