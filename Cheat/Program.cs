using System;
using System.Threading;
using System.Threading.Tasks;

namespace Cheat
{
    class Program
    {
        private static HackGUI hackGUI = new HackGUI();

        public static void Main(string[] args)
        {
            while (true)
            {
                // Attempt to attach to 'Among Us.exe'
                if (AmongUsMemory.Main.Init())
                {
                    Memory.Init();
                    break;
                }
                Console.Clear();
                Console.WriteLine("Could not attach to 'Among Us.exe'. This most likely means its not running, or the file is wrongly named.");
                for (int i = 10; i > 0; i--)
                {
                    Console.Write("\r" + new string(' ', Console.WindowWidth - 1) + "\r");
                    Console.Write("Attempting again in {0} seconds...", i);
                    Thread.Sleep(1000);
                }
            }

            Task.Factory.StartNew(() => hackGUI.ShowDialog());
            Thread.Sleep(3600000); // Wait for one hour before exiting
            Exit();
        }

        public static void Exit()
        {
            hackGUI.Close();

            // idk if it does anything, but i think it cleans something up
            bool procMemExit = AmongUsMemory.Main.ProcessMemory.Close();
            Environment.Exit(procMemExit ? 0 : -1);
        }
    }
}
