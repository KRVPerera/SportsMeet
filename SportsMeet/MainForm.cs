using SportsMeet.Data;
using SportsMeet.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DBConnection.Instance.Connection.Close();
        }


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
            //lstBoxPlayer.DisplayMember = "FullName";
        }


        #endregion DataProcessing

        
    }
}