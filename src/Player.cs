using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace monaco_chess.src
{
    class Player
    {
        private string lastName { get; set; }
        private string firstName { get; set; }
        private int initialRank { get; set; }
        private int rank { get; set; }
        private Club club { get; set; }
        private int fideID { get; set; }
        private Country country { get; set; }
        private DateTime yearBirth { get; set; }
        private int ratingInt { get; set; }
        private int ratingNac { get; set; }
        private float points { get; set; }
        private float des1 { get; set; }
        private float des2 { get; set; }
        private float des3 { get; set; }
        private List<Game> gameList { get; set; }
        private bool isRetired { get; set; }

    }
}
