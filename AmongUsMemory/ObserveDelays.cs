namespace AmongUsMemory
{
    class ObserveDelays
    {
        public static readonly int ObservePlayerDeath = 100;

        // Increase this if your computer can't handle the load very well. On a Ryzen 3900x with 500ms delay it takes about 11-16% CPU usage.
        // Remove the scanning later anyways and replace with a keybind system.
        public static int ObserveShipStatus = 500;
    }
}
