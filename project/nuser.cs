
using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Collections.Generic;


class NUser{
  static NUser obj = new NUser();
  public User[] users = new User[10];
  public int np;
  public NUser() { }
  public void Open() {
   string s = File.ReadAllText("./users.json");
   User[] users = JsonSerializer.Deserialize(users);
   foreach(User u in users) Console.WriteLine(u);
  }
  public void ToSave() {
    string s = JsonSerializer.Serialize(users);
    File.WriteAllText("./users.json", s);
    s.Close();
  }
  public User[] List() {
    User[] p = new User[np];
    Array.Copy(users, p, np);
    return p;
  }
  public User List(int id) {
    for (int i = 0; i < np; i++)
      if (users[i].GetId() == id) return users[i];
    return null;
  }

  public void Insert(User p) {
    if (np == users.Length) {
      Array.Resize(ref users, 2 * users.Length);
    }
    users[np] = p;
    np++;
  }

  public void Update(User p) {
    User p_atual = List(p.GetId());
    if (p_atual == null) return;
    p_atual.SetName(p.GetName());
    p_atual.SetBirthdate(p.GetBirthdate());
  }

  private int Indice(User p) {
    for(int i = 0; i < np; i++)
      if (users[i] == p) return i;
    return -1;
  }

  public void Delete(User p) {
    int n = Indice(p);
    if (n == -1) return;
    for (int i = n; i < np - 1; i++)
      users[i] = users[i + 1];
    np--;
  }
}