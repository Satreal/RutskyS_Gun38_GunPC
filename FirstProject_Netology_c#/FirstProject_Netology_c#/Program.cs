using System;
using System.Runtime.CompilerServices;

namespace FirstJob
{
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
            Console.WriteLine($"{person.Name}, какое у тебя оружие?");
            var weapon = new Weapon(Console.ReadLine(),30,70);
            Console.WriteLine($"{person.Name}, Ваш средний урон {weapon.GetDamage()}");
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