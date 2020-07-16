using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSL_Project
{
    class Human : Player
    { public string playerName;
        public Hand hand;



        public Human(string playerName)
        {
            this.playerName = playerName;
            hand = new Hand();

        }


        public void Userinput();
        {
        }
    }   







}

        
        
      
        
            

