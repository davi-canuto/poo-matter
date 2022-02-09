using System;

class Cart{
  private int id;
  private int capacity;
  private User user;
  public Cart(int id, int capacity){
    this.id = id;
    this.capacity = capacity;
  }
  public Cart(int id, int capacity, User user) : this(id,capacity){
    this.user = user;
  }
  public void SetId(int id){
    this.id = id;
  }
  public void SetCapacity(int capacity){
    this.capacity = capacity;
  }
  public void SetUser(User user){
    this.user = user;
  }
  public int GetId(){
    return id;
  }
  public int GetCapacity(){
    return capacity;
  }
  public User GetUser(){
    return user;
  }
  public override string ToString(){
    if (user == null)
      return id + " - " + " Capacity: " + capacity + " Books.";
    else
      return id + " - " + " Capacity: " + capacity + " Books - User: " + user.name;
  }
}