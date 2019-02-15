using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SportsMeet.Models;

namespace SportsMeet
{
    public partial class MainForm : Form
    {

        #region MainForm uicontrols

        public MainForm()
        {
            InitializeComponent();
            DataInit();
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
                Player newPlayer = new Player(tbFirstName.Text, tbLastName.Text, age, tbPlayerNumber.Text);
                _players.Add(newPlayer);

                LoadPlayerList();
            }
        }

        #endregion

        #region DataRegion

        private readonly List<Player> _players = new List<Player>();

        #endregion

        #region DataProcessing

        private void DataInit()
        {
            _players.Add(new Player("Rukshan", "Perera", 27));
            _players.Add(new Player("Isuru", "Rathnayake", 26));
            _players.Add(new Player("Player1", "GameOver", 15));
            LoadPlayerList();
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

    }
}
