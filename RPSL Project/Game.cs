using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSL_Project
{
    class Game
    {
        public List<string> gesstures;
        public Player playerOne;
        public Player playerTwo;


        public Game()
        {
            playerOne = new Human();
            ChooseTypeOfPlayerTwo();
        }

        public void DisplayRules()
        {
            //Display rules
        }

        public void ChooseTypeOfPlayerTwo()
        {
           
            Console.WriteLine("Do you want 1 or 2 player game?");
            string input = Console.ReadLine();
            if (input == "1")
            {
                playerTwo = new CPU();
            }
            else if (input == "2")
            {
                playerTwo = new Human();
            }
            

        }
    }
}
