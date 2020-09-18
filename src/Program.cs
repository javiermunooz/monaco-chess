using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace monaco_chess.src
{
    class Program
    {
        static void Main(string[] args)
        {
            Club club = new Club("CAP", "Valladolid", "CyL", Country.ESP);
            Player white = new Player("Muñoz Navarro", "Francisco Javier", club, 12345, Country.ESP, DateTime.Today, 1900, 1850);
            Player black = new Player("Juez Pérez", "Adriana", club, 12345, Country.ESP, DateTime.Today, 1900, 1850);

            Game game = new Game(white, black);
            System.Diagnostics.Debug.WriteLine(game.ToString());
            Console.WriteLine(game.ToString());
            game.result = "1:0";
            System.Diagnostics.Debug.WriteLine(game.ToString());
            Console.WriteLine(game.ToString());
            game.result = "0.5:0.5";
            System.Diagnostics.Debug.WriteLine(game.ToString());
            Console.WriteLine(game.ToString());
            game.result = "0:1";
            System.Diagnostics.Debug.WriteLine(game.ToString());
            Console.WriteLine(game.ToString());
            game.result = "+:-";
            System.Diagnostics.Debug.WriteLine(game.ToString());
            Console.WriteLine(game.ToString());
            game.result = "-:+";
            System.Diagnostics.Debug.WriteLine(game.ToString());
            Console.WriteLine(game.ToString());
            game.result = "0:0";
            System.Diagnostics.Debug.WriteLine(game.ToString());
            Console.WriteLine(game.ToString());
        }
    }
}
