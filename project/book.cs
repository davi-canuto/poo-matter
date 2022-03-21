using System;
using System.Collections.Generic;

class Book {
  public int id;
  public string title;
  public string gender;
   private Exemplary[] exemplarys = new Exemplary[10];
  public int Id { get => id; set => id = value; }
  public string Title { get => title; set => title = value; }
  public string Gender { get => gender; set => gender = value; }

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