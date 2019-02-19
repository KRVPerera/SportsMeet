using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsMeet.Models
{
    class Event
    {
        #region public constructors
            
        public Event() { }

        #endregion

        #region public members

        public int Id { get; set; }

        public string Name { get; set; }

        public bool Gender { get; set; }

        public int AgeLimit { get; set; }

        #endregion
    }
}
