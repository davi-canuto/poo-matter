using System;

//estruturas condicionais.

class MainClass {
 public static void Main (string[] args) {
  Console.WriteLine("Digite um valor inteiro");
  int x = int.Parse(Console.ReadLine());
  if (x%2 == 0){
    Console.WriteLine("Par");
  } else {
    Console.WriteLine("Impar");
  }
 }
}