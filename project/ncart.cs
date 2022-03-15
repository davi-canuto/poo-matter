using System;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class NCart {
  static NCart obj = new NCart();
  public static NCart Singleton;

  private Cart[] carts = new Cart[10];
  private int np;
  public NCart(){ }
  public void Open(){
    Archive<Cart[]> f = new Archive<Cart[]>();
    carts = f.Open("./carts.xml");
    np = carts.Length;
  }
  public void ToSave(){
    Archive<Cart[]> f = new Archive<Cart[]>();
    f.ToSave("./carts.xml", List());
  }
  public Cart[] List() {
    Cart[] p = new Cart[np];
    Array.Copy(carts, p, np);
    return p;
  }
  public Cart List(int id) {
    for (int i = 0; i < np; i++)
      if (carts[i].GetId() == id) return carts[i];
    return null;
  }

  public void Insert(Cart p) {
    if (np == carts.Length) {
      Array.Resize(ref carts, 2 * carts.Length);
    }
    carts[np] = p;
    np++;
  }

  public void Update(Cart p) {
    Cart p_atual = List(p.GetId());
    if (p_atual == null) return;
    p_atual.SetCapacity(p.GetCapacity());
  }

  private int Indice(Cart p) {
    for(int i = 0; i < np; i++)
      if (carts[i] == p) return i;
    return -1;
  }

  public void Delete(Cart p) {
    int n = Indice(p);
    if (n == -1) return;
    for (int i = n; i < np - 1; i++)
      carts[i] = carts[i + 1];
    np--;
  }
}