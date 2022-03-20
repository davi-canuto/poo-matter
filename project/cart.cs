using System;

public class Cart{
  public int id;
  public int capacity;

  private Exemplary[] exemplarys = new Exemplary[10];
  private int id_user;
  private int np;

  public int Id { get => id; set => id = value; }
  public int Capacity { get => capacity; set => capacity = value; }
  public int User_Id { get => id_user; set => id_user = value; }
  public Cart() { }

  public Cart(int id, int capacity, int id_user) {
    this.id = id;
    this.id_user = id_user;
    this.capacity = capacity > 0 ? capacity : 0;
  }
  public void SetId(int id) {
    this.id = id;
  }
  public void SetCapacity(int capacity) {
    this.capacity = capacity;
  }
  public void SetUserId(int id_user) {
    this.id_user = id_user;
  }

  public int GetId() {
    return id;
  }
  public int GetCapacity() {
    return capacity;
  }
  public int GetUserId() {
    return id_user;
  }

  public override string ToString(){
    if (id_user == null)
      return id + " - " + " Capacity: " + capacity + " Books ";
    else
      return id + " - " + " Capacity: " + capacity + " Books , User_Id: " + id_user;
  }
}