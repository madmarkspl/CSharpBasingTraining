using System;

namespace Units
{
    public abstract class Orc
    {
        protected int age;

        private int _hitPoints;
        private Weapon weapon;

        public Orc(int hitPoints)
        {
            _hitPoints = hitPoints;
        }

        public void GetHurt(int damage)
        {
            _hitPoints -= damage;
            Console.WriteLine(_hitPoints);
        }

        public void Shout()
        {
            Console.WriteLine("For the Horde!");
        }

        public abstract void DieCry();

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