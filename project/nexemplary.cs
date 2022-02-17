using System;
using System.Collections.Generic;

class NExemplary{
  private List<Exemplary> exemplarys = new List<Exemplary>();

  public void Insert(Exemplary l){
    int max = 0;
    foreach(Exemplary obj in exemplarys)
      if(obj.id > max) max = obj.id;
    l.id = max+1;
    exemplarys.Add(l);
  }

  public List<Exemplary> List() {
    return exemplarys;
  }

  public Exemplary List(int id) {
    for (int i = 0 ; i < exemplarys.Count; i++)
      if (exemplarys[i].id == id) return exemplarys[i];
    return null;
  }

  public void Delete(Exemplary l){
    if (l != null) exemplarys.Remove(l);
  }

  public void Update(Exemplary l){
    Exemplary c_atual = List(l.id);
    if (c_atual == null) return;
    c_atual.title = l.title;
  }
}