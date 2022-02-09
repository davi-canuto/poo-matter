using System;

class Cart{
  private int id { get; set; }
  private int capacity { get; set; }
  private User user;

  public override string ToString(){
    if (user == null)
      return id + " - " + " Capacity: " + capacity + " Books.";
    else
      return id + " - " + " Capacity: " + capacity + " Books - User: " + user.name;
  }
}