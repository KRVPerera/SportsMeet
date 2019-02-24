using SportsMeet.Data;
using SportsMeet.Models;
using System;
using System.Windows.Forms;

namespace SportsMeet.Utils
{
    internal class PlayersTab
    {
        public static Tuple<bool, long> AddPlayer(Player newPlayer)
        {
            Tuple<bool, long> result = new Tuple<bool, long>(false, 0);
            Player existingPlayer = DataBase.FindPlayer(newPlayer);

            if (existingPlayer != null)
            {
                DialogResult resultUser = MessageBox.Show("Player already exists. Do you want to override ?",
                    "Existing ID !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultUser == DialogResult.Yes)
                {
                    newPlayer.Id = existingPlayer.Id;
                    bool retVal = DataBase.EditPlayer(newPlayer);
                    result = new Tuple<bool, long>(true, newPlayer.Id);
                }
            }
            else
            {
                long id = DataBase.SavePlayer(newPlayer);
                result = new Tuple<bool, long>(true, id);
            }

            return result;
        }
    }
}