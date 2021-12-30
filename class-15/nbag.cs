using System;

class NBag { 
  private Bag[] bags = new Bag[10];
  private int nc;

  public void Insert(Bag l){
    if (nc == bags.Length) {
      Array.Resize(ref bags, 2 * bags.Length);
    }
    bags[nc] = l;
    nc++;
  }

  public Bag[] List() {
    Bag[] c = new Bag[nc];
    Array.Copy(bags, c, nc);
    return c;
  }
  
  public Bag List(int id) {
    for (int i = 0 ; i < nc; i++)
      if (bags[i].GetId() == id) return bags[i];
    return null;                                  
  }   

  public void Update(Bag l){
    Bag c_atual = List(l.GetId());
    if (c_atual == null) return;
    c_atual.SetCapacity(l.GetCapacity());
  }

  public void Delete(Bag l){
    int n = Indice(l);
    if (n == -1) return;
    for (int i = n; i < nc-1; i++)
      bags[i] = bags[i + 1];
    nc--;
  }
  
  private int Indice(Bag c){
    for (int i = 0; i < nc; i++)
      if(bags[i] == c) return i;
    return -1;
  }
}