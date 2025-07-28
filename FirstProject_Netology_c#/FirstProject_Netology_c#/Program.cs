using System;
using System.Runtime.CompilerServices;

namespace FirstJob
{
    public class Unit
    {
        public string Name { get; }
        private float Health { get; }
        public int Damage { get; }
        public float Armour { get; }
        public Unit() : this("Unknown Unit") { }
       
        public Unit(string name)
        {
            Name = name;
            Damage = 5;
            Armour = 0.6f;
            Health = 60.0f;
        }
        public float GetRealHealth()
        {
            
            return Health * (1f + Armour);
        }
        public bool SetDamage(float value)
        {
            
            
            bool setDamage = true;
            if (Health - value * Armour <= 0)
            {

                return setDamage;

            }
            else
            {
                return !setDamage;
            }
        }

    }
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("What is your name?");
            var person = new Unit(Console.ReadLine());

            Console.WriteLine($"Hello, {person.Name}");
            Console.WriteLine($"Damage: {person.Damage}");
            Console.WriteLine($"Armour:{person.Armour}");
            Console.WriteLine($"RealHealth:{person.GetRealHealth()}");
            Console.WriteLine("Attention, you've met the enemy!");
            int damage=120;
            Console.WriteLine($"The enemy strikes, damage {damage}");
            Console.WriteLine($"Health:{person.GetRealHealth() - damage} ");//логика не правильная, но т.к. не догадался, как возвращать приватный health, решил так=)
            if(person.SetDamage(damage))
            {
                Console.WriteLine("Sorry, you die!");
            }
            else
            {
                Console.WriteLine($"{person.Name} RUN!");

            }
                












        }
    }
}