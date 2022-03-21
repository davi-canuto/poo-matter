
using System;
using System.Collections.Generic;


class NExemplary{
  public NExemplary() { }
  static NExemplary obj = new NExemplary();
  public static NExemplary Singleton { get => obj; }
  private List<Exemplary> exemplarys = new List<Exemplary>();
  public void Open() {
    Archive<List<Exemplary>> f = new Archive<List<Exemplary>>();
    exemplarys = f.Open("./exemplarys.xml");
  }
  public void ToSave() {
    Archive<List<Exemplary>> f = new Archive<List<Exemplary>>();
    f.ToSave("./exemplarys.xml", List());
  }
  public List<Exemplary> List() {
    exemplarys.Sort();
    return exemplarys;
  }

  public Exemplary List(int id) {
    for (int i = 0; i < exemplarys.Count; i++)
      if (exemplarys[i].id == id) return exemplarys[i];
    return null;
  }

  public void Insert(Exemplary c) {
    int max = 0;
    foreach(Exemplary obj in exemplarys)
      if (obj.id > max) max = obj.id;
    c.id = max + 1;
    exemplarys.Add(c);
  }

  public void Update(Exemplary c) {
    Exemplary c_atual = List(c.id);
    if (c_atual == null) return;
    c_atual.title = c.title;
  }

  public void Delete(Exemplary c) {
    if (c != null) exemplarys.Remove(c);
  }
}