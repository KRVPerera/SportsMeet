using System;

namespace SportsMeet.Models
{
    public class School
    {
        #region private data

        private String _name;

        #endregion private data


        #region public constructors

        public School(Int64 id, String name)
        {
            Id = id;
            Name = name;
        }

        #endregion public constructors

        #region public members

        public Int64 Id { get; set; }

        public String Name
        {
            get { return _name;}
            set
            {
                if (value != "UNKNOWN")
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("School name cannot be 'UNKNOWN'");
                }
            }
        }

        #endregion public members
    }
}