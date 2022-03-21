using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

class NBook{
  public NBook(){ }
  static NBook obj = new NBook();
  public static NBook Singleton { get => obj; }

  private Book[] books = new Book[20];
  private int nc;

  public void Open(){
    Archive<Book[]> f = new Archive<Book[]>();
    books = f.Open("./books.xml");
    nc = books.Length;
  }
  public void ToSave(){
    Archive<Book[]> f = new Archive<Book[]>();
    f.ToSave("./books.xml", List());
  }
  public Book[] List() {
    return 
      books.Take(nc).OrderBy(obj => obj.GetTitle()).ToArray();
  }
  public Book List(int id) {
     return books.FirstOrDefault(obj => obj.GetId() == id);
  }

  public void Insert(Book p) {
    if (nc == books.Length) {
      Array.Resize(ref books, 2 * books.Length);
    }
    books[nc] = p;
    nc++;
  }

  public void Update(Book p) {
    Book p_atual = List(p.GetId());
    if (p_atual == null) return;
    p_atual.SetTitle(p.GetTitle());
    p_atual.SetGender(p.GetGender());
  }

  private int Indice(Book p) {
    for(int i = 0; i < nc; i++)
      if (books[i] == p) return i;
    return -1;
  }

  public void Delete(Book p) {
    int n = Indice(p);
    if (n == -1) return;
    for (int i = n; i < nc - 1; i++)
      books[i] = books[i + 1];
    nc--;
  }
}