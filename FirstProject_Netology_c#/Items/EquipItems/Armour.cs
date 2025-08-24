using FirstProject_Netology_c.Utils;

namespace FirstProject_Netology_c.Items.EquipItems
{
    public class Armour : EquipItem
    {
        public Armour(uint defence, uint durability, string name) : base(durability, name) => Defence = defence;

        public uint Defence { get; }

        public override EquipSlot Slot => EquipSlot.Armour;

    }
    public class BodyArmour : Armour
    {
        public BodyArmour(uint defence, uint durability, string name) : base(defence, durability, name)
        {
        }
    }
    public class HeadArmour : Armour
    {
        public override EquipSlot Slot =>EquipSlot.HeadArmour;
        public HeadArmour(uint defence, uint durability, string name) : base(defence, durability, name)
        {
        }
    }
}
