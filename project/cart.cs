using System;

public class Cart{
  public int id;
  public int capacity;

  private Exemplary[] exemplarys = new Exemplary[10];
  private User user;
  private int np;
  public Cart() { }

  public Cart(int id, int capacity) {
    this.id = id;
    this.capacity = capacity > 0 ? capacity : 0;
  }
  public Cart(int id, int capacity, User user) : this(id, capacity) {
    this.user = user;
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

  public override string ToString(){
    if (user == null)
      return id + " - " + " Capacity: " + capacity + " Books ";
    else
      return id + " - " + " Capacity: " + capacity + " Books , User_Id: " + user.id;
  }
}