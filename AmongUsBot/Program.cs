using System;

namespace AmongUsBot
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Attempt to attach to Among Us.exe
                if (HamsterCheese.AmongUsMemory.Cheese.Init())
                {
                    AmongUsBot.Memory.Init();
                    break;
                }

                Console.Clear();
                Console.WriteLine("Could not attach to Among Us.exe, trying again in 10 seconds. This most likely means its not running.");
                System.Threading.Thread.Sleep(10000);
            }

            // _ = new AmongUsBot.Bot().InitBot(args);

            System.Threading.Thread.Sleep(3600000); // Wait for one hour before exiting
        }
    }
}
