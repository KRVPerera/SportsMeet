using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsMeet.Models
{
    class Player : IComparable
    {
        public Player(string firstName, string lastName, int age, string number)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age; // TODO: sanitizer
            Number = number;
        }

        public string Number { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string FullName() => $"{FirstName} {LastName}".Trim();

        public override string ToString() => FullName();
        public int CompareTo(object obj)
        {
            Player otherPlayer = obj as Player;
            if (otherPlayer.Id == Id)
            {
                return 0;
            }
            else if (otherPlayer.Id < Id)
            {
                return -1;
            }

            return 1;
        }
    }
}
