using System;

public class User {
  public int id { get; set; }
  public string name { get; set; }
  public DateTime birthdate { get; set; }
  public int CompareTo(User obj) {
    return this.name.CompareTo(obj.name);
  }

  public override string ToString() {
    return id + " - " + name + " - " + birthdate.ToString("dd/MM/yyyy");
  }
}