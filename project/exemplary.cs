using System;

class Exemplary {
  public int id { get; set; }
  public string title { get; set; }
  public int cart { get; set; }

  public override string ToString(){
    if (cart == null)
      return id + " - " + title;
    else
      return id + " - " + title + " -  Cart_id: " + cart;
  }
}