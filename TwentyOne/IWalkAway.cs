using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    interface IWalkAway
    {
        TwentyOneDealer Dealer { get; set; }

        //naming convention - start with upper case I 
        //everything is public in an interface
        void WalkAway(Player player);
    }
}
