using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSL_Project
{
    class Game
    {
        public List<string> guesstures;
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
        
        
        
        public void RunGame()
        {


            if(playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine("Draw");
            }
            else if(playerOne.chosenGesture == "Rock" && playerTwo.chosenGesture == "Scissors")
            {
                Console.WriteLine(" Rock crushes Scissors");
                playerOne.playerOneScore++;
            }
            else if (playerOne.chosenGesture == "Rock" && playerTwo.chosenGesture == "Paper")
            {
                Console.WriteLine("Paper cover Rock");
                playerTwo.playerTwoScore++;
            }
            else if (playerOne.chosenGesture == "Rock" && playerTwo.chosenGesture== "Lizard")
            {
                Console.WriteLine("Rock smashes Lizard");
                playerOne.playerOneScore++;
            }
            else if(playerOne.chosenGesture == "Rock " && playerTwo.chosenGesture == "Spock")
            {
                Console.WriteLine("Spock Vaporizes Rock");
                playerTwo.playerTwoScore++;
            }
            else if(playerOne.chosenGesture == " Lizard" && playerTwo.chosenGesture == "Spock")
            {
                Console.WriteLine("Lizard poisons Spock");
                playerOne.playerOneScore++;
            }
            else if(playerOne.chosenGesture == " Spock" && playerTwo.chosenGesture == "Scissor")
            {
                Console.WriteLine("Spock Smasded Scissor");
                playerOne.playerOneScore++;
            }
            else if(playerOne.chosenGesture == "Scissor" && playerTwo.chosenGesture == "Lizard")
            {
                Console.WriteLine("Siccor decapitates Lizard");
                playerOne.playerOneScore++;
            }
            else if(playerOne.chosenGesture == "Lizard" && playerTwo.chosenGesture == "Paper")
            {
                Console.WriteLine("Lizzard eats Paper");
                playerOne.playerOneScore++;
            }
            else if (playerOne.chosenGesture == "Paper" && playerTwo.chosenGesture == "Spock")
            {
                Console.WriteLine("Paper disproves Spock");
            } else
            {
                Console.WriteLine(" Invalid Input");
            }


        }
    }
}
