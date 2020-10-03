using System;
using System.Threading;

namespace Cheat
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread GUIWorkThread = new Thread(new ThreadStart(GUIWork));
            while (true)
            {
                // Attempt to attach to 'Among Us.exe'
                if (AmongUsMemory.Main.Init())
                {
                    Memory.Init();
                    break;
                }
                Console.WriteLine("Could not attach to Among Us.exe, trying again in 5 seconds. This most likely means its not running.");
                Thread.Sleep(5000);
            }
            GUIWorkThread.Start();
            Thread.Sleep(3600000); // Wait for one hour before exiting
        }

        public static void GUIWork() {
            HackGUI hackGui = new HackGUI();
            hackGui.ShowDialog();
        }
    }
}
