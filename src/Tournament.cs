using System;
using System.Collections.Generic;
using System.Text;

namespace monaco_chess.src
{
    class Tournament
    {
        private string name { get; set; }
        private string director { get; set; }
        private string organizer { get; set; }
        private string chiefArbiter { get; set; }
        private string arbiter { get; set; }
        private string location { get; set; }
        private Country country { get; set; }
        private DateTime startDate { get; set; }
        private DateTime endDate { get; set; }
        private List<Player> playerList { get; set; }
        private List<Club> clubList { get; set; }
        private List<Player> playerStandings { get; set; }
        private List<Club> clubStandings { get; set; }
    }
}
