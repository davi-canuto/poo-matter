using System;

class User{
  public int id { get; set;}
  public string name { get; set;}
  public DateTime birthdate { get; set;}

  public override string ToString(){
    return id + " - " + name + " - " + birthdate.ToString("dd/MM/yyyy");
  }
}