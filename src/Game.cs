using System.Linq;

namespace monaco_chess.src
{
    /// <summary>
    /// Chess game between two players.
    /// </summary>
    class Game
    {
        public Player white { get; set; }
        public Player black { get; set; }
        public string result
        {
            /// <returns>
            /// Current game's result.
            /// </returns>
            get
            {
                return result;
            }
            /// <exception cref="InvalidResultException">Thrown when the result is not included in 
            /// the valid result list.</exception>
            set
            {
                string[] validResults = { "1:0", "0.5:0.5", "0:1", "+:-", "-:+", "0:0" };

                if (!validResults.Contains(result)) {
                    throw new InvalidResultException();
                }
            }
        }

        /// <summary>
        /// Creates an instance of a game.
        /// </summary>
        /// <param name="white">White player</param>
        /// <param name="black">Black player</param>
        public Game(Player white, Player black)
        {
            this.white = white;
            this.black = black;
            result = "?:?";
        }

        /// <summary>
        /// Displays a game's result.
        /// </summary>
        /// <returns>A formatted string containing both players and the result.</returns>
        public override string ToString()
        {
            int colonPos = result.IndexOf(':');
            string whiteResult;
            string blackResult;

            if (colonPos == 1) //If result is not a draw
            {
                whiteResult = result.Substring(0, 1);
                blackResult = result.Substring(2, 1);
            }
            else
            {
                whiteResult = result.Substring(0, 3);
                blackResult = result.Substring(4, 3);
            }

            return white.lastName
                   + ", "
                   + white.firstName
                   + " "
                   + whiteResult
                   + " - "
                   + blackResult
                   + " "
                   + black.lastName
                   + ", "
                   + black.firstName;
        }
    }
}
