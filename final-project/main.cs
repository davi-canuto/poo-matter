using System;

class MainClass{
  private static NBook nbook = new NBook();
  private static NUser nuser = new NUser();
  private static NBag nbag = new NBag();
  private static NLoan nloan = new NLoan();
  public static void Main(){
    int op = 0;
    int o = 0;
    int p = 0 ;
    Console.WriteLine ("----- BOOK ORGANIZATION APP ------");
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
        p = MenuBag();
        switch(p){
          case 1 : BagList(); break;
          case 2 : BagInsert(); break;
          case 3 : BagRemove();break;
          case 4 : BagUpdate();break;
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
          case 4 : BookLoan();break;
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
    Console.WriteLine("0 - Go for register Bag");
    Console.Write("Enter: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }

  public static int MenuBag(){
    Console.WriteLine();
    Console.WriteLine("--------- REGISTER BAG -----------");
    Console.WriteLine("1 - List bags");
    Console.WriteLine("2 - Insert bag");
    Console.WriteLine("3 - Remove bag"); 
    Console.WriteLine("4 - Update bag"); 
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
    Console.WriteLine("1 - List the books that are in the bag.");
    Console.WriteLine("2 - Insert book in your bag.");
    Console.WriteLine("3 - Remove book the bag.");
    Console.WriteLine("4 - Loan the book.");
    Console.WriteLine("0 - EXIT!!!!.");
    Console.Write("Enter: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }

  public static int LoanMenu(){
    Console.WriteLine();
    Console.WriteLine("---------- LOAN -----------");
    Console.WriteLine();
    Console.WriteLine("1 - Insert book for Loan");
    Console.WriteLine("2 - Listen the books chosen for loan");
    Console.WriteLine("3 - Remove book chosen for loan");
    Console.WriteLine("0 - EXIT PROGRAM!!!.");
    Console.WriteLine();
    Console.Write("Enter the number: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }

/*   ------------------ BOOK CODE ------------------- */
  public static void BookList(){
    Console.WriteLine("------- BOOKS IN THE BAG ---------");
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
    BagList();
    Console.Write("Inform the bag code:");
    int idbook = int.Parse(Console.ReadLine());
    Bag b = nbag.List(idbook);
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

  public static void BookLoan(){
    int m = 0;
    do {
      try {
        m = LoanMenu();
        switch(m) {
          case 1 : LoanInsert(); break;
          case 2 : LoanList(); break;
          case 3 : LoanRemove();break;
        }
      }
      catch (Exception erro) {
        Console.WriteLine(erro.Message);
        m = 100;
      }
    } while (m != 0);
  }
/*   ------------------ LOAN CODE ------------------- */
  public static void LoanInsert(){
    Console.WriteLine("-------- INSERT BOOKS FOR LOAN --------------");
    Console.Write("Enter an id for the loan: ");
    int id = int.Parse(Console.ReadLine());
    BookList();
    Console.Write("Enter code for the book loan: ");
    int idbook = int.Parse(Console.ReadLine());
    Book i = nbook.List(idbook);
    Loan l = new Loan(id,i);
    nloan.Insert(l);

  }
  public static void LoanList(){
    Console.WriteLine("------- BOOKS TO LOAN ---------");
    Loan[] cs = nloan.List();
    if (cs.Length == 0){
      Console.WriteLine("No loans!");
      return;
    }
    foreach(Loan c in cs) Console.WriteLine(c);
    Console.WriteLine();
  }
  public static void LoanRemove(){
    Console.WriteLine("------BOOK REMOVE LOAN-------");
    LoanList();
    Console.Write("Inform loan code for excludes loan: ");
    int id = int.Parse(Console.ReadLine());
    Loan c = nloan.List(id);
    nloan.Delete(c);
  }

/*   ------------------ USER CODE ------------------- */

  public static void UserList(){
    Console.WriteLine("------- USERS LIST ---------");
    User[] us = nuser.List();
    if (us.Length == 0){
      Console.WriteLine("No users!");
      return;
    } 
    foreach(User u in us) Console.WriteLine(u);
    Console.WriteLine();
  }


  public static void UserInsert(){
    Console.WriteLine("-------- REGISTER USER --------------");
    Console.Write("Enter an id for the user: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Enter the name: ");
    string name = Console.ReadLine();
    User c = new User(id, name);
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
    User c = new User(id, name);
    nuser.Update(c);

  }

/*   ------------------ BAG CODE ------------------- */

  public static void BagList(){
    Console.WriteLine("------- BAG LIST ---------");
    Bag[] us = nbag.List();
    if (us.Length == 0){
      Console.WriteLine("No bags!");
      return;
    } 
    foreach(Bag u in us) Console.WriteLine(u);
    Console.WriteLine();
  }


  public static void BagInsert(){
    Console.WriteLine("-------- REGISTER BAG --------------");
    Console.Write("Enter an id for the bag: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Enter the bag books capacity: ");
    int capacity = int.Parse(Console.ReadLine());
    UserList();
    Console.Write("Inform the bag user code: ");
    int iduser = int.Parse(Console.ReadLine());
    User u = nuser.List(iduser);
    Bag b = new Bag(id, capacity,u);
    nbag.Insert(b);
  }

  public static void BagUpdate(){
    Console.WriteLine("------BAG UPTATE-------");
    BagList();
    Console.Write("Enter an id for the bag update: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Enter the new capacity: ");
    int capacity = int.Parse(Console.ReadLine());
    Bag c = new Bag(id, capacity);
    nbag.Update(c);
  }

  public static void BagRemove(){
    Console.WriteLine("------BAG REMOVE-------");
    BagList();
    Console.Write("Inform user code for excludes bag: ");
    int id = int.Parse(Console.ReadLine());
    Bag c = nbag.List(id);
    nbag.Delete(c);
  }
}