using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SportsMeet.Data;
using SportsMeet.Models;

namespace SportsMeet.Utils
{
    class EventsTab
    {

        public static bool AddEvent(String eventNumber, String ageText, String eventName, String sex)
        {
            if (String.IsNullOrEmpty(eventNumber))
            {
                MessageBox.Show("Invalid event number", "Invalid number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (!Int32.TryParse(ageText, out var age))
            {
                MessageBox.Show("Please enter a valid age limit", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Util.SexEnum sexByteEnum = Util.SexStringToEnum(sex);

                Event neweEvent = new Event(0, eventNumber, eventName, (byte)sexByteEnum, age);

                Event searchedNamedEvent = DataBase.GetEventByName(eventName);
                if (searchedNamedEvent != null)
                {
                    neweEvent.Id = searchedNamedEvent.Id;

                    DialogResult result = MessageBox.Show("Event already exists. Do you want to override ?",
                        "Existing event !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        return DataBase.EditEvent(neweEvent);
                    }
                    else
                    {
                        return false;
                    }
                    
                }

                Event searchedNumbderedEvent = DataBase.GetEventByNumber(eventNumber);
                if (searchedNumbderedEvent != null)
                {
                    neweEvent.Id = searchedNumbderedEvent.Id;

                    DialogResult result = MessageBox.Show("Event already exists. Do you want to override ?",
                        "Existing event !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        return DataBase.EditEvent(neweEvent);
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    DataBase.SaveEvent(neweEvent);
                    return true;
                }
            }

            return false;
        }

    }
}
