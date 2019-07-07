using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsMeet.Models
{
    class CompletePlayer : Player
    {

        public CompletePlayer(Int64 id, String number, String firstName, String lastName, Int64 age, Byte sex, Int64 schoolId, Int64 districtId, School school, District district) : base( id,  number,  firstName,  lastName,  age,  sex,  schoolId,  districtId)
        {
            School = school;
            District = district;
        }


        #region public propertis

        public School School { get; set; }

        public District District { get; set; }

        public List<Event> Events { get; }

        #endregion public propertis

        #region public members

        public void AddEvent(Event eEvent)
        {
            Events.Add(eEvent);
        }

        public void RemoveEvent(Event eEvent)
        {
            Events.Remove(eEvent);
        }

        #endregion public members
    }
}
