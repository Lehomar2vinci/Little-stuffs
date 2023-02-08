using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nombres = { 67, 92, 153, 15 };

            var result = from nombre in nombres
                         where nombre > 30 && nombre < 100
                         select nombre;
            List<int> nombresFiltres = result.ToList();

            foreach (int number in nombresFiltres)
            {
                Console.WriteLine(number);
            }

        }
    }
}