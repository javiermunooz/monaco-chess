using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace monaco_chess.src
{
    class ClubController
    {
        List<Club> clubList;

        /// <summary>
        /// Creates an instance of ClubController class.
        /// </summary>
        public ClubController()
        {
            clubList = new List<Club>();
        }

        /// <summary>
        /// Adds a club to the club list.
        /// </summary>
        /// <param name="name">Name of the club.</param>
        /// <param name="city">City in which the club is based.</param>
        /// <param name="region">Region in which the club is based.</param>
        /// <param name="country">Country of origin of the club.</param>
        public void addClub(string name, string city, string region, Country country)
        {
            foreach(Club club_search in clubList)
            {
                if(club_search.name == name)
                {
                    throw new ExistingElementException(name + " is already registered as a club!");
                }
            }

            Club club = new Club(name, city, region, country);
            clubList.Add(club);
            return;
        }

        /// <summary>
        /// Removes a club from the club list.
        /// </summary>
        /// <param name="name">Name of the club to be deleted.</param>
        public void deleteClub(string name)
        {
            //Gets club's index or -1 if not found.
            int index = clubList.FindIndex(a => a.name == name);

            //If found, delete it.
            if (index != -1)
            {
                clubList.RemoveAt(index);
            }
            else
            {
                Debug.WriteLine(name + " could not be removed because it does not exist.");
            }

            return;
        }

        /// <summary>
        /// Edits any parameter of a given club
        /// </summary>
        /// <param name="club">To be edited club</param>
        /// <param name="name">New name</param>
        /// <param name="city">New city</param>
        /// <param name="region">New region</param>
        /// <param name="country">New country</param>
        public void editClub(Club club, string name, string city, string region, Country country)
        {
            //Gets club's index or -1 if not found.
            int index = clubList.FindIndex(a => a.name == club.name);

            clubList.RemoveAt(index);
            clubList.Add(new Club(name, city, region, country));

            return;
        }

        /// <summary>
        /// Provides the whole club list.
        /// </summary>
        /// <returns>Club list</returns>
        public List<Club> getClubList()
        {
            return clubList;
        }

        /// <summary>
        /// Get a club by its name
        /// </summary>
        /// <param name="name">Club's name</param>
        /// <returns>A club that matches 'name' or a exception if no club does. </returns>
        public Club getClubByName(string name)
        {
            int index = clubList.FindIndex(a => a.name == name);

            if (index != -1)
            {
                return clubList.ElementAt(index);
            }
            else
            {
                throw new NoSuchElementException(name + " is not a club!");
            }
        }
    }
}
