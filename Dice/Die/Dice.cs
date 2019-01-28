using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieLogic
{
    class Dice
    {
        private List<Die> _diceSet = new List<Die>();

        public Dice(int count)
        {
            for (int i=0; i<count;i++)
            {
                _diceSet.Add(new Die());
            }
        }
    }
}
