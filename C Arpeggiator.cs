using System;

namespace cArpeggiator //lol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Appuyez sur une touche pour démarrer.");
            Console.ReadLine();
            Console.Beep(523,300);
            Console.Beep(659,300);
            Console.Beep(783,300);
            Console.Beep(1046,800);
        }
    }
}
