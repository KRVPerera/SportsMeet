using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsMeet.Models
{
    class Event
    {
        #region public constructors

        public Event(Int64 id, String number, String name, byte sex, Int64 ageLimit)
        {
            Id = id;
            Number = number;
            Name = name;
            Sex = sex;
            AgeLimit = ageLimit;
        }

        #endregion

        #region public members

        public Int64 Id { get; set; }

        public String Number { get; set; }

        public String Name { get; set; }

        public byte Sex { get; set; }

        public Int64 AgeLimit { get; set; }

        #endregion
    }
}
