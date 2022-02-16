using System;
using System.Collections;
using System.Collections.Generic;

class MainClass{
  private static NBook nbook = new NBook();
  private static NUser nuser = new NUser();
  private static NCart ncart = new NCart();
  public static void Main(){
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
          case 3 : UserRemove(); break;
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
        }
      }
      catch (Exception erro) {
        Console.WriteLine(erro.Message);
        op = 100;
      }
    } while (op != 0);
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
    Console.WriteLine("------------- ORGANIZATION BOOKS -------------");
    Console.WriteLine();
    Console.WriteLine("1 - List the books that are in the cart.");
    Console.WriteLine("2 - Insert book in your cart.");
    Console.WriteLine("3 - Remove book the cart.");
    Console.WriteLine("0 - EXIT!!!!.");
    Console.Write("Enter: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }

/*   ------------------ BOOK CODE ------------------- */
  public static void BookList(){
    Console.WriteLine("------- BOOKS IN THE Cart ---------");
    Book[] cs = nbook.List();
    if (cs.Length == 0){
      Console.WriteLine("No books!");
      return;
    }
    foreach(Book c in cs) Console.WriteLine(c);
    Console.WriteLine();
  }

  public static void BookInsert(){
    Console.WriteLine("-------- INSERT BOOKS --------------");
    Console.Write("Enter an id for the book: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Enter the title: ");
    string title = Console.ReadLine();
    Console.Write("Enter the gender: ");
    string gender = Console.ReadLine();
    CartList();
    Console.Write("Inform the Cart code:");
    int idbook = int.Parse(Console.ReadLine());
    Cart b = ncart.List(idbook);
    Book i = new Book(id,title,gender,b);
    nbook.Insert(i);
  }

  public static void BookRemove(){
    Console.WriteLine("------Book REMOVE-------");
    BookList();
    Console.Write("Inform user code for excludes Book: ");
    int id = int.Parse(Console.ReadLine());
    Book c = nbook.List(id);
    nbook.Delete(c);
  }


/*   ------------------ USER CODE ------------------- */

  public static void UserList(){
    Console.WriteLine("------- USERS LIST ---------");
    List<User> cs = nuser.List();
    if (cs.Count == 0){
      Console.WriteLine("No users registered!");
      return;
    }
    foreach(User u in cs) Console.WriteLine(u);
    Console.WriteLine();
  }


  public static void UserInsert(){
    Console.WriteLine("-------- REGISTER USER --------------");

    Console.Write("Enter the name: ");
    string name = Console.ReadLine();
    Console.Write("Enter the birth date (dd/MM/yyyy):");
    DateTime birthdate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
    User c = new User{
      name = name, birthdate = birthdate
    };
    nuser.Insert(c);
  }

  public static void UserRemove(){
    Console.WriteLine("------USER REMOVE-------");
    UserList();
    Console.Write("Inform user code for excludes: ");
    int id = int.Parse(Console.ReadLine());
    User c = nuser.List(id);
    nuser.Delete(c);
  }

  public static void UserUpdate(){
    Console.WriteLine("------USER UPTATE-------");
    UserList();
    Console.Write("Enter an id for the user update: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Enter the new name: ");
    string name = Console.ReadLine();
    Console.Write("Enter the new birthdate: ");
    DateTime birthdate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
    User c = new User{
      id = id, name = name, birthdate = birthdate
    };
    nuser.Update(c);

  }

/*   ------------------ Cart CODE ------------------- */

  public static void CartList(){
    Console.WriteLine("------- Cart LIST ---------");
    List<Cart> cs = ncart.List();
    if (cs.Count == 0){
      Console.WriteLine("No carts!");
      return;
    }
    foreach(Cart u in cs) Console.WriteLine(u);
    Console.WriteLine();
  }


  public static void CartInsert(){
    Console.WriteLine("-------- REGISTER CART --------------");
    Console.Write("Enter the cart books capacity: ");
    int capacity = int.Parse(Console.ReadLine());
    UserList();
    Console.Write("Inform the cart user code: ");
    int iduser = int.Parse(Console.ReadLine());
    Cart c = new Cart{
      capacity = capacity,
      user = iduser
    };
    ncart.Insert(c);
  }

  public static void CartUpdate(){
    Console.WriteLine("------ CART UPTATE-------");
    CartList();
    Console.Write("Enter an id for the cart update: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Enter the new capacity: ");
    int capacity = int.Parse(Console.ReadLine());
    Cart c = new Cart{id = id, capacity = capacity};
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
}