using Dapper.Contrib.Extensions;
using System;
using System.Text;

namespace SportsMeet.Models
{
    public class Event
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

        public Event(String number, String name, String agelimit)
        {
            Id = 0;
            Sex = (byte) 0;

            Number = number;
            Name = name;
            long ageLimit = 0;
            long.TryParse(agelimit, out ageLimit);
            AgeLimit = ageLimit;
        }

        #endregion public constructors

        #region public members

        public Int64 Id { get; set; }

        public String Number { get; set; }

        public String Name { get; set; }

        public byte Sex { get; set; }

        [Write(false)]
        public String Gender
        {
            get { return Util.SexEnumToSex((Util.SexEnum)Sex); }
        }

        public Int64 AgeLimit { get; set; }

        #endregion public members

        public override String ToString()
        {
            return FullName;
        }

        [Write(false)]
        public String FullName
        {
            get
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
}