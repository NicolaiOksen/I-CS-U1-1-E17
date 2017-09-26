// A very simple point with public data representation.
// NOT RECOMMENDED because of public data representation.

using System;

public class Point {
  public double x, y;  

  public Point(double x, double y){
   this.x = x; this.y = y;
  }

  public void Move(double dx, double dy){
    x += dx; y += dy;
  }

  public override string ToString(){
    return  "(" + x + "," + y + ")";
  }
}