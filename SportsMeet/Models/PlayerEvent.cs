using System;

namespace SportsMeet.Models
{
    internal class PlayerEvent
    {
        public PlayerEvent(Int64 eventId, Int64 playerId)
        {
            EventId = eventId;
            PlayerId = playerId;
        }

        public PlayerEvent()
        {
        }

        public Int64 EventId { get; set; }
        public Int64 PlayerId { get; set; }
    }
}