using System;

namespace SportsMeet.Models
{
    internal class Player : IComparable
    {
        #region public constrctors

        public Player(string number, string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Number = number;
        }

        public Player(string number, string firstName, string lastName, int age, int schoolId)
        {
            Number = number;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            SchoolId = schoolId;
        }

        public Player()
        {
        }

        #endregion public constrctors

        #region public members

        public string Number { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; } // TODO: sanitize

        public int SchoolId { get; set; }

        #endregion public members

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