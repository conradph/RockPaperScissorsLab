using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLab
{
    enum RPS
    {
        Rock,
        Paper,
        Scissors
    }
    abstract class Player
    {
        public string Name { get; set; }
        public RPS Move { get; set; }
        public int Wins { get; set; } = 0;

        public Player(string Name)
        {
            this.Name = Name;
        }
        public abstract RPS GenerateRPS();
        public override string ToString()
        {
            return Name;
        }
        public virtual void DisplayChoices()
        {
            Console.WriteLine($"0. {(RPS)0}");
            Console.WriteLine($"1. {(RPS)1}");
            Console.WriteLine($"2. {(RPS)2}");
        }

    }
}
