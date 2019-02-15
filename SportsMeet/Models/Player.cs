﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsMeet.Models
{
    class Player
    {
        public Player(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age; // TODO: sanitizer
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string FullName() => $"{FirstName} {LastName}".Trim();

        public override string ToString() => FullName();
    }
}
