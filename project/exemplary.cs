using System;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Exemplary {
  public int id;
  public string title;
  private Cart cart;
  public Exemplary() { }

  public int Id { get => id; set => id = value; }
  public string Title { get => title; set => title = value; }

  public Exemplary(int id, string title) {
    this.id = id;
    this.title = title;
  }
  public Exemplary(int id, string title, Cart cart) : this(id,title){
    this.cart = cart;
  }
  public void SetId(int id) {
    this.id = id;
  }
  public void SetTitle(string title) {
    this.title = title;
  }
  public void SetCart(Cart cart) {
    this.cart = cart;
  }
  public int GetId() {
    return id;
  }
  public string GetTitle() {
    return title;
  }
  public Cart GetCart() {
    return cart;
  }

  public override string ToString(){
    if (cart == null)
      return id + " - " + title;
    else
      return id + " - " + title + " -  Cart_id: " + cart.id;
  }
}