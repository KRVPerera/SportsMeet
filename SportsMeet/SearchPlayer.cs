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
using SportsMeet.Data;

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
            var autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(DataBase.LoadPlayerNumbers().ToArray());
            tbxPlayerNumberSW.AutoCompleteCustomSource = autoComplete;

            cleanUi();
        }

        private void cleanUi()
        {
            labelAge.Text = "";
            llbFirstName.Text = "";
            llbLastName.Text = "";
            labelProvince.Text = "";
            labelEducationZone.Text = "";
            labelSchool.Text = "";
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
                LoadPlayer(foundPlayer);
            }
            else
            {
                playerSearched = null;
            }
        }

        private void buttonOkaySW_Click(object sender, EventArgs e)
        {
            Player = playerSearched;
            Close();
        }

        private void LoadPlayer(Player player)
        {


            labelAge.Text = player.Age.ToString();
            llbFirstName.Text = player.FirstName;
            llbLastName.Text = player.LastName;

            labelSchool.Text = player.SchoolId.ToString();
            School school = DataBase.GetSchool(player.SchoolId);
            if (school != null)
            {
                labelSchool.Text = school.Name;
            }


            labelProvince.Text = player.DistrictId.ToString();
            District district = DataBase.GetDistrict(player.DistrictId);
            if (district != null)
            {
                labelProvince.Text = district.Name;
            }


            labelEducationZone.Text = player.EducationZoneId.ToString();
            EducationZone educationZone = DataBase.GetEducationZone(player.EducationZoneId);
            if (educationZone != null)
            {
                labelEducationZone.Text = educationZone.Name;
            }
        }

        private void tbxPlayerNumberSW_MouseEnter(object sender, EventArgs e)
        {
            cleanUi();
        }
    }
}
