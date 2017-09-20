using System;

namespace DelegateExample
{
    class Program
    {
        public delegate double NumericFunction(double d);

        public static void PrintTableOfFunction(NumericFunction f, string fname, double from, double to, double step)
        {
            double d;

            for (d = from; d <= to; d += step)
            {
                Console.WriteLine("{0,10}({1,-4:F3}) = {2}", fname, d, f(d));
            }

            Console.WriteLine();
        }

        public static double Cubic(double d)
        {
            return d * d * d;
        }

        public static void Main()
        {
            //PrintTableOfFunction(Math.Log, "log", 0.1, 5, 0.1);
            //PrintTableOfFunction(Math.Sin, "sin", 0.0, 2 * Math.PI, 0.1);
            //PrintTableOfFunction(Math.Abs, "abs", -1.0, 1.0, 0.1);

            //PrintTableOfFunction(Cubic, "cubic", 1.0, 5.0, 0.5);

            //// Equivalent to previous:
            //PrintTableOfFunction(delegate (double d) { return d * d * d; },
            //                     "cubic", 1.0, 5.0, 0.5);

            //PrintTableOfFunction(d => d * d * d, "cubic", 1.0, 5.0, 0.5);

            //ProgramWithCompose.ProgramWithComposeMain();

            ExerciseDelegate.ExerciseDelegateMain();

            //MultivalueDelegates.MultivalueDelegatesMain();

            Console.ReadLine();
        }
    }
}
