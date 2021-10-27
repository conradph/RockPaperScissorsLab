using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLab
{
    class Randa : Player
    {
        public Randa() : base("Randa")
        {
            
        }
        public override RPS GenerateRPS()
        {
            Random Rand = new Random();
            int choice = Rand.Next(0, 3);
            Move = (RPS)choice;
            return (RPS)choice;

        }
    }
}
