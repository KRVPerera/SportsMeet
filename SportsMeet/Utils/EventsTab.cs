﻿using SportsMeet.Data;
using SportsMeet.Models;
using System;
using System.Windows.Forms;

namespace SportsMeet.Utils
{
    internal class EventsTab
    {
        public static bool AddEvent(String eventNumber, String ageText, String eventName, String sex, bool editMode = false)
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
                    DialogResult result = DialogResult.Yes;
                    if (!editMode)
                    {
                        result = MessageBox.Show("Event already exists. Do you want to override ?",
                            "Existing event !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    }

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

                    DialogResult result = DialogResult.Yes;
                    if (!editMode)
                    {
                        result = MessageBox.Show("Event already exists. Do you want to override ?",
                            "Existing event !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    }
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

        public static Event SearchEvent(String eventNumber, String ageText, String eventName, String sex)
        {
            if (!String.IsNullOrEmpty(eventNumber))
            {
                Event searchedNumberedEvent = DataBase.GetEventByNumber(eventNumber);
                if (searchedNumberedEvent != null)
                {
                    return searchedNumberedEvent;
                }
            }

            if (!String.IsNullOrEmpty(eventName))
            {
                Event searchedNamedEvent = DataBase.GetEventByName(eventName);
                if (searchedNamedEvent != null)
                {
                    return searchedNamedEvent;
                }
            }

            if (!String.IsNullOrEmpty(ageText) && Int32.TryParse(ageText, out var age))
            {
                Event searchedAgedEvent = DataBase.GetEventByAgeLimit(age);
                if (searchedAgedEvent != null)
                {
                    return searchedAgedEvent;
                }
            }

            return null;
        }

        public static bool DeleteEvent(String eventNumber, String ageText, String eventName, String sex)
        {
            if (!String.IsNullOrEmpty(eventNumber))
            {
                Event searchedNumberedEvent = DataBase.GetEventByNumber(eventNumber);
                if (searchedNumberedEvent != null)
                {
                    return DataBase.RemoveEvent(searchedNumberedEvent);
                }
            }

            return false;
        }
    }
}