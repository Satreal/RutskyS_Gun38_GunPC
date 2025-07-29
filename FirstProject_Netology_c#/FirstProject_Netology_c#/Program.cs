using System;
using System.Runtime.CompilerServices;

namespace FirstJob
{
    public class Unit
    {
        public string Name { get; }
        private float _health;
        public int Damage { get; }  
        public float Armour { get; }
        public Unit() : this("Unknown Unit") { }
        public float Health => _health;
       
        public Unit(string name)
        {
            Name = name;
            Damage = 5;
            Armour = 0.6f;
            _health = 60.0f;
        }
        public float GetRealHealth()
        {
            
            return Health * (1f + Armour);
        }
        public bool SetDamage(float value)
        {
                      
            
            _health -= value * Armour;
            return Health <= 0f;
        }

    }
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("What is your name?");
            var person = new Unit(Console.ReadLine());

            Console.WriteLine($"Hello, {person.Name}");
            Console.WriteLine($"Start health: {person.Health}");
            Console.WriteLine($"Damage: {person.Damage}");
            Console.WriteLine($"Armour:{person.Armour}");
            Console.WriteLine($"RealHealth:{person.GetRealHealth()}");
            Console.WriteLine("Attention, you've met the enemy!");
            int damage=60;
            Console.WriteLine($"The enemy strikes, damage {damage}");
            //bool die =person.SetDamage(damage);
            
            if(person.SetDamage(damage))
            {
                Console.WriteLine($"RealHealth:{person.GetRealHealth()} ");
                Console.WriteLine("Sorry, you die!");
            }
            else
            {
                Console.WriteLine($"RealHealth:{person.GetRealHealth()} ");
                Console.WriteLine($"{person.Name} RUN!");

            }
            
            
            damage = 55;
            Console.WriteLine($"The enemy strikes, damage {damage}");

            if (person.SetDamage(damage))
                {
                    Console.WriteLine($"RealHealth:{person.GetRealHealth()} ");
                    Console.WriteLine("Sorry, you die!");
                }
                else
                {
                    Console.WriteLine($"RealHealth:{person.GetRealHealth()} ");
                    Console.WriteLine($"{person.Name} RUN!");

                }














            }    
    }
}