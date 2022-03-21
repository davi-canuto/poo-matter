using System;
using System.Collections.Generic;
using System.Text;
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
    return 
      exemplarys.Take(np).OrderBy(obj => obj.GetTitle()).ToArray();
  }
  public Exemplary List(int id) {
    return exemplarys.FirstOrDefault(obj => obj.GetId() == id);
  }

  public void Insert(Exemplary p) {
    if (np == exemplarys.Length) {
      Array.Resize(ref exemplarys, 2 * exemplarys.Length);
    }
    exemplarys[np] = p;
    np++;
  }
}