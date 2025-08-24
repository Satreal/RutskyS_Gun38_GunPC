using FirstProject_Netology_c.Utils;

namespace FirstProject_Netology_c.Items.EquipItems
{
    public class Weapon : EquipItem
    {
        public Weapon(uint damage, uint durability, string name) : base(durability, name) => Damage = damage;

        public uint Damage { get; }

        public override EquipSlot Slot => EquipSlot.Weapon;
    }

    public class RangeWeapon : Weapon
    {
        public override EquipSlot Slot=>EquipSlot.RangeWeapon;
        public RangeWeapon(uint damage, uint durability, string name) : base(damage, durability, name)
        {
        }
    }
    public class MeleeWeapon : Weapon
    {
       
        public MeleeWeapon(uint damage, uint durability, string name) : base(damage,durability, name)
        {

        }

    }
}
