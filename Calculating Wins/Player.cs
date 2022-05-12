using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculating_Wins
{
    class Player
    {
        public int games;
        public int wins;
        //winrate is private
        private int winrate;

        //complete the method
        public int GetWinRate()
        {
            winrate = wins * 100 / games;
            return winrate;
            
        }
    }
}
