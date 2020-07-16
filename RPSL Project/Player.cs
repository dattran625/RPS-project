using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSL_Project
{
    class Player
    {
        public int playerOneScore;
        public int playerTwoScore;
        public Hand hand;


        public Player()
        
       {
            playerOneScore = 0;
            playerTwoScore = 0;
            hand = new Hand();
            

       }

    }

}
