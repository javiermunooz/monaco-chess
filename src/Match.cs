using System;
using System.Collections.Generic;
using System.Text;

namespace monaco_chess.src
{
    class Match
    {
        private Club home { get; set; }
        private Club away { get; set; }
        private List<Game> gameList { get; set; }
        private List<float> results { get; set; }
    }
}
