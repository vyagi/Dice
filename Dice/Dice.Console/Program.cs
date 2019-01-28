using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DieLogic;

namespace DiceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many dices you want to roll: ");
            int roll = Convert.ToInt32(Console.ReadLine());
            Die die = new Die();
            for (int i = 0; i < roll; i++) 
            {
                die.Roll();
                int val = die.Show();
                int t = roll - i;
                if (t <= 1)
                {
                    Console.WriteLine(val + " ");
                } else
                Console.Write(val + ", ");             
            }
            
            
            
        }
    }
}
