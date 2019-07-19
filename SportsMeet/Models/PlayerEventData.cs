using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SportsMeet.Models;

namespace SportsMeet.Utils
{
    class PlayerEventData
    {
        #region Public
        #region Constructors

        public PlayerEventData(Player player, Event eEvent)
        {
            _player = player;
            _event = eEvent;
        }

        public PlayerEventData(Int64 eventId, Int64 playerId)
        {
            _eventId = eventId;
            _playerId = playerId;
        }

        #endregion Constructors

        #region Properties

        public Player PlayerData
        {
            get { return _player; }
            set { _player = value; }
        }

        public Event EventData
        {
            get { return _event; }
            set { _event = value; }
        }

        #endregion Properties

        #endregion Public

        #region private data

        private Player _player;
        private Event _event;
        private Int64 _eventId;
        private Int64 _playerId;

        #endregion private data

    }
}
