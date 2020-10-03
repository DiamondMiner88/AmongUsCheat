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
                Console.WriteLine("Could not attach to Among Us.exe, trying again in 5 seconds. This most likely means its not running.");
                Thread.Sleep(5000);
            }

            Task.Factory.StartNew(() => hackGUI.ShowDialog());

            Thread.Sleep(3600000); // Wait for one hour before exiting
            Exit();
        }

        public static void Exit()
        {
            hackGUI.Close();
            // Weird 'protected memory' error when the among us client is already closed
            //bool procMemExit = AmongUsMemory.Main.ProcessMemory.Close();
            //Environment.Exit(procMemExit ? 0 : -1);
            Environment.Exit(0);
        }
    }
}
