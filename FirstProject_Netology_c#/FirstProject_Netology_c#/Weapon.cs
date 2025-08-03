using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstJob
{
    public class Weapon
    {
              
        public string Name { get; }
        public int minDamage { get; private set ; } 
        public int maxDamage { get; private set; }
        public float Durability { get; }
        public void SetDamageParams(int minDamage, int maxDamage)
        {
            if(minDamage>maxDamage)
            {
                int reverse = maxDamage;
                maxDamage = minDamage;
                minDamage = reverse;
                Console.WriteLine($"{Name}, некорректные входные данные");

            }
            if(minDamage<1)
            {
                minDamage = 1;
                Console.WriteLine($" Установлено форсированное минимальное значение урона = 1 для оружия {Name}");
            }
            if(maxDamage<=1)
            {
                maxDamage = 10;
                
            }

        }

        public Weapon(string name)
        {  
            Name = name;
        }
        public Weapon(string name, int min,int max): this(name)
        {
            minDamage = min;
            maxDamage = max;
            Durability = 1f;
        }
    }
}
