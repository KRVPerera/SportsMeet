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
        public Player Player { get; set; }

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
            labelPlayerAgeSW.Text = "";
            labelPlayerFullNameSW.Text = "";
            labelPlayerGenderSW.Text = "";
            labelPlayerNumberSW.Text = "";
        }

        private void btnSearchSW_Click(object sender, EventArgs e)
        {
            String playerNumber = tbxPlayerNumberSW.Text.Trim();
            String playerFirstName = tbxFirstNameSW.Text.Trim();
            String playerLastName = tbxLastNameSW.Text.Trim();
            String playerSchool = cbxSchoolSW.Text.Trim();
            String playerAge = numericUpDownAgeSW.Text.Trim();
            String playerDistrcit = cbxDistrictSW.Text.Trim();
            String playerRegion = cbxRegionsSW.Text.Trim();

  
            Player searchPlayer = new Player(playerNumber, playerFirstName, playerLastName, playerAge, playerSchool, playerDistrcit);
       
            var players = Data.DataBase.LoadPlayers(searchPlayer);
            Player foundPlayer = players.FirstOrDefault();
            if (foundPlayer != null)
            {
                playerSearched = foundPlayer;
                labelPlayerFullNameSW.Text = foundPlayer.FullName();
                labelPlayerNumberSW.Text = foundPlayer.Number;
                labelPlayerGenderSW.Text = foundPlayer.Gender;
                labelPlayerAgeSW.Text = foundPlayer.Age.ToString();
            }
            else
            {
                labelPlayerFullNameSW.Text = "";
                labelPlayerNumberSW.Text = "";
                labelPlayerGenderSW.Text = "";
                labelPlayerAgeSW.Text = "";
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
