
using System;

class User{
  private int id;
  private string name;

  public User(int id, string name){
    this.id = id;
    this.name = name;
  }
  public void SetId(int id){
    this.id = id;
  }

  public void SetName(string name){
    this.name = name;
  }
  public int GetId(){
    return id;
  }
  public string GetName(){
    return name;
  }

  public override string ToString(){
    return id + " - " + name;
  }
} 