using System;

class MainClass {
  public static void Main(string[] args){
    int s = 0;
    int n = 1;
    while (n < 20){
      Console.WriteLine(n);
      s += n;
      n += 2;
    }
    Console.WriteLine($"Soma = {s}");
  }
}