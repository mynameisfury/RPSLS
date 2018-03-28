using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        Contestant contestant = new Contestant();
        public List<string> choices = new List<string>();
        Player player1 = new Player();
        Player player2 = new Player();
        CpuOpponent cpu = new CpuOpponent();
        Menu menu = new Menu();
        public int VictoryCondition = 2;

        public void GetCPUChoice()
        {
            Random RandomNumber = new Random();
            switch (RandomNumber.Next(0, 5))
            {
                case 1:
                    cpu.Status = Contestant.States.ROCK;
                    break;
                case 2:
                    cpu.Status = Contestant.States.PAPER;
                    break;
                case 3:
                    cpu.Status = Contestant.States.SCISSORS;
                    break;
                case 4:
                    cpu.Status = Contestant.States.LIZARD;
                    break;
                case 5:
                    cpu.Status = Contestant.States.SPOCK;
                    break;
            }
        }


        public void MainMenu()
        {
            menu.MenuMessage = "Start game, select human or cpu";
            menu.DisplayMessage();
            switch (Console.ReadLine())
            {
                case "human":
                    menu.MenuMessage = "You picked a human opponent";
                    menu.DisplayMessage();
                    ManageHumanRounds();

                    Console.WriteLine("Final score:");
                    Console.WriteLine("Player 1:" + player1.points);
                    Console.WriteLine("Player 2:" + player2.points);
                    break;
                case "cpu":
                    menu.MenuMessage = "You picked a computer opponent";
                    menu.DisplayMessage();
                    ManageCPURounds();

                    Console.WriteLine("Final score:");
                    Console.WriteLine("Player 1:" + player1.points);
                    Console.WriteLine("CPU:" + cpu.points);
                    break;
                default:
                    menu.MenuMessage = "Invalid response.";
                    menu.DisplayMessage();
                    MainMenu();
                    break;

            }
        }

        public void GetPlayer1Choice()
        {
            menu.MenuMessage = "Player 1, rock, paper, scissors, lizard or spock?";
            menu.DisplayMessage();

            switch (Console.ReadLine())
            {
                case "rock":
                    player1.Status = Contestant.States.ROCK;
                    break;
                case "paper":
                    player1.Status = Contestant.States.PAPER;
                    break;
                case "scissors":
                    player1.Status = Contestant.States.SCISSORS;
                    break;
                case "lizard":
                    player1.Status = Contestant.States.LIZARD;
                    break;
                case "spock":
                    player1.Status = Contestant.States.SPOCK;
                    break;
                default:
                    Console.WriteLine("Invalid response");
                    GetPlayer1Choice();
                    break;

            }
        }


        public void GetPlayer2Choice()
        {
            menu.MenuMessage = "Player 2, rock, paper, scissors, lizard or spock?";
            menu.DisplayMessage();

            switch (Console.ReadLine())
            {
                case "rock":
                    player2.Status = Contestant.States.ROCK;
                    break;
                case "paper":
                    player2.Status = Contestant.States.PAPER;
                    break;
                case "scissors":
                    player2.Status = Contestant.States.SCISSORS;
                    break;
                case "lizard":
                    player2.Status = Contestant.States.LIZARD;
                    break;
                case "spock":
                    player2.Status = Contestant.States.SPOCK;
                    break;
                default:
                    Console.WriteLine("Invalid response");
                    GetPlayer2Choice();
                    break;

            }
        }

      

        public void Player1WinCheck()
        {
            if (player1.Status == player2.Status)
            {
                Console.WriteLine("It's a tie");
            }
            else if (player1.Status == Contestant.States.ROCK && (player2.Status == Contestant.States.SCISSORS || player2.Status == Contestant.States.LIZARD))
            {
                Console.WriteLine("Player 1 wins");
                player1.points += 1;
            }
            else if (player1.Status == Contestant.States.PAPER && (player2.Status == Contestant.States.ROCK || player2.Status == Contestant.States.SPOCK))
            {
                Console.WriteLine("Player 1 wins");
                player1.points += 1;
            }
            else if (player1.Status == Contestant.States.SCISSORS && (player2.Status == Contestant.States.PAPER || player2.Status == Contestant.States.LIZARD))
            {
                Console.WriteLine("Player 1 wins");
                player1.points += 1;
            }
            else if (player1.Status == Contestant.States.LIZARD && (player2.Status == Contestant.States.SPOCK || player2.Status == Contestant.States.PAPER))
            {
                Console.WriteLine("Player 1 wins");
                player1.points += 1;
            }
            else if (player1.Status == Contestant.States.SPOCK && (player2.Status == Contestant.States.SCISSORS || player2.Status == Contestant.States.ROCK))
            {
                Console.WriteLine("Player 1 wins");
                player1.points += 1;
            }
        }

        public void Player2WinCheck()
        {
             if (player2.Status == Contestant.States.ROCK && (player1.Status == Contestant.States.SCISSORS || player1.Status == Contestant.States.LIZARD))
            {
                Console.WriteLine("Player 2 wins");
                player2.points += 1;
            }
            else if (player2.Status == Contestant.States.PAPER && (player1.Status == Contestant.States.ROCK || player1.Status == Contestant.States.SPOCK))
            {
                Console.WriteLine("Player 2 wins");
                player2.points += 1;
            }
            else if (player2.Status == Contestant.States.SCISSORS && (player1.Status == Contestant.States.PAPER || player1.Status == Contestant.States.LIZARD))
            {
                Console.WriteLine("Player 2 wins");
                player2.points += 1;
            }
            else if (player2.Status == Contestant.States.LIZARD && (player1.Status == Contestant.States.SPOCK || player1.Status == Contestant.States.PAPER))
            {
                Console.WriteLine("Player 2 wins");
                player2.points += 1;
            }
            else if (player2.Status == Contestant.States.SPOCK && (player1.Status == Contestant.States.SCISSORS || player1.Status == Contestant.States.ROCK))
            {
                Console.WriteLine("Player 2 wins");
                player2.points += 1;
            }

        }
        public void Player1WinCheckAgainstCPU()
        {
            if (player1.Status == cpu.Status)
            {
                Console.WriteLine("It's a tie");
            }
            else if (player1.Status == Contestant.States.ROCK && (cpu.Status == Contestant.States.SCISSORS || cpu.Status == Contestant.States.LIZARD))
            {
                Console.WriteLine("Player 1 wins");
                player1.points += 1;
            }
            else if (player1.Status == Contestant.States.PAPER && (cpu.Status == Contestant.States.ROCK || cpu.Status == Contestant.States.SPOCK))
            {
                Console.WriteLine("Player 1 wins");
                player1.points += 1;
            }
            else if (player1.Status == Contestant.States.SCISSORS && (cpu.Status == Contestant.States.PAPER || cpu.Status == Contestant.States.LIZARD))
            {
                Console.WriteLine("Player 1 wins");
                player1.points += 1;
            }
            else if (player1.Status == Contestant.States.LIZARD && (cpu.Status == Contestant.States.SPOCK || cpu.Status == Contestant.States.PAPER))
            {
                Console.WriteLine("Player 1 wins");
                player1.points += 1;
            }
            else if (player1.Status == Contestant.States.SPOCK && (cpu.Status == Contestant.States.SCISSORS || cpu.Status == Contestant.States.ROCK))
            {
                Console.WriteLine("Player 1 wins");
                player1.points += 1;
            }
        }

        public void CPUWinCheck()
        {
            if (cpu.Status == Contestant.States.ROCK && (player1.Status == Contestant.States.SCISSORS || player1.Status == Contestant.States.LIZARD))
            {
                Console.WriteLine("CPU wins");
                cpu.points += 1;
            }
            else if (cpu.Status == Contestant.States.PAPER && (player1.Status == Contestant.States.ROCK || player1.Status == Contestant.States.SPOCK))
            {
                Console.WriteLine("CPU wins");
                cpu.points += 1;
            }
            else if (cpu.Status == Contestant.States.SCISSORS && (player1.Status == Contestant.States.PAPER || player1.Status == Contestant.States.LIZARD))
            {
                Console.WriteLine("CPU wins");
                cpu.points += 1;
            }
            else if (cpu.Status == Contestant.States.LIZARD && (player1.Status == Contestant.States.SPOCK || player1.Status == Contestant.States.PAPER))
            {
                Console.WriteLine("CPU wins");
                cpu.points += 1;
            }
            else if (cpu.Status == Contestant.States.SPOCK && (player1.Status == Contestant.States.SCISSORS || player1.Status == Contestant.States.ROCK))
            {
                Console.WriteLine("CPU wins");
                cpu.points += 1;
            }

        }


        public void ManageHumanRounds()
        {
            int i = 0;
            while (i < 100)
            {
                GetPlayer1Choice();
                GetPlayer2Choice();
                Player1WinCheck();
                Player2WinCheck();
                if (player1.points == VictoryCondition)
                {
                    Console.WriteLine("Player 1 achieves grand victory");
                    break;
                }
                if (player2.points == VictoryCondition)
                {
                    Console.WriteLine("Player 2 achieves grand victory");
                    break;
                }
                i++;


            }


        }


        public void ManageCPURounds()
        {
            int i = 0;
            while (i < 100)
            {
                GetPlayer1Choice();
                GetCPUChoice();
                Player1WinCheckAgainstCPU();
                CPUWinCheck();
                if (player1.points == VictoryCondition)
                {
                    Console.WriteLine("Player 1 achieves grand victory");
                    break;
                }
                if (cpu.points == VictoryCondition)
                {
                    Console.WriteLine("CPU achieves grand victory");
                    break;
                }
                i++;


            }
        }
      
    }
}
