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
        
        public float Durability { get; }
        public Interval Damage { get;}
       
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
