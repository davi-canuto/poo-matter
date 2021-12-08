using System;

class MainClass { 
  public static void Main(){
    Circle x1 = new Circle(6);
    Console.WriteLine(x1);
  }
}

class Circle {
  private int raio;
  public Circle(int raio) {
    this.raio = raio;
  }
  public double area(int raio){
    return 3.14*(raio*2);
  }
  public double circunferencia(int raio){
    return 2*3.14*raio;
  }
  public override string ToString(){
    return raio.ToString() + " - " + circunferencia(raio) + " - " + area(raio);
  }
}