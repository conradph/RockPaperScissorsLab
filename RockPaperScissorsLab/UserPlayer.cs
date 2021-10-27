using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLab
{
    class UserPlayer : Player
    {
        public UserPlayer(string Name) : base(Name)
        {
            
        }
        public override RPS GenerateRPS()
        {
            int response = 0;
            while (true)
            {
                DisplayChoices();
                response = Program.GetInputInt("Please select an option from above.");
                if (response >= 0 && response < 3)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            Move = (RPS)response;
            return (RPS)response;
        }
        
    }
}
