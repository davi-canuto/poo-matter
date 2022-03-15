using System;
using System.Collections.Generic;

class Book {
  public int id;
  public string title;
  public string gender;
  public Book() { }

  public Book(int id, string title, string gender) {
    this.id = id;
    this.title = title;
    this.gender = gender;
  }
  public void SetId(int id) {
    this.id = id;
  }
  public void SetTitle(string title) {
    this.title = title;
  }
  public void SetGender(string gender) {
    this.gender = gender;
  }
  public int GetId() {
    return id;
  }
  public string GetTitle() {
    return title;
  }
  public string GetGender() {
    return gender;
  }
  public override string ToString(){
    return id + " - " + title + " - Gender: " + gender;
  }
}