using SportsMeet.Data;
using SportsMeet.Models;
using SportsMeet.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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

        private void LoadNonPlayerEvents()
        {
            PlayerEvent searchPlayerEvents = new PlayerEvent(0, CurrentPlayer.Id);
            List<long> eventIds = DataBase.GetPlayerEventsNotByPlayer(searchPlayerEvents);
            Console.WriteLine(eventIds);
            if (eventIds.Count > 0)
            {
                List<Event> eventList = DataBase.GetEventsForEventIds(eventIds);
                if (eventList.Any())
                {
                    bindingSourceEventsDoesNotBelongToPlayer.DataSource = eventList;
                    bindingSourceEventsDoesNotBelongToPlayer.ResetBindings(false);
                }
            }
        }

        private void btnAddEventsToPlayer_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < dataGridViewNonPlayerEvents.SelectedRows.Count; index++)
            {
                var selectedRow = dataGridViewNonPlayerEvents.SelectedRows[index];
                var rowEvent = (Event)selectedRow.DataBoundItem;
                if (PlayersTab.AddPlayerToEvent(CurrentPlayer.Id, rowEvent))
                {
                    RefreshView();
                }
            }
        }

        private void RefreshView()
        {
            LoadPlayerEvents();
            LoadNonPlayerEvents();
        }

        private void AddMultipleEventsToPlayer_Load(object sender, EventArgs e)
        {
            RefreshView();
        }
    }
}