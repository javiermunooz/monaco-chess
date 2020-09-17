using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace monaco_chess.src
{
    class Club
    {
        private string name { get; set; }
        private string city { get; set; }
        private string region { get; set; }
        private Country country { get; set; }
        private int initialRank { get; set; }
        private int rank { get; set; }
        private float points { get; set; }
        private float des1 { get; set; }
        private float des2 { get; set; }
        private float des3{ get; set; }
        private int numPlayers { get; set; }
        private List<Player> playerList { get; set; }
        private List<Match> matchList { get; set; }
        private bool isRetired { get; set; }
    }
}
