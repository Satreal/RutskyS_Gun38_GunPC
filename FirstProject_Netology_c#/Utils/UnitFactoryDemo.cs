using FirstProject_Netology_c.Items.EconomicItems;
using FirstProject_Netology_c.Items.EquipItems;
using FirstProject_Netology_c.Units;

namespace FirstProject_Netology_c.Utils
{
    public class UnitFactoryDemo
    {
        public static Unit CreatePlayer(string name)
        {
            var player = new Player(name, 30, 30, 6);
            player.AddItemToInventory(new Weapon(10, 15, "Sword"));
            player.AddItemToInventory(new Weapon(10, 15, "RangeWeapon"));
            player.AddItemToInventory(new Armour(10, 15, "StandartArmour"));
            player.AddItemToInventory(new Armour(10, 15, "Helmet"));

            player.AddItemToInventory(new HealthPotion("Potion"));
            return player;
        }

        public static Unit CreateGoblinEnemy() => new Goblin(GameConstants.Goblin, 18, 18, 2);
    }
}
