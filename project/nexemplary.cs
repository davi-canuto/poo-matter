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
}