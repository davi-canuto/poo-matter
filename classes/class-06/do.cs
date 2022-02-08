using System;

class MainClass{
  public static void Main(string[] args){
    int n = 0;
    double s = 0;
    double x;
    do {
      x = double.Parse(Console.ReadLine());
      s += x;
      n++;
    } while (x != 0);
    double m = s / (n-1);
    Console.WriteLine($"Media = {m}");
  }
}