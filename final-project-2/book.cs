using System;

class Book {
  private int id;
  private string title;
  private string gender;
  private Cart cart;
  private Loan loan;
  public Book(int id, string title, string gender){
    this.id = id;
    this.title = title;
    this.gender = gender;
  }
  public Book(int id, string title, string gender, Cart cart) : this(id,title,gender){
    this.cart = cart;
  }
  public void SetId(int id){
    this.id = id;
  }
  public void SetTitle(string title){
    this.title = title;
  }
  public void SetGender(string gender){
    this.gender = gender;
  }
  public void SetBag(Cart cart){
    this.cart = cart;
  }
  public void SetLoan(Loan loan){
    this.loan = loan;
  }
  public int GetId(){
    return id;
  }
  public string GetTitle(){
    return title;
  }
  public string GetGender(){
    return gender;
  }
  public Cart GetBag(){
    return cart;
  }
  public Loan GetLoan(){
    return loan;
  }

  public override string ToString(){
    if (cart == null)
      return id + " - " + title + " - Gender: " + gender;
    else
      return id + " - " + title + " - Gender: " + gender + ", Cart id: " + cart.id;
  }
}