using System;

class Area{
  public static double AreaTriangulo(double b, double h){
    double area = b*h/2;
    return area;
  }
}


class MainClass{
  public static void Main (string[] args){
    double x = Area.AreaTriangulo(10,20);
    double y = Area.AreaTriangulo(5,8);
    Console.WriteLine($"Áreas = {x} e {y}");
  }
}