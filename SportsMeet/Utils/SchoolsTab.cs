using SportsMeet.Data;
using SportsMeet.Models;
using System;
using System.Windows.Forms;

namespace SportsMeet.Utils
{
    internal class SchoolsTab
    {
        public static bool AddSchool(String schoolName, String newSchoolName, bool editMode = false)
        {
            if (String.IsNullOrEmpty(schoolName))
            {
                MessageBox.Show("Invalid school name", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    School newSchool = new School(0, schoolName);
                    School newNameSchool = new School(0, newSchoolName);

                    School searchedSchool = DataBase.GetSchool(schoolName);
                    if (searchedSchool != null)
                    {
                        newNameSchool.Id = searchedSchool.Id;
                        if (!editMode)
                        {
                            MessageBox.Show("School already exists.",
                                        "Existing school !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        else
                        {
                            if (!String.IsNullOrEmpty(newSchoolName))
                            {
                                return DataBase.EditSchool(newNameSchool);
                            }
                        }
                    }
                    else
                    {
                        DataBase.SaveSchool(newSchool);
                        return true;
                    }
                }
                catch (Exception)
                {
                    throw;
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