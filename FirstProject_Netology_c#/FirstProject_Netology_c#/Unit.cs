using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FirstJob
{
    public class Unit
    {
        private float _health;
        public string Name { get; }

       // public int Damage { get; }

        public float Armour { get; }

        public float Health => _health;
        public Interval Damage { get;}
        public Unit() : this("Unknown Unit") { } 
        
        public Unit(string name)
        {
            Name = name;
            Damage = new Interval(0,40);
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
}
