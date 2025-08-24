using FirstProject_Netology_c.Utils;

namespace FirstProject_Netology_c.Items.EquipItems
{
    public sealed class Weapon : EquipItem
    {
        public Weapon(uint damage, uint durability, string name) : base(durability, name) => Damage = damage;

        public uint Damage { get; }

        public override EquipSlot Slot => EquipSlot.Weapon;
    }
}
