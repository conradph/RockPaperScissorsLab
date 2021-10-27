using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLab
{
    class RPSApp
    {
        public UserPlayer User { get; set; }
        public Player Opponent { get; set; }
        public RPSApp()
        {

        }
        public void Game()
        {
            Console.WriteLine("Welcome to the Rock Paper Scissors Game!");
            CreateUser();
            ChooseOponent();
            Matchup();
            bool goOn = true;
            while (goOn)
            {
                Play();
                goOn = PlayAgain();
            }
            Results();
        }
        public void CreateUser()
        {
            string name = Program.GetInput("Enter a name for your character:");
            User = new UserPlayer(name);
        }
        public void ChooseOponent()
        {
            Console.WriteLine($"1. Rocky");
            Console.WriteLine($"2. Randa");
            int response = 0;
            while (true)
            {
                response = Program.GetInputInt("Which opponent would you like to face?");
                if (response == 1)
                {
                    Opponent = new Rocky();
                    break;
                }
                else if (response == 2)
                {
                    Opponent = new Randa();
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter only a 1 or 2");
                    continue;
                }
            }
        }
        public void Matchup()
        {
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine();
            Console.WriteLine($"Matchup: {User} Vs. {Opponent}");
            Console.WriteLine();
            Console.WriteLine("============================================");
        }
        public void Play()
        {
            User.GenerateRPS();
            Opponent.GenerateRPS();
            Console.WriteLine($"{User}: {User.Move}");
            Console.WriteLine($"{Opponent}: {Opponent.Move}");
            Player winner = DetermineWinner(User, Opponent);
            if (winner == null)
                Console.WriteLine("This is a tie");
            else
            {
                Console.WriteLine($"The winner is {winner}");
                winner.Wins++;
            }

        }
        public Player DetermineWinner(Player user, Player opponent)
        {
            if (user.Move == opponent.Move)
                return null;
            else if (user.Move == RPS.Rock && opponent.Move == RPS.Paper)
            {
                return opponent;
            }
            else if (user.Move == RPS.Rock && opponent.Move == RPS.Scissors)
            {
                return user;
            }
            else if (user.Move == RPS.Paper && opponent.Move == RPS.Rock)
            {
                return user;
            }
            else if (user.Move == RPS.Paper && opponent.Move == RPS.Scissors)
            {
                return opponent;
            }
            else if (user.Move == RPS.Scissors && opponent.Move == RPS.Paper)
            {
                return user;
            }
            else if (user.Move == RPS.Scissors && opponent.Move == RPS.Rock)
            {
                return opponent;
            }
            else return null;
        }
        public bool PlayAgain()
        {
            while (true)
            {
                string response = Program.GetInput("Would you like to continue? (y/n)").ToLower().Trim();
                if (response == "y")
                {
                    return true;
                }
                else if (response == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter either a y or n");
                    continue;
                }
            }

        }
        public void Results()
        {
            Player winner = null;
            if (User.Wins > Opponent.Wins)
                winner = User;
            else if (Opponent.Wins > User.Wins)
                winner = Opponent;
            
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine();
            Console.WriteLine($"Matchup: {User}: {User.Wins} Vs. {Opponent}: {Opponent.Wins}");
            Console.WriteLine();
            Console.WriteLine("============================================");
            if (winner == null)
            {
                Console.WriteLine("There was a tie :(");
            }
            else
            {
                Console.WriteLine($"The winner is {winner}!!!");
            }
        }

    }
}
