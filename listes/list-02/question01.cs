using System;

class MainClass{
  public static void Main(){
    double h;
    Circle x = new Circle();
    x.SetRaio(6);
    h = x.GetRaio();
    Console.WriteLine(h);
    Console.WriteLine(x.circunferencia(h));
    Console.WriteLine(x.area(h));
  }
}

class Circle {
  private double raio;

  public void SetRaio(double r){
    if (r > 0) raio = r;
  }
  public double GetRaio(){
    return raio;
  }

  public double area(double raio){
    return 3.14*(raio*raio);
  }
  public double circunferencia(double raio){
    return 2*3.14*raio;
  }
}