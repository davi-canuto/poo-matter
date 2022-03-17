using System;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Linq;

class NBook{
  private Book[] books = new Book[10];
  private int np;
  public NBook(){ }

  public void Open(){
    Archive<Book[]> f = new Archive<Book[]>();
    books = f.Open("./books.xml");
    np = books.Length;
  }
  public void ToSave(){
    Archive<Book[]> f = new Archive<Book[]>();
    f.ToSave("./books.xml", List());
  }
  public Book[] List() {
    Book[] p = new Book[np];
    Array.Copy(books, p, np);
    return p;
  }
  public Book List(int id) {
    for (int i = 0; i < np; i++)
      if (books[i].GetId() == id) return books[i];
    return null;
  }

  public void Insert(Book p) {
    if (np == books.Length) {
      Array.Resize(ref books, 2 * books.Length);
    }
    books[np] = p;
    np++;
  }

  public void Update(Book p) {
    Book p_atual = List(p.GetId());
    if (p_atual == null) return;
    p_atual.SetTitle(p.GetTitle());
    p_atual.SetGender(p.GetGender());
  }

  private int Indice(Book p) {
    for(int i = 0; i < np; i++)
      if (books[i] == p) return i;
    return -1;
  }

  public void Delete(Book p) {
    int n = Indice(p);
    if (n == -1) return;
    for (int i = n; i < np - 1; i++)
      books[i] = books[i + 1];
    np--;
  }
}