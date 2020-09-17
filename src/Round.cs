using System;
using System.Collections.Generic;
using System.Text;

namespace monaco_chess.src
{
    class Round
    {
        private int roundNum { get; set; }
        private List<Game> gameList { get; set; }
        private List<Match> matchList { get; set; }
        private bool isOver { get; set; }
    }
}
