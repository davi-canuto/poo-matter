using System;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Exemplary {
  public int id;
  private Cart cart;
  private Book book;
  public Exemplary() { }

  public int Id { get => id; set => id = value; }
  public string BookId { get => book.GetId(); set => book.GetId() = value; }
  public Exemplary(int id) {
    this.id = id;
  }
  public Exemplary(int id, Cart cart, Book book) : this(id){
    this.cart = cart;
    this.book = book;
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
  public void SetBook(Book book) {
    this.book = book;
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
  public Book GetBook() {
    return book;
  }

  public override string ToString(){
    if (cart == null)
      return id + " - " + book.title;
    else
      return id + " - " + book.title + " -  Cart_id: " + cart.id;
  }
}