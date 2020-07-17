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
            Random theguess = new Random();

            int randomNumber = theguess.Next(0, guessture.Count); // 

            Console.WriteLine(guessture[randomNumber]);
            chosenGesture = guessture[randomNumber];

        
        }
    }
       

}
