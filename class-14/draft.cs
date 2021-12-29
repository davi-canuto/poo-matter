using System;

class MainClass {
  public static void Main (string[] args) {
    Triangulo x = new Triangulo(10, 20);
    x.SetBase(10);
    x.SetAltura(20);
    x.Base2 = 100;
    x.Altura2 = 200;
    Console.WriteLine(x.Area);
  }
}  

class Triangulo {
  private double b, h;
  public Triangulo() { }
  public Triangulo(double b, double h) {
    if (b > 0) this.b = b;
    if (h > 0) this.h = h;
  }
  public double Base {
    get { return b; }
    set { if (value > 0) b = value; }
  }
  public double Altura {
    get { return h; }
    set { if (value > 0) h = value; }
  }
  public double Base2 {
    get => b; 
    set => b = value > 0 ? value : 0; 
  }
  public double Altura2 {
    get => h; 
    set => h = value > 0 ? value : 0; 
  }
  public void SetBase(double v) {
    if (v > 0) b = v;
  }
  public double GetBase() {
    return b;
  }
  public void SetAltura(double v) {
    if (v > 0) h = v;
  }
  public double GetAltura() {
    return h;
  }
  public double CalcArea() {
    double area = b * h / 2;
    return area;
  }
  public double Area {
    get { return b * h / 2; }
  }
  public override string ToString() {
    return $"Base = {b}, Altura = {h}";
  }
}
