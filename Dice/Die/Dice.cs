using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die
{
    class Dice
    {
        private List<DieLogic.Die> DiceSet = new List<DieLogic.Die>();
        private int count;

        public Dice(int count)
        {
            for (int i=0; i<count;i++)
            {
                DiceSet.Add(new DieLogic.Die());
            }
        }
    }
}
