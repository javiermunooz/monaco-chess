using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace monaco_chess.src
{
    class PlayerController
    {
        List<Player> playerList;

        /// <summary>
        /// Creates an instance of PlayerController class.
        /// </summary>
        public PlayerController()
        {
            playerList = new List<Player>();
        }

        /// <summary>
        /// Adds a player to the player list
        /// </summary>
        /// <param name="lastName">Player's last name</param>
        /// <param name="firstName">Player's first name</param>
        /// <param name="club">Player's club</param>
        /// <param name="fideID">Player's FIDE ID</param>
        /// <param name="country">Country of origin of the player</param>
        /// <param name="yearBirth">Player's year of birth</param>
        /// <param name="ratingInt">Player's international ranting</param>
        /// <param name="ratingNat">Player's national rating</param>        
        public void addPlayer(string lastName, string firstName, Club club, int fideID, Country country, DateTime yearBirth, int ratingInt, int ratingNat)
        {
            foreach (Player player_search in playerList)
            {
                if (player_search.lastName == lastName && player_search.firstName == firstName)
                {
                    throw new ExistingElementException(lastName + ", " + firstName + " is already registered as a player!");
                }
            }

            Player player = new Player(lastName, firstName, club, fideID, country, yearBirth, ratingInt, ratingNat);
            playerList.Add(player);
            return;
        }

        /// <summary>
        /// Removes a player from the club list.
        /// </summary>
        /// <param name="lastName">Last of the player to be deleted.</param>
        /// <param name="firstName">First of the player to be deleted.</param>
        public void deletePlayer(string lastName, string firstName)
        {
            //Gets club's index or -1 if not found.
            int index = playerList.FindIndex(a => (a.lastName == lastName) && (a.firstName == firstName));

            //If found, delete it.
            if (index != -1)
            {
                playerList.RemoveAt(index);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine(lastName + ", " + firstName + " could not be removed because it does not exist.");
            }

            return;
        }

        /// <summary>
        /// Edit any parameter of a given player
        /// </summary>
        /// <param name="player">To be edited player</param>
        /// <param name="lastName">Player's last name</param>
        /// <param name="firstName">Player's first name</param>
        /// <param name="club">Player's club</param>
        /// <param name="fideID">Player's FIDE ID</param>
        /// <param name="country">Country of origin of the player</param>
        /// <param name="yearBirth">Player's year of birth</param>
        /// <param name="ratingInt">Player's international ranting</param>
        /// <param name="ratingNat">Player's national rating</param>  
        public void editPlayer(Player player, string lastName, string firstName, Club club, int fideID, Country country, DateTime yearBirth, int ratingInt, int ratingNat)
        {
            //Gets club's index or -1 if not found.
            int index = playerList.FindIndex(a => (a.lastName == player.lastName) && (a.firstName == player.firstName));

            playerList.RemoveAt(index);
            playerList.Add(new Player(lastName, firstName, club, fideID, country, yearBirth, ratingInt, ratingNat));

            return;
        }

        /// <summary>
        /// Provides the whole player list.
        /// </summary>
        /// <returns>Player list</returns>
        public List<Player> getPlayerList()
        {
            return playerList;
        }

        /// <summary>
        /// Get a player by its name
        /// </summary>
        /// <param name="lastName">Player's last name</param>
        /// <param name="firstName">Player's first name</param>
        /// <returns>A player that matches 'lastName' & 'firstName' or a exception if no player does. </returns>
        public Player getPlayerByName(string lastName, string firstName)
        {
            int index = playerList.FindIndex(a => (a.lastName == lastName) && (a.firstName == firstName));

            if (index != -1)
            {
                return playerList.ElementAt(index);
            }
            else
            {
                throw new NoSuchElementException(lastName + ", " + firstName + " is not a club!");
            }
        }
    }
}
