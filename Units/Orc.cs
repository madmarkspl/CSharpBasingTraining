using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Units
{
    public class Orc
    {
        public int _hitPoints;
        private Weapon weapon;

        public Orc(int hitPoints)
        {
            _hitPoints = hitPoints;
        }

        public void Shout()
        {
            Console.WriteLine("For the Horde!");
        }

        public void Shout(string what)
        {
            Console.WriteLine($"For the {what}!");
        }

        public void Shout(int year)
        {
            Console.WriteLine($"For the {year}!");
        }
    }

    internal class Weapon
    {
    }
}