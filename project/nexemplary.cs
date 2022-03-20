using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class NExemplary{
  public NExemplary(){ }
  static NExemplary obj = new NExemplary();
  public static NExemplary Singleton { get => obj; }
  private Exemplary[] exemplarys = new Exemplary[10];
  private int np;
  public void Open(){
    Archive<Exemplary[]> f = new Archive<Exemplary[]>();
    exemplarys = f.Open("./exemplarys.xml");
    np = exemplarys.Length;
  }
  public void ToSave(){
    Archive<Exemplary[]> f = new Archive<Exemplary[]>();
    f.ToSave("./exemplarys.xml", List());
  }
   public Exemplary[] List() {
    Exemplary[] p = new Exemplary[np];
    Array.Copy(exemplarys, p, np);
    return p;
  }
  public Exemplary List(int id) {
    for (int i = 0; i < np; i++)
      if (exemplarys[i].GetId() == id) return exemplarys[i];
    return null;
  }

  public void Insert(Exemplary p) {
    if (np == exemplarys.Length) {
      Array.Resize(ref exemplarys, 2 * exemplarys.Length);
    }
    exemplarys[np] = p;
    np++;
  }

  public void Update(Exemplary p) {
    Exemplary p_atual = List(p.GetId());
    if (p_atual == null) return;
    p_atual.SetTitle(p.GetTitle());
  }

  private int Indice(Exemplary p) {
    for(int i = 0; i < np; i++)
      if (exemplarys[i] == p) return i;
    return -1;
  }

  public void Delete(Exemplary p) {
    int n = Indice(p);
    if (n == -1) return;
    for (int i = n; i < np - 1; i++)
      exemplarys[i] = exemplarys[i + 1];
    np--;
  }
}