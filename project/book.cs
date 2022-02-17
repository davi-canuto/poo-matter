using System;
using System.Collections.Generic;

class Book {
  public int id { get; set; }
  public string title { get; set; }
  public string gender { get; set; }

  public override string ToString(){
    return id + " - " + title + " - Gender: " + gender;
  }
}