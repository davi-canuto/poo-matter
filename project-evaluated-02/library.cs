using System;

class Library {
  private int id;
  private string name;
  private int qtd_books;
  public Library(int id, string name, int qtd_books){
    this.id = id;
    this.name = name;
    this.qtd_books = qtd_books;
  }
  public void SetId(int id){
    this.id = id;
  }
  public void SetName(string name){
    this.name = name;
  }
  public void SetQtd_Books(int qtd_books){
    this.qtd_books = qtd_books;
  }
  public int GetId(){
    return id;
  }
  public string GetName(){
    return name;
  }
  public int GetQtd_Books(){
    return qtd_books;
  }

  public override string ToString(){
    return id + " - " + name + " - Qtd books: " + qtd_books;
  }
}