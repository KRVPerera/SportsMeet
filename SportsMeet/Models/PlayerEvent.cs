using System;

namespace SportsMeet.Models
{
    internal class PlayerEvent
    {
        #region public ctor

        public PlayerEvent(Int64 eventId, Int64 playerId)
        {
            EventId = eventId;
            PlayerId = playerId;
        }

        #endregion public ctor

        #region public members

        public Int64 EventId { get; set; }
        public Int64 PlayerId { get; set; }

        #endregion public members
    }
}