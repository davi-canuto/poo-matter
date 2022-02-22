using System;

class Cart{
  public int id { get; set; }
  public int capacity { get; set; }
  public int user { get; set; }
    


  public override string ToString(){
    if (user == null)
      return id + " - " + " Capacity: " + capacity + " Books.";
    else
      return id + " - " + " Capacity: " + capacity + " Books - User_id: " + user;
  }
}