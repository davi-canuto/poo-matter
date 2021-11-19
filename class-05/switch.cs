using System;

class MainClass {
  public static void Main (string[] args){
    int x;
    Console.WriteLine("Digite o número do mês");
    x = int.Parse(Console.ReadLine());
    
    switch(x){
      case 1: Console.WriteLine("Janeiro");break;
      case 2: Console.WriteLine("Fevereiro");break;
      case 3: Console.WriteLine("Março");break;
      default: Console.WriteLine("Mês inválido");break;
    }
  }
}