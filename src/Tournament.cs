using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace monaco_chess.src
{
    class Tournament
    {
        public string name { get; set; }
        public string director { get; set; }
        public string organizer { get; set; }
        public string chiefArbiter { get; set; }
        public string arbiter { get; set; }
        public string location { get; set; }
        public Country country { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public List<Player> playerList { get; set; }
        public List<Club> clubList { get; set; }
        public List<Player> playerStandings { get; set; }
        public List<Club> clubStandings { get; set; }
        public bool clubTournament { get; set; }

        public Tournament(string name, string director, string organizer, string chiefArbiter, string arbiter, string location, Country country, DateTime startDate, DateTime endDate, bool clubTournament)
        {
            this.name = name;
            this.director = director;
            this.organizer = organizer;
            this.chiefArbiter = chiefArbiter;
            this.arbiter = arbiter;
            this.location = location;
            this.country = country;
            this.startDate = startDate;
            this.endDate = endDate;
            this.clubTournament = clubTournament;
            this.playerList = new List<Player>();
            this.clubList = new List<Club>();
            this.playerStandings = new List<Player>();
            this.clubStandings = new List<Club>();
        }

        public override string ToString()
        {
            return "TOURNAMENT: " + name + "(" + country +")";
        }

        public void updateStandings()
        {
            playerStandings = playerList;
            bool playerDone = false;

            foreach(Player player in playerStandings.ToList())
            {
                playerDone = false; 

                 while (playerDone==false)
                 {
                    if (playerStandings.IndexOf(player) != 0)
                    {
                        int oldIndex = playerStandings.IndexOf(player);
                        int newIndex = oldIndex - 1;

                        Player previousPlayer = playerStandings.ElementAt(oldIndex - 1);

                        if (player.points > previousPlayer.points)
                        {
                            playerStandings.RemoveAt(oldIndex);
                            playerStandings.Insert(newIndex, player);
                        }
                        else if ((player.points == previousPlayer.points) && (player.des1 > previousPlayer.des1))
                        {
                            playerStandings.RemoveAt(oldIndex);
                            playerStandings.Insert(newIndex, player);
                        }
                        else if ((player.points == previousPlayer.points) && (player.des1 == previousPlayer.des1) && (player.des2 > previousPlayer.des2))
                        {
                            playerStandings.RemoveAt(oldIndex);
                            playerStandings.Insert(newIndex, player);
                        }
                        else if ((player.points == previousPlayer.points) && (player.des1 == previousPlayer.des1) && (player.des2 == previousPlayer.des2) && (player.des3 > previousPlayer.des3))
                        {
                            playerStandings.RemoveAt(oldIndex);
                            playerStandings.Insert(newIndex, player);
                        }
                        else
                        {
                            //Assign the player his new position
                            player.rank = oldIndex + 1;
                            //We are done with this player
                            playerDone = true;
                        }
                    }
                    else
                    {
                        playerDone = true;
                    }
                }
            }
        }
    }
}
