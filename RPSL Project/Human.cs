using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSL_Project
{
    class Human : Player
    {
        



        public Human ()
        {
           


        }

        
        
        public override void ChooseGesture()
        { 
            Console.WriteLine("Pick a Gesture 1 = Rock,2 = paper,3 = Scissor, 4 = Lizard, 5 = Spock");
            string input = Console.ReadLine();
            if(input == "1")
            {
                Console.WriteLine(guessture[0]);
                chosenGesture = guessture[0];
            }
            else if (input == "2")
            {
                Console.WriteLine(guessture[1]);

            }else if (input == "3")
            {
                Console.WriteLine(guessture[2]);
            }else if ( input == "4")
            {
                Console.WriteLine(guessture[3]);
            }else if ( input == "5")
            {
                Console.WriteLine(guessture[4]);
            }else
            {
                Console.WriteLine("invlaid input");
            }
        }

    }  
}

        
        
        
    









        
        
      
        
            

