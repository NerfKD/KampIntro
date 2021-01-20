using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Kerim", "Emre", "Hacı", "Sezgin" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            List<string> listIsimler = new List<string>() { "Kerim", "Emre", "Hacı", "Sezgin" };

            Console.WriteLine(listIsimler[0]);
            Console.WriteLine(listIsimler[1]);
            Console.WriteLine(listIsimler[2]);
            Console.WriteLine(listIsimler[3]);

            listIsimler.Add("Serdar");
            Console.WriteLine(listIsimler[4]);

        }
    }
}
