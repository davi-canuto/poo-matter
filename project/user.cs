using System;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Linq;
using System.Collections.Generic;

public class User {
  public int id;
  public string name;
  public DateTime birthdate;
  private User[] users = new User[10];
  private int np;
  public User() { }

  public User(int id, string name, DateTime birthdate) {
    this.id = id;
    this.name = name;
    this.birthdate = birthdate;
  }
  public void SetId(int id) {
    this.id = id;
  }
  public void SetName(string name) {
    this.name = name;
  }
  public void SetBirthdate(DateTime birthdate) {
    this.birthdate = birthdate;
  }
  public int GetId() {
    return id;
  }
  public string GetName() {
    return name;
  }
  public DateTime GetBirthdate() {
    return birthdate;
  }
  public override string ToString() {
    return id + " - " + name + " - " + birthdate.ToString("dd/MM/yyyy");
  }
}