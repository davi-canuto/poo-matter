using System;

class Cart{
  public int id { get; set; }
  public int capacity { get; set; }
  private List<User> users;

  public override string ToString(){
    if (user == null)
      return id + " - " + " Capacity: " + capacity + " Books.";
    else
      return id + " - " + " Capacity: " + capacity + " Books - User_id: " + user;
  }
}