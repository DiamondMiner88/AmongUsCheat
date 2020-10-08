using System;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Cheat
{
    class Program
    {
        #region WINAPI_IMPORT
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
        #endregion

        public static HackGUI hackGUI = new HackGUI();

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
            DisplayConsole(false);
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

        public static void DisplayConsole(bool show)
        {
            IntPtr handle = GetConsoleWindow();
            ShowWindow(handle, show ? SW_SHOW : SW_HIDE);
        }
    }
}
