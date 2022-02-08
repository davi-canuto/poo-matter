using System;

class MainClass{
  public static void Main(){
    Rectangle x = new Rectangle(10, 5);
    double b = x.GetBase();
    double h = x.GetHeight();
    Console.WriteLine(x);
    Console.WriteLine($"Area = {x.CalcArea(b,h)}");
    Console.WriteLine($"Diagonal = {x.CalcDiagonal(b,h)}");
  }
}

class Rectangle{
  private double b,h;

  public Rectangle(double b, double h){
    this.b = b > 0 ? b : 0;
    this.h = h > 0 ? h : 0;
  }

  public void SetBase(double b){
    this.b = b > 0 ? b : 0;
  }
  public void SetHeight(double h){
    this.h = h > 0 ? h : 0;
  }
  
  public double GetBase(){
    return b;
  }
  public double GetHeight(){
    return h;
  }

  public double CalcArea(double b, double h){
    return b*h;
  }
  public double CalcDiagonal(double b, double h){
    return (b*h)/2;
  }
  public override string ToString(){
    return "Base: " + b + " - " + "Altura: " + h;
  }
}