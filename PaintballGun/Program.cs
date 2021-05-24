using System;

namespace PaintballGun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello in Paintball test app! \n");

            PGun simpleGun = new PGun();

            while (true)
            {
                Console.WriteLine($"{simpleGun.GetBalls()} balls, {simpleGun.GetBallsLoaded()} loaded");
                if (simpleGun.IsEmpty())
                {
                    Console.WriteLine("Space to shoot , r to reload, + to add ammo, q ti quit ");
                }
                char key = Console.ReadKey(true).KeyChar;
                if (key == ' ') Console.WriteLine($"Shooting returned {simpleGun.Shoot()}");
                else if (key == 'r') simpleGun.Reload();
                else if (key == '+') simpleGun.SetBalls(simpleGun.GetBalls() + PGun.MAGAZINE_SIZE);
                else if (key == 'q') return;
            }
        }
    }
}
