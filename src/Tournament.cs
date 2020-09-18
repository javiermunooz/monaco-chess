using System;
using System.Collections.Generic;
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
    }
}
