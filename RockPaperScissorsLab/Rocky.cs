using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLab
{
    class Rocky : Player
    {
        public Rocky() : base("Rocky")
        {
            this.Move = RPS.Rock;
        }
        public override RPS GenerateRPS()
        {
            return Move;
        }
    }
}
