using System;
using System.Collections.Generic;
using System.Text;

namespace monaco_chess.src
{
    class Tiebreaker
    {
        public string method;
        public float value;

        // <summary>
        // Creates an instance of a Tiebreaker object
        // </summary>
        // <param name="method">Name of the selected tiebreaking algorithm</param>
        public Tiebreaker(string method)
        {
            this.method = method;
            this.value = 0;
        }

        // <summary>
        // Creates an instance of a Tiebreaker object
        // </summary>
        // <param name="method">Name of the selected tiebreaking algorithm</param>
        // <param name="value">Initial value for the selected algorithm</param>
        public Tiebreaker(string method, float value)
        {
            this.method = method;
            this.value = value;
        }

        //TODO: Update score according to this.method algorithm
        public float UpdateValue()
        {
            if (this.method == "buchholz")
            {

            }

            return 0;
        }
    }
}
