using System;
using System.Collections.Generic;

class NCart {
  private List<Cart> carts = new List<Cart>();

  public void Insert(Cart l){
    int max = 0;
    foreach(Cart obj in carts)
      if (obj.id > max) max = obj.id;
    l.id = max + 1;
    carts.Add(l);
  }

  public List<Cart> List() {
    return carts;
  }

  public Cart List(int id) {
    for (int i = 0 ; i < carts.Count; i++)
      if (carts[i].id == id) return carts[i];
    return null;
  }

  public void Update(Cart l){
    Cart c_atual = List(l.id);
    if (c_atual == null) return;
    c_atual.capacity = l.capacity;
  }

  public void Delete(Cart l){
    if (l != null) carts.Remove(l);
  }

}