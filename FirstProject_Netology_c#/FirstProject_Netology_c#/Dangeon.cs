using System;

namespace FirstJob
{
    public struct Dangeon
    {
        public Room[] rooms;

        public Dangeon()
        {
            rooms = new Room[]
            {
                new Room(new Unit("Ork"), new Weapon("Knife")),
                new Room(new Unit("Elf"), new Weapon("Sword")),
                new Room(new Unit("Paladine"), new Weapon("Staff"))
            };
        }


        public void ShowRooms()
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                var room = rooms[i];

                Console.WriteLine($"Unit of room {room.Unit.Name}");
                Console.WriteLine($"Weapon of room  {room.Weapon.Name}");
                Console.WriteLine("—");
            }
        }
    }


    
}
