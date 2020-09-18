using System;
using System.Collections.Generic;
using System.Text;

namespace monaco_chess.src
{
    class Round
    {
        public int roundNum { get; set; }
        public List<Game> gameList { get; set; }
        public List<Match> matchList { get; set; }
        public bool isOver { get; set; }
    }
}
