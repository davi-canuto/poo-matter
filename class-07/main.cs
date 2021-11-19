using System;
// METODOS NA MESMA CLASSE
class MainClass{

  public static double AreaTriangulo(double b, double h){
    double area;
    area = b * h / 2;
    return area;
  }

  public static void Main (string[] args){
    double x,y;
    x = AreaTriangulo(10,20);
    y = AreaTriangulo(5,8);
    Console.WriteLine($"Áreas = {x} e {y}");
  }
}