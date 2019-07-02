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

namespace SportsMeet
{
    public partial class SearchPlayer : Form
    {
        public SearchPlayer()
        {
            InitializeComponent();
        }

        private void SearchPlayer_Load(object sender, EventArgs e)
        {
            resetUi();
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

            String searchString = tbxPlayerNumberSW.Text.Trim();
            var playerList = Data.DataBase.LoadPlayers();
            var myRegex = new Regex(@"^" + searchString + ".*$");
            IEnumerable<Player> searchedPlayers = playerList.Where(player => myRegex.IsMatch(player.Number));
        }
    }
}
