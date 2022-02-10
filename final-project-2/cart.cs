using System;

class Cart{
  public int id { get; set; }
  public int capacity { get; set; }
  public User user;

  public override string ToString(){
    if (user == null)
      return id + " - " + " Capacity: " + capacity + " Books.";
    else
      return id + " - " + " Capacity: " + capacity + " Books - User: " + user.name;
  }
}