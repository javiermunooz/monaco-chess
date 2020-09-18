using System.Collections.Generic;

namespace monaco_chess.src
{
    class Club
    {
        public string name { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public Country country { get; set; }
        public int initialRank { get; set; }
        public int rank { get; set; }
        public float points { get; set; }
        public float des1 { get; set; }
        public float des2 { get; set; }
        public float des3 { get; set; }
        public int numPlayers { get; set; }
        public List<Player> playerList { get; set; }
        public List<Match> matchList { get; set; }
        public bool isRetired { get; set; }

        public Club(string name, string city, string region, Country country)
        {
            this.name = name;
            this.city = city;
            this.region = region;
            this.country = country;
            this.playerList = playerList;
            this.initialRank = 0;
            this.rank = 0;
            this.points = 0;
            this.des1 = 0;
            this.des2 = 0;
            this.des3 = 0;
            this.matchList = new List<Match>();
            this.isRetired = false;
        }

        public override string ToString()
        {
            if (isRetired == true)
            {
                return name + " --> RETIRED";
            }
            else
            {
                return name + "  " + points + "  " + des1 + "  " + des2 + "  " + des3;
            }
        }
    }
}
