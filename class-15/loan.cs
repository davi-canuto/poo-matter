using System;

class Loan {
  private int id;
  private Book book;
  public Loan(int id){
    this.id = id;
  }
  public Loan(int id, Book book) : this(id){
    this.book = book;
  }
  public void SetId(int id){
    this.id = id;
  }
  public void SetBook(Book book){
    this.book = book;
  }
  public int GetId(){
    return id;
  }
  public Book GetBook(){
    return book;
  }
  public override string ToString(){
    return "Loan code: " + id + " - Book: " + book.GetTitle();
  }
}