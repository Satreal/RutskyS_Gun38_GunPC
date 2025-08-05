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
        //public int minDamage { get; private set ; } 
        //public int maxDamage { get; private set; }
        public float Durability { get; }
        public Interval Damage { get;}
        //public int GetDamage()
        //{
        //    return (minDamage + maxDamage)/2;
        //}
        //public void SetDamageParams(int min, int max)
        //{
        //    if(min>max)
        //    {
        //        (min,max)=(max,min);
        //        Console.WriteLine($"{Name}, некорректные входные данные");

        //    }
        //    if(min<1)
        //    {
        //        min = 1;
        //        Console.WriteLine($" Установлено форсированное минимальное значение урона = 1 для оружия {Name}");
        //    }
        //    else
        //    {
        //        minDamage = min;
        //    }

        //    if (max <= 1)
        //    {
        //        max = 10;

        //    }
        //    else
        //    {
        //        maxDamage = max;
        //    }

        //}

        public Weapon(string name)
        {  
            Name = name;
            Damage = new Interval(0, 10);
        }
        public Weapon(string name, int minDamage,int maxDamage): this(name)
        {
           Damage = new Interval(minDamage, maxDamage); 
            Durability = 1f;
        }
    }
}
