using System;
using System.Collections.Generic;


class NBook{
  public NBook() { }
  static NBook obj = new NBook();
  public static NBook Singleton { get => obj; }
  private List<Book> books = new List<Book>();
  public void Open() {
    Archive<List<Book>> f = new Archive<List<Book>>();
    books = f.Open("./books.xml");
  }
  public void ToSave() {
    Archive<List<Book>> f = new Archive<List<Book>>();
    f.ToSave("./books.xml", List());
  }
  public List<Book> List() {
    books.Sort();
    return books;
  }

  public Book List(int id) {
    for (int i = 0; i < books.Count; i++)
      if (books[i].id == id) return books[i];
    return null;
  }

  public void Insert(Book c) {
    int max = 0;
    foreach(Book obj in books)
      if (obj.id > max) max = obj.id;
    c.id = max + 1;
    books.Add(c);
  }

  public void Update(Book c) {
    Book c_atual = List(c.id);
    if (c_atual == null) return;
    c_atual.title = c.title;
    c_atual.gender = c.gender;
  }

  public void Delete(Book c) {
    if (c != null) books.Remove(c);
  }
}