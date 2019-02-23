using System;

namespace SportsMeet.Models
{
    internal class School
    {
        #region public constructors

        public School(Int64 schoolId, String name, Int64 districId)
        {
            SchoolId = schoolId;
            Name = name;
            DistricId = districId;
        }

        #endregion public constructors

        #region public members

        public Int64 SchoolId { get; set; }

        public String Name { get; set; }

        public Int64 DistricId { get; set; }

        #endregion public members
    }
}