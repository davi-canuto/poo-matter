using System;

class MainClass {
  public static void Main(string[] args){
    int x = 10, y = 20;
    Metodo1(x,y);
    Console.WriteLine($"x = {x}  y ={y}");
  }

  public static void Metodo1 (int a, int b){
    Console.WriteLine($"A = {a} B = {b}");
    a = 30;
    b = 40;
    Console.WriteLine($"A = {a} B = {b}");
  }
}