using System;
using System.Collections.Generic;

class NBook{
  private List<Book> books = new List<Book>();
  public void Insert(Book l){
   int max = 0;
    foreach(Book obj in books)
      if (obj.id > max) max = obj.id;
    l.id = max + 1;
    books.Add(l);
  }

  public List<Book> List() {
    return books;
  }

  public Book List(int id) {
    for (int i = 0 ; i < books.Count; i++)
      if (books[i].id == id) return books[i];
    return null;
  }

  public void Delete(Book l){
    if (l != null) books.Remove(l);
  }
  public void Update(Book l){
    Book c_atual = List(l.id);
    if (c_atual == null) return;
    c_atual.title = l.title;
    c_atual.gender = l.gender;
  }
}