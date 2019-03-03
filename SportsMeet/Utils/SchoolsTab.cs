using SportsMeet.Data;
using SportsMeet.Models;
using System;
using System.Windows.Forms;

namespace SportsMeet.Utils
{
    internal class SchoolsTab
    {
        public static bool AddSchool(String schoolName, bool editMode = false)
        {
            if (String.IsNullOrEmpty(schoolName))
            {
                MessageBox.Show("Invalid school name", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                School newSchool = new School(0, schoolName);

                School searchedSchool = DataBase.GetSchool(schoolName);
                if (searchedSchool != null)
                {
                    MessageBox.Show("School already exists.",
                                "Existing school !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    DataBase.SaveSchool(newSchool);
                    return true;
                }
            }
            return false;
        }

        public static bool DeleteSchool(String schoolName)
        {
            if (!String.IsNullOrEmpty(schoolName))
            {
                School searchedSchool = DataBase.GetSchool(schoolName);
                if (searchedSchool != null)
                {
                    return DataBase.RemoveSchool(searchedSchool);
                }
            }

            return false;
        }
    }
}