using System;

class Library {
  private int id;
  private string name;
  private Book[] books = new Book[10];
  private int np;
  public Library(int id, string name){
    this.id = id;
    this.name = name;
  }
  public void SetId(int id){
    this.id = id;
  }
  public void SetName(string name){
    this.name = name;
  }
  public int GetId(){
    return id;
  }
  public string GetName(){
    return name;
  }
  public Book[] BookList() {
    Book[] v = new Book[np];
    Array.Copy(books, v, np);
    return v;
  }

  public void BookInsert(Book b) {
    if (np == books.Length) {
      Array.Resize(ref books, 2 * books.Length);
    }
    books[np] = b;
    np++;  
  }
  public override string ToString(){
    return id + " - " + name + " - Qtd books: " + np;
  }
}