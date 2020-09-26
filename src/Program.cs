using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Printing.IndexedProperties;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace monaco_chess.src
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerController playerController = new PlayerController();
            Club club = new Club("CAP", "Valladolid", "CyL", Country.ESP);
            Player javier = new Player("Muñoz Navarro", "Francisco Javier", club, 0, Country.ESP, new DateTime(1997,8,1), 1400, 1300);
            Player juan = new Player("Marcos Lomo", "Juan", club, 0, Country.ESP, new DateTime(1999, 3, 27), 1400, 1300);
            Player omar = new Player("García González", "Omar", club, 0, Country.ESP, new DateTime(1999, 3, 27), 1400, 1300);

            Tournament tourn = new Tournament("Pruba", "Yo", "Yo", "Yo", "Yo", "Here", Country.ESP, new DateTime(2020, 08, 01), new DateTime(2020, 08, 01), false);
            tourn.playerList.Add(javier);
            tourn.playerList.Add(juan);
            tourn.playerList.Add(omar);

            foreach(Player player in tourn.playerList)
            {
                System.Diagnostics.Debug.WriteLine(player);
            }

            tourn.updateStandings();

            foreach (Player player in tourn.playerStandings)
            {
                System.Diagnostics.Debug.WriteLine(player);
            }
        }
    }
}
