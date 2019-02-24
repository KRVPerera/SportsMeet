using System;
using Dapper.Contrib.Extensions;

namespace SportsMeet.Models
{
    internal class Player : IComparable
    {
        #region public constrctors

        public Player(Int64 id, String number, String firstName, String lastName, Int64 age, Byte sex, Int64 schoolId, Int64 districtId)
        {
            Id = id;
            Number = number;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Sex = sex;
            SchoolId = schoolId;
            DistrictId = districtId;
        }

        public Player(String number)
        {
            Id = 0;
            Number = number;
            FirstName = "";
            LastName = "";
            Age = 0;
            Sex = 0;
            SchoolId = 0;
            DistrictId = 0;
        }

        #endregion public constrctors

        #region public properties

        public String Number { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public Int64 Age { get; set; }

        public byte Sex { get; set; }

        public Int64 SchoolId { get; set; }

        public Int64 DistrictId { get; set; }

        [Key]
        public Int64 Id { get; set; }

        #endregion public properties

        #region public  methods

        #endregion

        #region public derived members

        public string FullName() => $"{FirstName} {LastName}".Trim();

        #endregion public derived members

        #region public overrides

        public override string ToString() => FullName();

        public int CompareTo(object obj)
        {
            Player otherPlayer = obj as Player;

            if (otherPlayer.Age == Age)
            {
                return 0;
            }
            else if (otherPlayer.Age < Age)
            {
                return -1;
            }

            return 1;
        }

        #endregion public overrides
    }
}