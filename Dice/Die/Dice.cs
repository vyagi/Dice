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

        public void Roll()
        {
            foreach (var die in _diceSet)
            {
                die.Roll();
            }
        }

        public int[] Show()
        {
            int[] result = new int[_diceSet.Count];
            for (int i=0; i<_diceSet.Count; i++)
            {
                result[i] = _diceSet[i].Show();
            }

            return result;
        }
    }
}
