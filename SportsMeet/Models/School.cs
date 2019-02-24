using System;

namespace SportsMeet.Models
{
    internal class School
    {
        #region public constructors

        public School(Int64 id, String name, Int64 districtId)
        {
            Id = id;
            Name = name;
            DistrictId = districtId;
        }

        public School(Int64 id, String name)
        {
            Id = id;
            Name = name;
        }

        #endregion public constructors

        #region public members

        public Int64 Id { get; set; }

        public String Name { get; set; }

        public Int64 DistrictId { get; set; }

        #endregion public members
    }
}