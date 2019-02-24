using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SportsMeet.Data;
using SportsMeet.Models;

namespace SportsMeet.Utils
{
    class PlayersTab
    {
        public static Tuple<bool, long> AddPlayer(Player newPlayer)
        {
            Tuple<bool, long> result;
            Player existingPlayer = DataBase.FindPlayer(newPlayer);

            if (existingPlayer != null)
            {
                DialogResult resultUser = MessageBox.Show("Player already exists. Do you want to override ?",
                    "Existing ID !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultUser == DialogResult.Yes)
                {
                    newPlayer.Id = existingPlayer.Id;
                    bool retVal = DataBase.EditPlayer(newPlayer);
                    return new Tuple<bool, long>(true, newPlayer.Id);
                }
            }
            else
            {
                long id = DataBase.SavePlayer(newPlayer);
                return new Tuple<bool, long>(true, id);
            }

            return new Tuple<bool, long>(false, 0);
        }
    }
}
