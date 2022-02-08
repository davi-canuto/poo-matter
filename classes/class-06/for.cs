using System;

class MainClass{
  public static void Main(string[] args){
    int f = 1;
    Console.WriteLine("Digite um número");
    int n = int.Parse(Console.ReadLine());
    for (int i = 1; i <= n; i++)  // ( inicialização ; teste ; atualização)
      f = f*i;                    // comandos
    Console.WriteLine($"Fatorial = {f}");  // resultado
  }
}