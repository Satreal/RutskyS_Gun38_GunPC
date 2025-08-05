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
                new Room(new Unit("Ork"), new Weapon("Knife",5,10)),
                new Room(new Unit("Elf"), new Weapon("Sword",20,40)),
                new Room(new Unit("Paladine"), new Weapon("Staff",15,19))
            };
        }


        public void ShowRooms()
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                var room = rooms[i];

                Console.WriteLine($"Unit of room {room.Unit}");
                Console.WriteLine($"Weapon of room  {room.Weapon}");
                Console.WriteLine("—");
            }
        }
    }


    
}
