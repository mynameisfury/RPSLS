using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Contestant
    {
        public int points;

        public enum Conditions
        {
            WINNING,
            LOSING
        }

        public List<string> choices = new List<string>();

        public enum States
        {
            NONE,
            ROCK,
            PAPER,
            SCISSORS,
            LIZARD,
            SPOCK
        }
        
        public States Status = States.NONE;

        

        public void CreateList()
        {
            choices.Add("rock");
            choices.Add("paper");
            choices.Add("scissors");
            choices.Add("lizard");
            choices.Add("spock");          
        }

    }
}
