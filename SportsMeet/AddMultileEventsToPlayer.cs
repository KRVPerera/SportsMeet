using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SportsMeet.Data;
using SportsMeet.Models;

namespace SportsMeet
{
    public partial class AddMultipleEventsToPlayer : Form
    {
        public Player CurrentPlayer { get; }

        public AddMultipleEventsToPlayer(Player existingPlayer)
        {
            InitializeComponent();
            CurrentPlayer = existingPlayer;

            labelAddEventsPlayerNumber.Text = existingPlayer.Number;
            labelAddEventsPlayerAge.Text = existingPlayer.Age.ToString();
            labelAddEventsPlayerFullName.Text = existingPlayer.FullName();
            labelAddEventsPlayerGender.Text = Util.SexEnumToSex((Util.SexEnum)existingPlayer.Sex);

            LoadPlayerEvents();
        }

        private void LoadPlayerEvents()
        {
            PlayerEvent searchPlayerEvents = new PlayerEvent(0, CurrentPlayer.Id);
            List<PlayerEvent> playerEventList = DataBase.GetPlayerEventsByPlayer(searchPlayerEvents);
            if (playerEventList.Count > 0)
            {
                List<Event> eventList = DataBase.GetEventsForPlayerEvents(playerEventList);
                if (eventList.Any())
                {
                    bindingSourceEventsBelongToPlayer.DataSource = eventList;
                    bindingSourceEventsBelongToPlayer.ResetBindings(false);
                }
            }
        }

        private void btnAddEventsToPlayer_Click(object sender, EventArgs e)
        {

        }

        private void AddMultipleEventsToPlayer_Load(object sender, EventArgs e)
        {

        }
    }
}
