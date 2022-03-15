using System;

class Exemplary {
  public int id;
  public string title;
  private Cart cart;
  private Book book;
  public Exemplary() { }

  public Exemplary(int id, string title) {
    this.id = id;
    this.title = title;
  }
  public Exemplary(int id, string title, Cart cart, Book book) : this(id,title){
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
      return id + " - " + title;
    else
      return id + " - " + title + " -  Cart_id: " + cart.GetId();
  }
}