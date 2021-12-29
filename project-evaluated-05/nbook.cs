using System;

class NBook{
  private Book[] books = new Book[10];
  private int nc;

  public void Insert(Book l){
    if (nc == books.Length) {
      Array.Resize(ref books, 2 * books.Length);
    }
    books[nc] = l;
    nc++;
  }

  public Book[] List() {
    Book[] c = new Book[nc];
    Array.Copy(books, c, nc);
    return c;
  }
  
  public Book List(int id) {
    for (int i = 0 ; i < nc; i++)
      if (books[i].GetId() == id) return books[i];
    return null;                                  
  }
}