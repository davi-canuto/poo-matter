using System;

class MainClass{
  public static void Main(){
    Fleight x = new Fleight(324,400);
    Console.WriteLine(x);
    double peso = x.GetWeight();
    double distancia = x.GetDistance();
    Console.WriteLine($"Calculo do frete: {x.CalcFleight(distancia,peso)}");
  }
}

class Fleight{
  private double distance, weight;

  public Fleight(double distance, double weight){
    this.distance = distance > 0 ? distance : 0; // km
    this.weight = weight > 0 ? weight : 0;       // kg
  }

  public void SetDistance(double distance){
    this.distance = distance > 0 ? distance : 0;
  }
  public void SetWeight(double weight){
    this.weight = weight > 0 ? weight : 0;
  }

  public double GetDistance(){
    return distance;
  }
  public double GetWeight(){
    return weight;
  }

  public double CalcFleight(double d, double w){
    return 0.01*w*d;
  }
  public override string ToString(){
    return "Distancia: " + distance + " - " + "Peso: " + weight;
  }