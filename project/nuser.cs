
using System;
using System.Collections;
using System.Collections.Generic;

class NUser{
  private List<User> users = new List<User>();
  public List<User> List() {
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

  // private int Indice(User c){
  //   for (int i = 0; i < nc; i++)
  //     if(users[i] == c) return i;
  //   return -1;
  // }
}