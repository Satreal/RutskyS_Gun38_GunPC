using FirstProject_Netology_c.Items.EconomicItems;
using FirstProject_Netology_c.Items.EquipItems;
using FirstProject_Netology_c.Units;
using System.Xml.Linq;

namespace FirstProject_Netology_c.Utils
{
    public enum DifficultyLevel
    {
        Easy=1,
        Normal,
        Hard
    }
    public abstract class UnitFactory
    {
        public abstract Unit Create(string name = "");

    }
    public class PlayerFactory : UnitFactory
    {
        public override Unit Create(string name="")
        {
            var player = new Player(name, 30, 30, 6);
            player.AddItemToInventory(new MeleeWeapon(10, 15, "Sword"));
            player.AddItemToInventory(new RangeWeapon(10, 15, "Bow"));
            player.AddItemToInventory(new BodyArmour(10, 15, "StandartArmour"));
            player.AddItemToInventory(new HeadArmour(10, 15, "Helmet"));

            player.AddItemToInventory(new HealthPotion("Potion"));
            return player;
        }
    }
    public class EasyGoblinFactory:UnitFactory
    {
        public override Unit Create(string name = "")
        {
            return new Goblin(GameConstants.Goblin, 18, 18, 2);
        }
    }
    public class NormalGoblinFactory : UnitFactory
    {
        public override Unit Create(string name = "")
        {
            return new Goblin(GameConstants.Goblin, 24, 20, 4);
        }
    }
    public class HardGoblinFactory : UnitFactory
    {
        public override Unit Create(string name = "")
        {
            return new Goblin(GameConstants.Goblin, 27, 23, 6);
        }
    }


    public class UnitFactoryDemo
    {
        public static Unit CreatePlayer(string name)
        {
            var player = new Player(name, 30, 30, 6);
            player.AddItemToInventory(new MeleeWeapon(10, 15, "Sword"));
            player.AddItemToInventory(new RangeWeapon(10, 15, "Bow"));
            player.AddItemToInventory(new BodyArmour(10, 15, "StandartArmour"));
            player.AddItemToInventory(new HeadArmour(10, 15, "Helmet"));

            player.AddItemToInventory(new HealthPotion("Potion"));
            return player;
        }

        public static Unit CreateGoblinEnemy() => new Goblin(GameConstants.Goblin, 18, 18, 2);
    }
}
