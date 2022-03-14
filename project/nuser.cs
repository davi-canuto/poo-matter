
using System;
using System.Collections;
using System.Collections.Generic;

class NUser{
  private NUser() { }
  static NUser obj = new NUser();
  public static NUser Singleton { get => obj; }
  private List<User> users = new List<User>();
  public void Open() {
    Archive<List<User>> f = new Archive<List<User>>();
    clientes = f.Open("./users.xml");
  }
  public void ToSave() {
    Archive<List<User>> f = new Archive<List<User>>();
    f.ToSave("./users.xml", List());
  }
  public List<User> List() {
    users.Sort();
    return users;
  }
  public User List(int id) {
    for (int i = 0 ; i < users.Count; i++)
      if (users[i].id == id) return users[i];
    return null;
  }
  public void Insert(User l){
    int max = 0;
    foreach(User obj in users)
      if (obj.id > max) max = obj.id;
    l.id = max + 1;
    users.Add(l);
  }


  public void Update(User l){
    User c_atual = List(l.id);
    if (c_atual == null) return;
    c_atual.name = l.name;
    c_atual.birthdate = l.birthdate;
  }

  public void Delete(User l){
    if (l != null) users.Remove(l);
  }
}