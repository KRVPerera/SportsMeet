using SportsMeet.Data;
using SportsMeet.Models;
using SportsMeet.Utils;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace SportsMeet
{
    public partial class AddMultipleEventsToPlayer : Form
    {
        public Player CurrentPlayer { get; set; }

        public AddMultipleEventsToPlayer(Player existingPlayer)
        {
            InitializeComponent();
            LoadPlayer(existingPlayer);
        }

        private void LoadPlayer(Player existingPlayer)
        {
            if (existingPlayer != null)
            {
                CurrentPlayer = existingPlayer;
                labelAddEventsPlayerNumber.Text = existingPlayer.Number;
                labelAddEventsPlayerAge.Text = existingPlayer.Age.ToString();
                labelAddEventsPlayerFullName.Text = existingPlayer.FullName();
                labelAddEventsPlayerGender.Text = Util.SexEnumToSex((Util.SexEnum) existingPlayer.Sex);
            }
        }

        private void LoadPlayerEvents()
        {
            PlayerEvent searchPlayerEvents = new PlayerEvent(0, CurrentPlayer.Id);
            List<PlayerEvent> playerEventList = DataBase.GetPlayerEventsByPlayer(searchPlayerEvents);
            if (playerEventList.Count > 0)
            {
                List<Event> eventList = DataBase.GetEventsForPlayerEvents(playerEventList);
                bindingSourceEventsBelongToPlayer.DataSource = eventList;
                bindingSourceEventsBelongToPlayer.ResetBindings(false);
            }
            else
            {
                bindingSourceEventsBelongToPlayer.DataSource = null;
                bindingSourceEventsBelongToPlayer.ResetBindings(false);
            }
        }

        private void LoadNonPlayerEvents()
        {
            PlayerEvent searchPlayerEvents = new PlayerEvent(0, CurrentPlayer.Id);
            List<int> eventIds = DataBase.GetPlayerEventsNotByPlayer(searchPlayerEvents);
            Console.WriteLine(eventIds);
            if (eventIds.Count > 0)
            {
                List<Event> eventList = DataBase.GetEventsForEventIds(eventIds);
                bindingSourceEventsDoesNotBelongToPlayer.DataSource = eventList;
                bindingSourceEventsDoesNotBelongToPlayer.ResetBindings(false);
            }
            else
            {
                bindingSourceEventsDoesNotBelongToPlayer.DataSource = null;
                bindingSourceEventsDoesNotBelongToPlayer.ResetBindings(false);
            }
        }

        private void btnAddEventsToPlayer_Click(object sender, EventArgs e)
        {
            List<Event> addEvents = new List<Event>();
            for (int index = 0; index < dataGridViewNonPlayerEvents.SelectedRows.Count; ++index)
            {
                var selectedRow = dataGridViewNonPlayerEvents.SelectedRows[index];
                var rowEvent = (Event)selectedRow.DataBoundItem;
                addEvents.Add(rowEvent);
            }

            bool changedOne = false;
            foreach (var removeEvent in addEvents)
            {
                if (PlayersTab.AddPlayerToEvent(CurrentPlayer.Id, removeEvent))
                {
                    changedOne = true;
                }
            }

            if (changedOne)
            {
                RefreshView();
            }
        }

        private void btnRemoveEventFromPlayer_Click(object sender, EventArgs e)
        {
            List<Event> removeEvents = new List<Event>();
            for (int index = 0; index < dataGridViewEventsBelongToPlayer.SelectedRows.Count; ++index)
            {
                var selectedRow = dataGridViewEventsBelongToPlayer.SelectedRows[index];
                var rowEvent = (Event)selectedRow.DataBoundItem;
                removeEvents.Add(rowEvent);
            }

            bool removedOne = false;
            foreach (var removeEvent in removeEvents)
            {
                Console.WriteLine(removeEvent.Id);
                if (PlayersTab.RemovelayerFromEvent(CurrentPlayer.Id, removeEvent))
                {
                    removedOne = true;
                }
            }

            if (removedOne)
            {
                RefreshView();
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

        private void btnChangePlayerPlayerEventsMgt_Click(object sender, EventArgs e)
        {
                SearchPlayer searchPlayer = new SearchPlayer();
                searchPlayer.ShowDialog();
                Player pl = searchPlayer.Player;
                LoadPlayer(pl);
                LoadPlayerEvents();
                LoadNonPlayerEvents();
        }
    }
}