using FirstProject_Netology_c.Items.EconomicItems;
using FirstProject_Netology_c.Items.EquipItems;
using FirstProject_Netology_c.Utils;
using System.Text;

namespace FirstProject_Netology_c.Units
{
    public sealed class Player : Unit
    {
        private readonly Dictionary<EquipSlot, EquipItem> _equipment = new();

        public Player(string name, uint health, uint maxHealth, uint baseDamage) : base(name, health, maxHealth, baseDamage)
        {            
        }

        public override uint GetUnitDamage()
        {
            if (_equipment.TryGetValue(EquipSlot.Weapon, out var item) && item is Weapon weapon) 
            {
                return BaseDamage + weapon.Damage;
            }
            return BaseDamage;
        }

        public override void HandleCombatComplete()
        {
            var items = Inventory.Items;
            for (int i = 0; i < items.Count; i++) 
            {
                if (items[i] is EconomicItem economicItem) 
                {
                    UseEconomicItem(economicItem);
                    Inventory.TryRemove(items[i]);
                }
            }
        }

        public override void AddItemToInventory(Item item)
        {
            if (item is EquipItem equipItem && _equipment.TryAdd(equipItem.Slot, equipItem)) 
            {
                Equip(equipItem);
                
            }
            else
            {
                if(item is EquipItem itemOnTheHand)
                {
                    TryChangeEquipItem(itemOnTheHand);
                }
                else
                {
                    base.AddItemToInventory(item);
                }
                    return;
            }
               
            
        }
        private void Equip(EquipItem equipItem)
        {
            _equipment[equipItem.Slot] = equipItem;
            Console.WriteLine($"Надето {equipItem.Name}");
        }
        private void TryChangeEquipItem(EquipItem equipItem)
        {
            Console.WriteLine("Хотите заменить снаряжение? yes or no");
            string message = Console.ReadLine();
            if(message.ToLower()=="yes")
            {
                Equip(equipItem);
                
                 
            }
            else
            {
                //continue game
            }


        }

        private void UseEconomicItem(EconomicItem economicItem)
        {
            if (economicItem is HealthPotion healthPotion) 
            {
                Health += healthPotion.HealthRestore;
            }
             if (economicItem is Grindstone grindstone)
            {
                if (_equipment.TryGetValue(EquipSlot.Weapon, out var item) && item is Weapon weapon)
                {
                    weapon.Repair(weapon.Durability); 
                    Console.WriteLine($"{Name} использовал {grindstone.Name}");
                    
                }
            }
        }

        protected override uint CalculateAppliedDamage(uint damage)
        {
            if (_equipment.TryGetValue(EquipSlot.Armour, out var item) && item is Armour armour) 
            {
                damage -= (uint)(damage * (armour.Defence / 100f));
                armour.ReduceDurability(1);
                if (armour.Durability == 0)
                {
                    Console.WriteLine($"{armour.Name} разрушена!");
                    
                }
            }
            return damage;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(Name);
            builder.AppendLine($"Health {Health}/{MaxHealth}");
            builder.AppendLine("Loot:");
            var items = Inventory.Items;
            for (int i = 0; i < items.Count; i++) 
            {
                builder.AppendLine($"[{items[i].Name}] : {items[i].Amount}");
            }
            return builder.ToString();
        }
    }
}
