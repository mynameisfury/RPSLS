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



        public void RunGame()
        {
            contestant.CreateList();
            var test = contestant.choices[0];

            switch (contestant.UserInput)
            {
                //convert list to array
                case "rock":
                        contestant.Status = Contestant.States.ROCK;
                        break;

                    case "paper":
                        contestant.Status = Contestant.States.PAPER;
                        break;
                    case "scissors":
                        contestant.Status = Contestant.States.SCISSORS;
                        break;
                    case "lizard":
                        contestant.Status = Contestant.States.LIZARD;
                        break;
                    case "spock":
                        contestant.Status = Contestant.States.SPOCK;
                        break;
                default:
                    Console.WriteLine("Invalid response");
                    break;

                }

            Console.WriteLine(contestant.Status);

        }

    }
}
