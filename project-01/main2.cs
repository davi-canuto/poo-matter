using System;

class MainClass{
  public static void Main(){
    Categoria C1 = new Categoria(1, "Mouse");
    Categoria C2 = new Categoria(2, "Fonte");

    Console.WriteLine(C1);
    Console.WriteLine(C2);

    Produto p1 = new Produto(1, "Mouse Bluetoth", 10, 150);
    Produto p2 = new Produto(2, "Mouse USB", 15, 60);
    Produto p3 = new Produto(3, "Fonte ATX", 20, 300);
    Produto p4 = new Produto(4, "Mouse Bluetoth", 20, 100);

    Console.WriteLine(p1);
    Console.WriteLine(p2);
    Console.WriteLine(p3);
    Console.WriteLine(p4);

  }
}
class Categoria{
  private int id;
  private string description;

  //construtor
  public Categoria(int id, string description){
    this.id = id;
    this.description = description;
  }
  public override string ToString(){
    return id + " - " + description;
  }
}

class Produto{
  private int id;
  private string description;
  private int qtd;
  private double price;

  public Produto(int id,string description,int qtd,double price){
    this.id = id;
    this.description = description;
    this.qtd = qtd > 0? qtd : 0;
    this.price = price > 0? price : 0;
  }
  public override string ToString(){
    return id + " - " + description + " - estoque: " + qtd + " preço: " + price.ToString("0.00");
  }
}