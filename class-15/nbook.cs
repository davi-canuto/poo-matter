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

  public void Delete(Book l){
    int n = Indice(l);
    if (n == -1) return;
    for (int i = n; i < nc-1; i++)
      books[i] = books[i + 1];
    nc--;
  }
  
  private int Indice(Book c){
    for (int i = 0; i < nc; i++)
      if(books[i] == c) return i;
    return -1;
  }
}