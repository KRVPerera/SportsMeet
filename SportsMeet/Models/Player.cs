﻿using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;

namespace SportsMeet.Models
{
    public class Player : IComparable
    {
        #region public constrctors

        public Player(Int64 id, String number, String firstName, 
            String lastName, Int32 age, Byte sex,
            Int64 schoolId, Int64 districtId, Int64 educationZoneId)
        {
            Id = id;
            Number = number;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Sex = sex;
            SchoolId = schoolId;
            DistrictId = districtId;
            EducationZoneId = educationZoneId;
        }

        public Player(String number, String firstName, String lastName, String age, String schoolId, String districtId)
        {
            Sex = (byte)0;
            Id = 0;
            
            Number = number;
            FirstName = firstName;
            LastName = lastName;
            if (!int.TryParse(age, out _age))
            {
                _age = -1;
            }

            long schoolIdP = -1;
            long.TryParse(schoolId, out schoolIdP);
            SchoolId = schoolIdP;

            long districtIdP = -1;
            long.TryParse(districtId, out districtIdP);
            DistrictId = districtIdP;
        }

        public Player(String number)
        {
            Id = 0;
            Number = number;
            Init();
        }

        public Player(Int64 id)
        {
            Id = id;
            Number = "";
            Init();
        }

        #endregion public constrctors


        #region private methods

        private void Init()
        {
            FirstName = "";
            LastName = "";
            Age = 0;
            Sex = 0;
            SchoolId = 0;
            DistrictId = 0;
            EducationZoneId = 0;
        }

        #endregion private methods


        #region public properties

        public String Number { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public Int32 Age
        {
            get { return _age; }
            set
            {
                if (value >= 0)
                {
                    _age = value;
                }
                else
                {
                    _age = 0;
                    throw new ArgumentOutOfRangeException("Age cannot be minus value");
                }
            }
        }

        public byte Sex { get; set; }

        public Int64 SchoolId { get; set; }

        public Int64 DistrictId { get; set; }

        public Int64 EducationZoneId { get; set; }

        [Key]
        public Int64 Id { get; set; }

        #endregion public properties


        #region public derived members

        public string FullName() => $"{FirstName} {LastName}".Trim();

        [Write(false)]
        public string Gender
        {
            get
            {
                return Util.SexEnumToSex((Util.SexEnum)Sex);
            }
        }

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


        #region private members

        private Int32 _age;

        #endregion private members
    }
}