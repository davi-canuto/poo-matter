using System;

class Cart{
  public int id;
  public int capacity;

  private Exemplary[] exemplarys = new Exemplary[10];
  private User user;
  private int userId;
  private int np;
  public Cart() { }

  public Cart(int id, int capacity) {
    this.id = id;
    this.capacity = capacity > 0 ? capacity : 0;
  }
  public Cart(int id, int capacity, User user) : this(id, capacity) {
    this.user = user;
    this.userId = user.id;
  }
  public void SetId(int id) {
    this.id = id;
  }
  public void SetCapacity(int capacity) {
    this.capacity = capacity;
  }

  public int GetId() {
    return id;
  }
  public int GetCapacity() {
    return capacity;
  }
  public Exemplary[] ListExemplarys() {
    Exemplary[] c = new Exemplary[np];
    Array.Copy(exemplarys, c, np);
    return c;
  }
   public void InsertExemplary(Exemplary p) {
    if (np == exemplarys.Length) {
      Array.Resize(ref exemplarys, 2 * exemplarys.Length);
    }
    exemplarys[np] = p;
    np++;
  }
  private int IndiceExemplary(Exemplary p) {
    for (int i = 0; i < np; i++)
      if (exemplarys[i] == p) return i;
    return -1;
  }
  public void DeleteExemplary(Exemplary p) {
    int n = IndiceExemplary(p);
    if (n == -1) return;
    for (int i = n; i < np - 1; i++)
      exemplarys[i] = exemplarys[i + 1];
    np--;
  }

  public override string ToString(){
    if (user == null)
      return id + " - " + " Capacity: " + capacity + " Books ";
    else
      return id + " - " + " Capacity: " + capacity + " Books , User_Id: " + user.id;
  }
}