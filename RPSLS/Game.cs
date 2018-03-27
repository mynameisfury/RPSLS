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

        public void GetPlayer1Choice()
        {
            menu.MenuMessage = "Rock, paper, scissors, lizard or spock?";
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
            menu.MenuMessage = "Rock, paper, scissors, lizard or spock?";
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

        public void MainMenu()
        {
            menu.MenuMessage = "Start game, select human or cpu";
            menu.DisplayMessage();
            switch (Console.ReadLine()) {
                case "human":
                    menu.MenuMessage = "You picked a human opponent";
                    menu.DisplayMessage();
                    break;
                case "cpu":                
                    menu.MenuMessage = "You picked a computer opponent";
                    menu.DisplayMessage();
                    break;
                default:
                    menu.MenuMessage = "Invalid response.";
                    menu.DisplayMessage();
                    MainMenu();
                    break;

            }
        }
        public void ManageRounds()
        {
            GetPlayer1Choice();
            GetPlayer2Choice();
            if (player1.Status ==  player2.Status)
            {
                Console.WriteLine("It's a tie");
            }

        }
        public void RunGame()
        {

            ManageRounds();

            

            Console.WriteLine(player1.Status);
            Console.WriteLine(player2.Status);

        }

    }
}
