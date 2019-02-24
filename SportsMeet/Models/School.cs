using System;

namespace SportsMeet.Models
{
    internal class School
    {
        #region public constructors

        public School(Int64 id, String name)
        {
            Id = id;
            Name = name;
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

        #endregion public members
    }
}