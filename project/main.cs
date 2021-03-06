using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Linq;
class MainClass{

  private static NUser nuser = NUser.Singleton;
  private static NBook nbook = NBook.Singleton;
  private static NCart ncart = NCart.Singleton;
  private static NExemplary nexemplary = NExemplary.Singleton;
  enum LoanStatus {borrowed, analyze }
  public static void Main(){

    try {
      nuser.Open();
      ncart.Open();
      nexemplary.Open();
      nbook.Open();
    }
    catch(Exception erro) {
      Console.WriteLine(erro.Message);
    }
    int op = 0;
    int o = 0;
    int p = 0 ;
    Console.WriteLine ("------------------------------ LIBRARY APP------------------------------ ");
    do {
      try {
        o = MenuUser();
        switch(o){
          case 1 : UserList(); break;
          case 2 : UserInsert(); break;
          case 3 : UserDelete(); break;
          case 4 : UserUpdate(); break;
        }
      } catch(Exception erro) {
        Console.WriteLine(erro.Message);
        o = 100;
      }
    } while (o != 0);
    do {
      try {
        p = MenuCart();
        switch(p){
          case 1 : CartList(); break;
          case 2 : CartInsert(); break;
          case 3 : CartRemove();break;
          case 4 : CartUpdate();break;
        }
      } catch(Exception erro) {
        Console.WriteLine(erro.Message);
        p = 100;
      }
    } while (p != 0);
    do {
      try {
        op = MenuBook();
        switch(op) {
          case 1 : BookList(); break;
          case 2 : BookInsert(); break;
          case 3 : BookRemove();break;
          case 4 : BookUpdate();break;
          case 5 : ExemplaryInsert(); break;
          case 6 : ExemplaryList(); break;
          case 7 : InsertExemplaryInCart(); break;
          case 99 : CartListExemplary();break;
          case 100 : CartLoan();break;
        }
      }
      catch (Exception erro) {
        Console.WriteLine(erro.Message);
        op = 100;
      }
    } while (op != 0);
    try {
      nuser.ToSave();
      ncart.ToSave();
      nbook.ToSave();
      nexemplary.ToSave();
    }
    catch(Exception erro){
      Console.WriteLine(erro.Message);
    }

    Console.WriteLine ("Bye.....");
  }

  public static int MenuUser(){
    Console.WriteLine();
    Console.WriteLine("--------- REGISTER USER -----------");
    Console.WriteLine("1 - List users");
    Console.WriteLine("2 - Insert user");
    Console.WriteLine("3 - Remove user");
    Console.WriteLine("4 - Update user");
    Console.WriteLine("0 - Go for register Cart");
    Console.Write("Enter: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }

  public static int MenuCart(){
    Console.WriteLine();
    Console.WriteLine("--------- REGISTER Cart -----------");
    Console.WriteLine("1 - List carts");
    Console.WriteLine("2 - Insert cart");
    Console.WriteLine("3 - Remove cart");
    Console.WriteLine("4 - Update cart");
    Console.WriteLine("0 - Go for organization books.");
    Console.Write("Enter: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }

  public static int MenuBook(){
    Console.WriteLine();
    Console.WriteLine("------------- BOOK AND EXEMPLARYS -------------");
    Console.WriteLine();
    Console.WriteLine("1 - List the books you have in the library.");
    Console.WriteLine("2 - Insert book.");
    Console.WriteLine("3 - Remove book.");
    Console.WriteLine("4 - Updated book.");
    Console.WriteLine("5 - Insert exemplary.");
    Console.WriteLine("6 - List exemplarys.");
    Console.WriteLine("7 - Insert exemplary in cart.");
    Console.WriteLine("99 - View your cart.");
    Console.WriteLine("100 - Loan your exemplarys in the cart.");
    Console.WriteLine("0 - EXIT!!!!.");
    Console.Write("Enter: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }

/*   ------------------ BOOK CODE ------------------- */
  public static void BookList() {
    Console.WriteLine("----- BOOKS -----");
    List<Book> cs = nbook.List();
    if (cs.Count == 0) {
      Console.WriteLine("Not exists books");
      return;
    }
    foreach(Book c in cs) Console.WriteLine(c);
    Console.WriteLine();
  }

  public static void BookInsert() {
    Console.WriteLine("----- Insert book in library -----");
    Console.Write("Write the title: ");
    string title = Console.ReadLine();
    Console.Write("Write the gender: ");
    string gender = Console.ReadLine();
    Book c = new Book { title = title, gender = gender };
    nbook.Insert(c);
  }

  public static void BookUpdate() {
    Console.WriteLine("----- Update user -----");
    BookList();
    Console.Write("Enter the book code to be updated:");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Enter the book title ");
    string title = Console.ReadLine();
    Console.Write("Enter the new gender: ");
    string gender = Console.ReadLine();
    Book c = new Book { id = id, title = title, gender = gender };
    nbook.Update(c);
  }

  public static void BookRemove() {
    Console.WriteLine("----- Delete book -----");
    BookList();
    Console.Write("Enter the id for book excludes: ");
    int id = int.Parse(Console.ReadLine());
    Book c = nbook.List(id);
    nbook.Delete(c);
  }
  /* ------------------ EXEMPLARY CODE ---------------*/
 public static void ExemplaryList(){
   Console.WriteLine("----- list of exemplarys -----");
    List<Exemplary> cs = nexemplary.List();
    if (cs.Count == 0) {
      Console.WriteLine("Not exists exemplarys");
      return;
    }
    foreach(Exemplary c in cs) Console.WriteLine(c);
    Console.WriteLine();
  }

  public static void ExemplaryInsert(){
    Console.WriteLine("----- Insert Exemplary -----");
    BookList();
    Console.Write("Write id for the book: ");
    int book_id = int.Parse(Console.ReadLine());
    Book book = nbook.List(book_id);
    string title = book.title;
    Exemplary c = new Exemplary { title = title };
    nexemplary.Insert(c);
  }
/*   ------------------ USER CODE ------------------- */

  public static void UserList() {
    Console.WriteLine("----- list of users -----");
    List<User> cs = nuser.List();
    if (cs.Count == 0) {
      Console.WriteLine("Not exist users registered");
      return;
    }
    foreach(User c in cs) Console.WriteLine(c);
    Console.WriteLine();
  }

  public static void UserInsert() {
    Console.WriteLine("----- Registered user -----");
    Console.Write("Write the user name: ");
    string name = Console.ReadLine();
    Console.Write("Write the user birthdate (dd/MM/yyyy): ");
    DateTime birthdate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
    User c = new User { name = name, birthdate = birthdate };
    nuser.Insert(c);
  }

  public static void UserUpdate() {
    Console.WriteLine("----- Update user -----");
    UserList();
    Console.Write("Enter the user code to be updated:");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Enter the user name ");
    string name = Console.ReadLine();
    Console.Write("Enter the user birthdate (dd/MM/yyyy): ");
    DateTime birthdate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
    User c = new User { id = id, name = name, birthdate = birthdate };
    nuser.Update(c);
  }

  public static void UserDelete() {
    Console.WriteLine("----- Delete user -----");
    UserList();
    Console.Write("Enter the id for user excludes: ");
    int id = int.Parse(Console.ReadLine());
    User c = nuser.List(id);
    nuser.Delete(c);
  }

/*   ------------------ Cart CODE ------------------- */
  public static void CartList(){
    Console.WriteLine("-----------CART LIST ---------");
    Cart[] cs = ncart.List();
    if (cs.Length == 0){
      Console.WriteLine("No carts!");
      return;
    }
    else
    {
      foreach(Cart u in cs) Console.WriteLine(u);
      Console.WriteLine();
    }
  }
  
  public static void CartListExemplary(){
    Console.WriteLine("------- Cart LIST ---------");
    Cart[] cs = ncart.List();
    Exemplary[] es = ncart.ListExemplarys();
    if (cs.Length == 0 ){
      Console.WriteLine("No carts!");
      return;
    }
    else if (es.Length != 0){
      foreach(Cart u in cs){
        Console.WriteLine(u);
      }
      Console.WriteLine("////EXEMPLARYS\\\\");
      foreach(Exemplary k in es){
        Console.WriteLine(k);
      }
      Console.WriteLine();
      return;
    }
    else
    {
      foreach(Cart u in cs){
        Console.WriteLine(u);
      }
    }
  }

  public static void CartInsert(){
    Console.WriteLine("-------- REGISTER CART --------------");
    Console.Write("Enter the id for cart: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Enter the cart books capacity: ");
    int capacity = int.Parse(Console.ReadLine());
    UserList();
    Console.Write("Inform the cart user code: ");
    int id_user = int.Parse(Console.ReadLine());
    Cart c = new Cart(id, capacity,id_user);
    ncart.Insert(c);
  }

  public static void CartUpdate(){
    Console.WriteLine("------ CART UPTATE-------");
    CartList();
    Console.Write("Enter an id for the cart update: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Enter the new capacity: ");
    int capacity = int.Parse(Console.ReadLine());
    UserList();
    Console.Write("Enter the new user id: ");
    int id_user = int.Parse(Console.ReadLine());
    Cart c = new Cart(id,capacity,id_user);
    ncart.Update(c);
  }

  public static void CartRemove(){
    Console.WriteLine("------CART REMOVE-------");
    CartList();
    Console.Write("Inform user code for excludes cart: ");
    int id = int.Parse(Console.ReadLine());
    Cart c = ncart.List(id);
    ncart.Delete(c);
  }
  public static void InsertExemplaryInCart(){
    Console.WriteLine("--- INSERT EXEMPLARY IN CART -----");
    ExemplaryList();
    Console.WriteLine("Inform id code exemplary for add to cart: ");
    int id_exemplary = int.Parse(Console.ReadLine());
    Exemplary e = nexemplary.List(id_exemplary);
    ncart.InsertExemplary(e);
  }
  public static void CartLoan(){
    Console.WriteLine("------ CART LOAN -------");
    CartList();
    Console.Write("Inform id code cart for loan: ");
    int id = int.Parse(Console.ReadLine());
    Cart c = ncart.List(id);
    Console.WriteLine($"Cart borrowed: {c} Status: Borrowed");
  }
}