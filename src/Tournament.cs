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

        /// <summary>
        /// Creates an instance of a Tournament
        /// </summary>
        /// <param name="name">Name of the tournament.</param>
        /// <param name="director">Tournament's director.</param>
        /// <param name="organizer">Tournament's organizer.</param>
        /// <param name="chiefArbiter">Tournament's chief arbiter</param>
        /// <param name="arbiter">Tournament's arbiter</param>
        /// <param name="location">City holding the tournament.</param>
        /// <param name="country">Country in which the the tournament is being played.</param>
        /// <param name="startDate">Start date.</param>
        /// <param name="endDate">End date.</param>
        /// <param name="clubTournament">True if it is a club tournament, false if player tournament.</param>
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

        /// <summary>
        /// Overrides ToString() method.
        /// </summary>
        /// <returns>A formatted string that shows information about the tournament.</returns>
        public override string ToString()
        {
            return "TOURNAMENT: " + name + "(" + country +")";
        }

        /// <summary>
        /// Sorts players based on their rating.
        /// </summary>
        public void updateInitialRankings()
        {
            bool playerDone;

            foreach (Player player in playerList.ToList())
            {
                playerDone = false;

                //Now we sort by rating
                while (playerDone == false)
                {
                    if (playerList.IndexOf(player) != 0)
                    {
                        int oldIndex = playerList.IndexOf(player);
                        int newIndex = oldIndex - 1;

                        Player previousPlayer = playerList.ElementAt(oldIndex - 1);

                        if (player.ratingInt > previousPlayer.ratingInt)
                        {
                            playerList.RemoveAt(oldIndex);
                            playerList.Insert(newIndex, player);
                        }
                        else if ((player.ratingInt == previousPlayer.ratingInt) && (player.ratingNat > previousPlayer.ratingNat))
                        {
                            playerList.RemoveAt(oldIndex);
                            playerList.Insert(newIndex, player);
                        }
                        else
                        {
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

            //Asign initial ranks
            foreach (Player player in playerList.ToList())
            {
                player.initialRank = playerList.IndexOf(player) + 1;
            }
        }

        /// <summary>
        /// Updates the standings
        /// </summary>
        public void updateStandings()
        {
            playerStandings = playerList;
            bool playerDone;

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

            foreach(Player player in playerStandings.ToList())
            {
                player.rank = playerStandings.IndexOf(player) + 1;
            }
        }

        
    }
}
