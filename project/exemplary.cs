using System;

public class Exemplary : IComparable<Exemplary>  {
  public int id { get; set; }
  public string title { get; set; }
  public int CompareTo(Exemplary obj) {
    return this.title.CompareTo(obj.title);
  }
  public override string ToString() {
    return id + " - " + exemplary;
  }
}