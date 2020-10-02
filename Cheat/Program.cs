using System;

namespace Cheat
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Attempt to attach to 'Among Us.exe'
                if (HamsterCheese.AmongUsMemory.Cheese.Init())
                {
                    Cheat.Memory.Init();
                    break;
                }
                Console.WriteLine("Could not attach to Among Us.exe, trying again in 5 seconds. This most likely means its not running.");
                System.Threading.Thread.Sleep(5000);
            }
            System.Threading.Thread.Sleep(3600000); // Wait for one hour before exiting
        }
    }
}
