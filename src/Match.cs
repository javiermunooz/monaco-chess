using System;
using System.Collections.Generic;
using System.Text;

namespace monaco_chess.src
{
    class Match
    {
        public Club home { get; set; }
        public Club away { get; set; }
        public List<Game> gameList { get; set; }
        public List<float> results { get; set; }
    }
}
