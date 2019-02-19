using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SportsMeet.Data;
using SportsMeet.Models;
using SportsMeet.Properties;

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
        }

        private void tbPlayers_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbPlayerNumber.Text))
            {
                MessageBox.Show("Invalid player number", "Please enter a valid number");

            } else 
            if (!Int32.TryParse(mtbAge.Text, out var age))
            {
                MessageBox.Show("Invalid Age", "Please enter a valid name");
            }
            else if (String.IsNullOrEmpty(tbFirstName.Text) || String.IsNullOrEmpty(tbLastName.Text))
            {
                MessageBox.Show("Invalid Name", "Please enter the name.");
            } 
            else
            {
                Player newPlayer = new Player(tbPlayerNumber.Text, tbFirstName.Text, tbLastName.Text, age);
               
                DataBase.SavePlayer(newPlayer);

                LoadPlayerList();
            }
        }

        #endregion

        #region DataRegion

        private List<Player> _players = new List<Player>();

        #endregion

        #region DataProcessing

        private void DataInit()
        {
            _players = DataBase.LoadPlayers();
        }

        private void LoadPlayerList()
        {
            RefreshGui();
        }

        private void RefreshGui()
        {
            _players.Sort();
            lstBoxPlayer.DataSource = null;
            lstBoxPlayer.DataSource = _players;
            lstBoxPlayer.DisplayMember = "FullName";
        }

        #endregion

        private void lstBoxPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbPlayerSearch_TextChanged(object sender, EventArgs e)
        {
            String searchString = tbPlayerSearch.Text.Trim();

            if (searchString != Resources.DefaultSearchString)
            {
                var myRegex = new Regex(@"^" + searchString + ".*$");
                IEnumerable<Player> result = _players.Where(player => myRegex.IsMatch(player.Number));
                //gridViewPlayers.DataSource = null;
                //gridViewPlayers.DataSource = result.ToList();
            }
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            using (Form abForm = new formAbout())
            {
                abForm.Show();
            }
        }
    }
}
