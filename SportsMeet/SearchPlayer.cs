using SportsMeet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SportsMeet.Utils;

namespace SportsMeet
{
    public partial class SearchPlayer : Form
    {
        public Player Player { get { return playerSearched; } set { playerSearched = value; } }
        Player playerSearched;

        public SearchPlayer()
        {
            InitializeComponent();
        }

        private void SearchPlayer_Load(object sender, EventArgs e)
        {
            resetUi();
            updateGuiComponents();
        }

        private void updateGuiComponents()
        {
            var playerIds = Data.DataBase.LoadPlayerNumbers();

            var autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(playerIds.ToArray());

            tbxPlayerNumberSW.AutoCompleteCustomSource = autoComplete;
        }

        private void resetUi()
        {
        }

        private void btnSearchSW_Click(object sender, EventArgs e)
        {
            String playerNumber = tbxPlayerNumberSW.Text.Trim();
            Player searchPlayer = new Player(playerNumber);
       
            var players = Data.DataBase.LoadPlayers(searchPlayer);
            Player foundPlayer = players.FirstOrDefault();
            if (foundPlayer != null)
            {
                playerSearched = foundPlayer;
            }
            else
            {
                playerSearched = null;
            }
        }

        private void lblDistrict_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblAge_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonOkaySW_Click(object sender, EventArgs e)
        {
            Player = playerSearched;
            Close();
        }
    }
}
