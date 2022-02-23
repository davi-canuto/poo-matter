using System;

class Exemplary {
  public int id { get; set; }
  public string title { get; set; }
  public int cart { get; set; }

  public override string ToString(){
    return id + " - " + title + " -  Cart_id: " + cart;
  }
}