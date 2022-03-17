
using System;
using System.Collections.Generic;


class NUser{
  public NUser() { }
  static NUser obj = new NUser();
  public static NUser Singleton { get => obj; }
  private List<User> users = new List<User>();
  public void Open() {
    Archive<List<User>> f = new Archive<List<User>>();
    users = f.Open("./users.xml");
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
    for (int i = 0; i < users.Count; i++)
      if (users[i].id == id) return users[i];
    return null;
  }

  public void Insert(User c) {
    int max = 0;
    foreach(User obj in users)
      if (obj.id > max) max = obj.id;
    c.id = max + 1;
    users.Add(c);
  }

  public void Update(User c) {
    User c_atual = List(c.id);
    if (c_atual == null) return;
    c_atual.name = c.name;
    c_atual.birthdate = c.birthdate;
  }

  public void Delete(User c) {
    if (c != null) users.Remove(c);
  }
}