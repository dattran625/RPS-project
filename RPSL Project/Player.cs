using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSL_Project
{
    abstract class Player
    {

        public int playerOneScore;
        public int playerTwoScore;
        public string chosenGesture;
        
       public  List<string> guessture;



        public Player()

        {
            playerOneScore = 0;
            playerTwoScore = 0;
            guessture = new List<string>(){"Rock", "Paper", "Scissors", "Lizard", "Spock" };


            guessture.Add("Rock");
            guessture.Add("Paper");
            guessture.Add("Scissor");
            guessture.Add("Lizard");
            guessture.Add("Spock");
        }

        public abstract void ChooseGesture();

       











    }

}
