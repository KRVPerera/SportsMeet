using System;
using SportsMeet.Data;
using SportsMeet.Models;

namespace SportsMeet.Utils
{
    class SchoolsTab
    {
        public static bool AddSchool(String schoolName)
        {
            School newSchool = new School(0, schoolName);
            DataBase.SaveSchool(newSchool);
            return true;
        }
    }
}
