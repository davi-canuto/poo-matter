using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class NCart {

  public NCart(){ }
  static NCart obj = new NCart();
  public static NCart Singleton { get => obj; }

  private Cart[] carts = new Cart[10];
  private Exemplary[] exemplarys = new Cart[10];
  private int nc;
  private int np;

  public void Open(){
    Archive<Cart[]> f = new Archive<Cart[]>();
    carts = f.Open("./carts.xml");
    nc = carts.Length;
  }
  public void ToSave(){
    Archive<Cart[]> f = new Archive<Cart[]>();
    f.ToSave("./carts.xml", List());
  }
  public Cart[] List() {
    Cart[] p = new Cart[nc];
    Array.Copy(carts, p, nc);
    return p;
  }
  public Cart List(int id) {
    for (int i = 0; i < nc; i++)
      if (carts[i].GetId() == id) return carts[i];
    return null;
  }

  public void Insert(Cart p) {
    if (nc == carts.Length) {
      Array.Resize(ref carts, 2 * carts.Length);
    }
    carts[nc] = p;
    nc++;
  }

  public void Update(Cart p) {
    Cart p_atual = List(p.GetId());
    if (p_atual == null) return;
    p_atual.SetCapacity(p.GetCapacity());
  }

  private int Indice(Cart p) {
    for(int i = 0; i < nc; i++)
      if (carts[i] == p) return i;
    return -1;
  }

  public void Delete(Cart p) {
    int n = Indice(p);
    if (n == -1) return;
    for (int i = n; i < nc - 1; i++)
      carts[i] = carts[i + 1];
    nc--;
  }

  // EXEMPLARYS CODE //
  public void InsertExemplary(Exemplary e) {
    if (nc == exemplarys.Length) {
      Array.Resize(ref exemplarys, 2 * exemplarys.Length);
    }
    exemplarys[nc] = p;
    nc++;
  }

  public Exemplary[] ListExemplarys() {
    Exemplary[] p = new Exemplary[nc];
    Array.Copy(carts, p, nc);
    return p;
  }
}