using System;

class NUser{
  private User[] users = new User[10];
  private int nc;

  public void Insert(User l){
    if (nc == users.Length) {
      Array.Resize(ref users, 2 * users.Length);
    }
    users[nc] = l;
    nc++;
  }

  public User[] List() {
    User[] c = new User[nc];
    Array.Copy(users, c, nc);
    return c;
  }
  
  public User List(int id) {
    for (int i = 0 ; i < nc; i++)
      if (users[i].GetId() == id) return users[i];
    return null;                                  
  }   

  public void Update(User l){
    User c_atual = List(l.GetId());
    if (c_atual == null) return;
    c_atual.SetName(l.GetName());
  }

  public void Delete(User l){
    int n = Indice(l);
    if (n == -1) return;
    for (int i = n; i < nc-1; i++)
      users[i] = users[i + 1];
    nc--;
  }
  
  private int Indice(User c){
    for (int i = 0; i < nc; i++)
      if(users[i] == c) return i;
    return -1;
  }
}