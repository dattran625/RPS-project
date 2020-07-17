using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSL_Project
{
    class CPU: Player
    {
        


        public CPU()
        {
        }


        public override void ChooseGesture()
        {
            Random rng = new Random();

            int randomNumber = rng.Next(0, guessture.Count); // 

            Console.WriteLine(guessture[randomNumber]);
            chosenGesture = guessture[randomNumber];

            //if( randomNumber == 0)
            //{
            //    Console.WriteLine(guessture[0]);
            //    chosenGesture = guessture[0];
            //}
        }
    }
       

}
