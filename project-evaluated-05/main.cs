using System;

class MainClass{
   private static NBook nbook = new NBook();
   public static void Main(){
     int op = 0;
     int o = 0;
     Console.WriteLine("--------------- BOOKS ----------------");
     op = Menu();
     if (op == 1){
       do {
         try{
           o = MenuLibrarian();
           switch(o) {
             case 1 : ;break;
             case 2 : ;break;
           }
         } catch (Exception erro){
           Console.WriteLine(erro.Message);
           op = 100;
         }
       } while (o != 0);
     }
     if (op == 2){
       do {
         try{
           o = MenuLibrarian();
           switch(o) {
             case 1 : Console.WriteLine("tué2");break;
             case 2 : Console.WriteLine("tuné2");break;
           }
         } catch (Exception erro){
           Console.WriteLine(erro.Message);
           op = 100;
         }
       } while (o != 0);
     }
   }

   public static int MenuLibrarian(){
     Console.WriteLine();
     Console.WriteLine("-----------------------------------------");
     Console.WriteLine("1 - List books");
     Console.WriteLine("2 - Insert book");
     Console.WriteLine("3 - Delete book")
     Console.WriteLine("0 - End!");
     Console.Write("Enter an option: ");
     int op = int.Parse(Console.ReadLine());
     Console.WriteLine();
     return op;
   }

   public static int MenuUser(){

   }

   public static int Menu(){
     Console.WriteLine();
     Console.WriteLine("What are you?");
     Console.WriteLine("1 - Librarian");
     Console.WriteLine("2 - User");
     Console.Write("Enter: ");
     int op = int.Parse(Console.ReadLine());
     Console.WriteLine();
     return op;
   }
   

   /* public static void BookList(){
     Console.WriteLine("------Book List----");
     Book[] k = new Book[20];
     k = nbook.List();
     if (k.Length == 0) {
       Console.WriteLine("No books.");
     }
     foreach(Book b in k) Console.WriteLine(b);
     Console.WriteLine();
   } */

   /*public static void BookInsert(){
     Console.WriteLine("------- Book Insert ------");
     Console.Write("Enter an id for the book: ");
     int id = int.Parse(Console.ReadLine());
     Console.Write("Enter the title: ");
     string title = Console.ReadLine();
     Console.Write("Enter the book gender: ");
     string bookgender = Console.ReadLine();
     Book l = new Book(id,title,bookgender);
     nbook.Insert(l);
   }*/

    /*public static void BookReserve(){
     Console.WriteLine("-------Book Reserve ---------");
     if (BookList().Length == 0) {
       Console.WriteLine("No books.");
       return;
     } else {
       Console.WriteLine(BookList());
     }
     Console.WriteLine("Enter the id for the books reserves  --- Enter 0 for exit");

   }*/
}