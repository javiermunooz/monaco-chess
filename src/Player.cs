using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace monaco_chess.src
{
    class Player
    {
        public string lastName { get; set; }
        public string firstName { get; set; }
        public int initialRank { get; set; }
        public int rank { get; set; }
        public Club club { get; set; }
        public int fideID { get; set; }
        public Country country { get; set; }
        public DateTime yearBirth { get; set; }
        public int ratingInt { get; set; }
        public int ratingNat { get; set; }
        public float points { get; set; }
        public float des1 { get; set; }
        public float des2 { get; set; }
        public float des3 { get; set; }
        public List<Game> gameList { get; set; }
        public bool isRetired { get; set; }

        /// <summary>
        /// Creates an instance of a player.
        /// </summary>
        /// <param name="lastName">Surname(s).</param>
        /// <param name="firstName">Given name(s).</param>
        /// <param name="club">Player's club. Must be an instace of the Club class.</param>
        /// <param name="fideID">Fide ID.</param>
        /// <param name="country">Country of origin.</param>
        /// <param name="yearBirth">Year of birth.</param>
        /// <param name="ratingInt">International rating.</param>
        /// <param name="ratingNat">National rating.</param>
        public Player(string lastName, string firstName, Club club, int fideID, Country country, DateTime yearBirth, int ratingInt, int ratingNat)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.club = club;
            this.fideID = fideID;
            this.country = country;
            this.yearBirth = yearBirth;
            this.ratingInt = ratingInt;
            this.ratingNat = ratingNat;
            this.initialRank = 0;
            this.rank = 0;
            this.points = 0;
            this.des1 = 0;
            this.des2 = 0;
            this.des3 = 0;
            this.gameList = new List<Game>();
            this.isRetired = false;
        }

        /// <summary>
        /// Displays information about the player.
        /// </summary>
        /// <returns>A formetted string with all relevant standings params.</returns>
        public override string ToString()
        {
            if (isRetired == true){ 
                return lastName + ", " + firstName + "  --> RETIRED"; 
            }
            else {
                return lastName + ", " + firstName + "  " + points + "  " + des1 + "  " + des2 + "  " + des3;
            }
        }

        //TODO: BUCHHOLZ AND OTHER TIE-BREAK SYSTEMS
    }
}
