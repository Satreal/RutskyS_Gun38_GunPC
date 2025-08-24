using FirstProject_Netology_c.Items.EconomicItems;
using FirstProject_Netology_c.Units;

namespace FirstProject_Netology_c.Dungeon
{
    public sealed class DungeonRoom
    {      
        public readonly string Name;
        public readonly Unit Enemy;
        public readonly Item Loot;
        public readonly Dictionary<Direction, DungeonRoom> Rooms = new();
        public bool IsFinal => Rooms.Count == 0;

        public DungeonRoom(string name) => Name = name;

        public DungeonRoom(string name, Unit enemy)
        {
            Name = name;
            Enemy = enemy;
        }

        public DungeonRoom(string name, Item item)
        {
            Name = name;
            Loot = item;
        }

        public bool TrySetDirection(Direction direction, DungeonRoom room) 
        {
            if (Rooms.ContainsKey(direction))
            {
                Console.WriteLine($"Room {Name} already has room for {direction.ToString()}");
                return false;
            }
            Rooms.Add(direction, room);
            return true;
        }
    }
}
