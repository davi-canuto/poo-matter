using System;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Linq;
using System.Collections.Generic;

public class Exemplary {
  public int id;
  private string title;
  public Exemplary() { }

  public int Id { get => id; set => id = value; }
  public string Title { get => title; set => title = value; }
  
  public Exemplary(int id, string title) {
    this.id = id;
    this.title = title;
  }
  public void SetId(int id) {
    this.id = id;
  }
  public void SetTitle(string title) {
    this.title = title;
  }
  public int GetId() {
    return id;
  }
  public string GetTitle() {
    return title;
  }

  public override string ToString(){
    return id + " - " + title;
  }
}