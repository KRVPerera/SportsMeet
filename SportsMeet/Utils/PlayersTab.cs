using SportsMeet.Data;
using SportsMeet.Models;
using System;
using System.Windows.Forms;

namespace SportsMeet.Utils
{
    internal class PlayersTab
    {
        public static Tuple<bool, long> AddPlayer(Player newPlayer, bool quiet = false)
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

        public static bool AddPlayerToEvent(long playerId, Event currentEvent)
        {
            Player searchMe = new Player(playerId, "", "", "", 0, 0, 0, 0);
            Player player = DataBase.FindPlayerById(searchMe);

            if (player == null) return false;

            if (currentEvent.AgeLimit <= player.Age)
            {
                MessageBox.Show("Player exceeds events age limit! ",
                    "Player age exceeds!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (currentEvent.Sex != player.Sex)
            {
                Util.SexEnum eventSex = (Util.SexEnum)currentEvent.Sex;
                Util.SexEnum playerSex = (Util.SexEnum)player.Sex;

                if (!(eventSex == Util.SexEnum.NOT_KNOWN || eventSex == Util.SexEnum.NOT_APPLICABLE))
                {
                    return false;
                }
            }
            PlayerEvent playerEvent = new PlayerEvent(currentEvent.Id, playerId);

            PlayerEvent searched = DataBase.GetPlayerEvent(playerEvent);

            if (searched == null)
            {
                long id = DataBase.SavePlayerEvent(playerEvent);
                return id >= 0;
            }
            return true;
        }

        public static bool SavePlayer(Player newPlayer)
        {
            return DataBase.EditPlayer(newPlayer);
        }

        public static bool RemovelayerFromEvent(long currentPlayerId, Event rowEvent)
        {
            PlayerEvent playerEvent = new PlayerEvent(rowEvent.Id, currentPlayerId);

            PlayerEvent searched = DataBase.GetPlayerEvent(playerEvent);

            if (searched != null)
            {
                return DataBase.Delete(playerEvent);
            }

            return false;
        }
    }
}