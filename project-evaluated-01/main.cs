using System;

class MainClass{
   public static void Main(){
     Book b1 = new Book(1,"Harry Potter", "Romance");
     Book b2 = new Book(2,"Senhor dos aneis", "Ficção");
     Console.WriteLine(b1);
     Console.WriteLine(b2);

     Library l1 = new Library(1,"Biblioteca 1", 2);
     Console.WriteLine(l1);
   }
}

class Book {
  private int id;
  private string title;
  private string book_gender;
  public Book(int id, string title, string book_gender){
    this.id = id;
    this.title = title;
    this.book_gender = book_gender;
  }
  public void SetId(int id){
    this.id = id;
  }
  public void SetTitle(string title){
    this.title = title;
  }
  public void SetBook_Gender(string book_gender){
    this.book_gender = book_gender;
  }
  public int GetId(){
    return id;
  }
  public string GetTitle(){
    return title;
  }
  public string GetBook_Gender(){
    return book_gender;
  }

  public override string ToString(){
    return id + " - " + title + " - " + book_gender;  
  }
}

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