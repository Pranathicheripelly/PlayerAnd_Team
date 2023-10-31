using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAnd_Team
{
    class OneDayTeam:ITeam
    {

        public static List<Player> oneDayTeam = new List<Player>();
        public OneDayTeam()
        {
            oneDayTeam = new List<Player>();
        }

        public void Add(Player player)
        {
            if (OneDayTeam.oneDayTeam.Count < 11)
            {
                OneDayTeam.oneDayTeam.Add(player);
                Console.WriteLine("Player is added successfully");
            }
            else
            {
                Console.WriteLine("Cannot add more than 11 players to the team.");
            }
        }

        public void Remove(int playerId)
        {
            Player player = OneDayTeam.oneDayTeam.Find(p => p.PlayerId == playerId);
            if (player != null)
            {
                OneDayTeam.oneDayTeam.Remove(player);
                Console.WriteLine("Player is removed successfully");
            }
            else
            {
                Console.WriteLine("Player not found in the team.");
            }
        }

        public Player GetPlayerById(int playerId)
        {
            return OneDayTeam.oneDayTeam.Find(p => p.PlayerId == playerId);
        }

        public Player GetPlayerByName(string playerName)
        {
            return OneDayTeam.oneDayTeam.Find(p => p.PlayerName == playerName);
        }

        public List<Player> GetAllPlayers()
        {
            return OneDayTeam.oneDayTeam;
        }
    }

}

