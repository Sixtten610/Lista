using System;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Player1 p1 = new Player1();

            p1.ammunition = 31;
            p1.health = 100;
            
            string p1name = p1.name;

            System.Console.WriteLine("Ammo: " + p1.ammunition + " | " + "Health: " + p1.health + " | " + "Name: " + p1.name);

            Console.ReadLine();

            Vehicle vehicle = new Vehicle();

            vehicle.fule = 420;
            vehicle.speed = 0;
            vehicle.rarity = 1337;
            vehicle.health = 69;
            vehicle.seats = 6.9f; 

        }
    }
}
