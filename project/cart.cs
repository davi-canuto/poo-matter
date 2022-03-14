using System;

class Cart{
  public int id;
  public int capacity;

  private Exemplary[] exemplays = new Exemplary[10];
  private User user;
  private int user;
  private int np;
  public int id { get => id; set => id = value; }
  public string capacity { get => capacity; set => capacity = value; }
  public Cart() { }

  public Cart(int id, int capacity) {
    this.id = id;
    this.capacity = capacity > 0 ? capacity : 0;
  }
  public Cart(int id, int capacity, User user) : this(id, capacity) {
    this.user = user;
    this.userId = user.GetId();
  }
  public void SetId(int id) {
    this.id = id;
  }
  public void SetCapacity(string capacity) {
    this.capacity = capacity;
  }
  public void SetUser(User user) {
    this.user = user;
    this.userId = user.GetId();
  }
  public int GetId() {
    return id;
  }
  public string GetCapacity() {
    return capacity;
  }
  public User GetUser() {
    return user;
  }
  public Exemplary[] ListExemplarys() {
    Exemplary[] c = new Exemplary[np];
    Array.Copy(exemplays, c, np);
    return c;
  }
   public void InsertExemplary(Exemplary p) {
    if (np == exemplays.Length) {
      Array.Resize(ref exemplays, 2 * exemplays.Length);
    }
    exemplays[np] = p;
    np++;
  }
  private int IndiceExemplary(Exemplary p) {
    for (int i = 0; i < np; i++)
      if (exemplays[i] == p) return i;
    return -1;
  }
  public void DeleteExemplary(Exemplary p) {
    // Exclui um produto da categoria
    int n = IndiceExemplary(p);
    if (n == -1) return;
    for (int i = n; i < np - 1; i++)
      exemplays[i] = exemplays[i + 1];
    np--;
  }

  public override string ToString(){
    if (user == null)
      return id + " - " + " Capacity: " + capacity + " Books ";
    else
      return id + " - " + " Capacity: " + capacity + " Books , User_Id: " + user.GetId();
  }
}