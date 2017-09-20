using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateExample
{
    class ExerciseDelegate
    {
        public delegate Comparison<Point> PointComparison(Point p1, Point p2);

        public static void ExerciseDelegateMain()
        {

            /* An array of points:  */
            Point[] points = {
                new Point(1,2),
                new Point(-1,2),
                new Point(-2,2),
                new Point(-4,5),
                new Point(-5,5),
                new Point(5,5),
                new Point(-5,-5)
            };


            /* Sorting the points as desired: */
            Array.Sort(points,
                       delegate (Point p1, Point p2)
                       {
                           if (p1.X + p1.Y < p2.X + p2.Y)
                               return -1;
                           else if (p1.X + p1.Y == p2.X + p2.Y)
                               return 0;
                           else return 1;
                       });








            Array.Sort(points, (p1, p2) =>
            {
                if (p1.X + p1.Y < p2.X + p2.Y)
                    return -1;
                else if (p1.X + p1.Y == p2.X + p2.Y)
                    return 0;
                else return 1;
            });

            Console.WriteLine("Sorted points:");
            foreach (Point p in points) Console.WriteLine(p);
        }
    }


    class Point
    {
        public enum PointRepresentation { Polar, Rectangular }

        private double r, a;

        public Point(double x, double y)
        {
            r = RadiusGivenXy(x, y);
            a = AngleGivenXy(x, y);
        }

        public Point(double par1, double par2, PointRepresentation pr)
        {
            if (pr == PointRepresentation.Polar)
            {
                r = par1; a = par2;
            }
            else
            {
                r = RadiusGivenXy(par1, par2);
                a = AngleGivenXy(par1, par2);
            }
        }

        public double X
        {
            get { return XGivenRadiusAngle(r, a); }
        }

        public double Y
        {
            get { return YGivenRadiusAngle(r, a); }
        }


        public double Radius
        {
            get { return r; }
        }

        public double Angle
        {
            get { return a; }
        }

        public void Move(double dx, double dy)
        {
            double x, y;
            x = XGivenRadiusAngle(r, a); y = YGivenRadiusAngle(r, a);
            r = RadiusGivenXy(x + dx, y + dy);
            a = AngleGivenXy(x + dx, y + dy);
        }

        public void Rotate(double angle)
        {
            a += angle;
        }

        public override string ToString()
        {
            return "(" + XGivenRadiusAngle(r, a) + "," + YGivenRadiusAngle(r, a) + ")";
        }


        private static double RadiusGivenXy(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }

        private static double AngleGivenXy(double x, double y)
        {
            return Math.Atan2(y, x);
        }

        private static double XGivenRadiusAngle(double r, double a)
        {
            return r * Math.Cos(a);
        }

        private static double YGivenRadiusAngle(double r, double a)
        {
            return r * Math.Sin(a);
        }
    }
}
