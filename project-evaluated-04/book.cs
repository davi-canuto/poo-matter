using System;

class Book {
  private int id;
  private string title;
  private string book_gender;
  private Library library;
  public Book(int id, string title, string book_gender){
    this.id = id;
    this.title = title;
    this.book_gender = book_gender;
  }

  public Book(int id, string title, string book_gender, Library library) : this(id,title,book_gender){
    this.library = library;
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
  public void SetLibrary(Library library){
    this.library = library;
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
  public Library GetLibrary(){
    return library;
  }

  public override string ToString(){
    if (library == null)
      return id + " - " + title + " - " + book_gender;  
    else
      return id + " - " + title + " - " + book_gender + ", Library: " + library.GetName();  
  }
}