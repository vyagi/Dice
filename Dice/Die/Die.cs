using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieLogic
{
    public class Die
    {
        private int result;
        static Random rnd = new Random();
        public void Roll()
        {
            result = rnd.Next(0, 6);
        }

        public int Show()
        {
            return result;
        }
    }
}
