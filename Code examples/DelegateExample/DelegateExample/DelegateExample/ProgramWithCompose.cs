using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateExample
{
    class ProgramWithCompose
    {
        public delegate double NumericFunction(double d);

        public static NumericFunction Compose (NumericFunction f, NumericFunction g)
        {
            return delegate (double d) { return f(g(d)); };
        }

        public static void PrintTableOfFunction (NumericFunction f, string fname, double from, double to, double step)
        {
            double d;

            for (d = from; d <= to; d += step)
            {
                Console.WriteLine("{0,35}({1,-4:F3}) = {2}", fname, d, f(d));
            }

            Console.WriteLine();
        }

        public static double Square(double d)
        {
            return d * d;
        }

        public static double Cubic(double d)
        {
            return d * d * d;
        }

        public static double Minus3(double d)
        {
            return d - 3;
        }

        public static void ProgramWithComposeMain()
        {
            PrintTableOfFunction(Compose(Cubic, Minus3),
                                 "Cubic of Minus3", 0.0, 5.0, 1.0);

            PrintTableOfFunction(
              Compose(Square, delegate (double d) {
                  return d > 2 ? -d : 0;
              }),
              "Square of if d>2 then -d else 0", 0.0, 5.0, 1.0);
        }
    }
}
