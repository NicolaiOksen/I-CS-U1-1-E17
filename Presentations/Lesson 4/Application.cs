// A client of Point that instantiates three points and calculates
// the circumference of the implied triangle.

using System;

public class Application{

  public static Point PromptPoint(string prompt){
    double x, y;
    Console.WriteLine(prompt);
    x = double.Parse(Console.ReadLine());
    y = double.Parse(Console.ReadLine());
    return new Point(x,y);
  }

  public static void Main(){
    Point p1, p2, p3;
    double p1p2Dist, p2p3Dist,  p3p1Dist, circumference;

    p1 = PromptPoint("Enter first point");
    p2 = PromptPoint("Enter second point");
    p3 = PromptPoint("Enter third point");

    p1p2Dist = Math.Sqrt((p1.x - p2.x) * (p1.x - p2.x) +    
                         (p1.y - p2.y) * (p1.y - p2.y));    
    p2p3Dist = Math.Sqrt((p2.x - p3.x) * (p2.x - p3.x) +    
                         (p2.y - p3.y) * (p2.y - p3.y));    
    p3p1Dist = Math.Sqrt((p3.x - p1.x) * (p3.x - p1.x) + 
                         (p3.y - p1.y) * (p3.y - p1.y));

    circumference = p1p2Dist + p2p3Dist + p3p1Dist;

    Console.WriteLine("Circumference: {0} {1} {2}: {3}", 
                       p1, p2, p3, circumference);

    Console.ReadLine();
  }

}