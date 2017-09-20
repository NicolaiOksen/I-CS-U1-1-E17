using System;

namespace EventsExample
{
    class Program
    {
        public static void Main()
        {
            Die d1 = new Die();

            d1.twoSixesInARow +=
             delegate (string mes) {
                 Console.WriteLine("Yeaaaaahhh!!! " + mes);
             };

            for (int i = 1; i < 100; i++)
            {
                d1.Toss();
                Console.WriteLine("{0}: {1}", i, d1.NumberOfEyes);
            }

            Console.ReadLine();
        }
    }
}
