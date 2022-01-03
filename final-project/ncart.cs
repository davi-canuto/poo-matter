
using System;

class NCart { 
  private Cart[] carts = new Cart[10];
  private int nc;

  public void Insert(Cart l){
    if (nc == carts.Length) {
      Array.Resize(ref carts, 2 * carts.Length);
    }
    carts[nc] = l;
    nc++;
  }

  public Cart[] List() {
    Cart[] c = new Cart[nc];
    Array.Copy(carts, c, nc);
    return c;
  }

  public Cart List(int id) {
    for (int i = 0 ; i < nc; i++)
      if (carts[i].GetId() == id) return carts[i];
    return null;                                  
  }   

  public void Update(Cart l){
    Cart c_atual = List(l.GetId());
    if (c_atual == null) return;
    c_atual.SetCapacity(l.GetCapacity());
  }

  public void Delete(Cart l){
    int n = Indice(l);
    if (n == -1) return;
    for (int i = n; i < nc-1; i++)
      carts[i] = carts[i + 1];
    nc--;
  }

  private int Indice(Cart c){
    for (int i = 0; i < nc; i++)
      if(carts[i] == c) return i;
    return -1;
  }
} 