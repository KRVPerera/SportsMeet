using System;
using System.Text;

namespace SportsMeet.Models
{
    internal class Event
    {
        #region public constructors

        public Event(Int64 id, String number, String name, Byte sex, Int64 agelimit)
        {
            Id = id;
            Number = number;
            Name = name;
            Sex = sex;
            AgeLimit = agelimit;
        }
        
        #endregion public constructors

        #region public members

        public Int64 Id { get; set; }

        public String Number { get; set; }

        public String Name { get; set; }

        public byte Sex { get; set; }

        public String Gender
        {
            get { return Util.SexEnumToSex((Util.SexEnum) Sex); }
        }

        public Int64 AgeLimit { get; set; }

        #endregion public members

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder("U");
            sb.Append(AgeLimit);
            sb.Append(" ");
            Util.SexEnum sexEnum = (Util.SexEnum)Sex;
            sb.Append(Util.SexEnumToSex(sexEnum));
            sb.Append(" ");
            sb.Append(Name);
            return sb.ToString();
        }
    }
}