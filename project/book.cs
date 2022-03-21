using System;
using System.Collections.Generic;
public class Book : IComparable<Book>  {
  public int id { get; set; }
  public string title { get; set; }
  public string gender { get; set; }
  public int CompareTo(Book obj) {
    return this.title.CompareTo(obj.title);
  }
  public override string ToString() {
    return id + " - " + title + " - " + gender;
  }
}