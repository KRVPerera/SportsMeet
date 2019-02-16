using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsMeet.Models
{
    class Player : IComparable
    {
        public Player(string number, string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age; 
            Number = number;
        }

        public Player(int no, string number, string firstName, string lastName, int age, int schoolId)
        {
            Id = no;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Number = number;
            SchoolId = schoolId;
        }

        public Player()
        {
        }

        public int Id { get; set; }

        public string Number { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; } // TODO: sanitize

        public int SchoolId { get; set; }

        public string FullName() => $"{FirstName} {LastName}".Trim();

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
    }
}
