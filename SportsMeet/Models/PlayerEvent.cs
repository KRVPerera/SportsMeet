using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsMeet.Models
{
    class PlayerEvent
    {

        public PlayerEvent(Int64 eventId, Int64 playerId)
        {
            EventId = eventId;
            PlayerId = playerId;
        }

        public Int64 EventId { get; set; }
        public Int64 PlayerId { get; set; }
    }
}
