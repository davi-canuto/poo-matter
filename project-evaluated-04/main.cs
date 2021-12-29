using System;

class MainClass{
   public static void Main(){
     int op = 0;
     Console.WriteLine("--------------- LIBRARY ----------------");
     do {
       try {
          op = Menu();
          switch(op){
            case 1 : LibraryList();break;
            case 2 : LibraryInsert();break;
          }
       }
       catch (Exception erro) {
         Console.WriteLine(erro.Message);
         op = 100;
       }
     } while (op != 0);
     Console.WriteLine("Bye...");
   }

   public static int Menu(){
     Console.WriteLine();
     Console.WriteLine("-----------------------------------------");
     Console.WriteLine("1 - Library - List");
     Console.WriteLine("2 - Library - Insert");
     Console.WriteLine("0 - End!");
     Console.Write("Enter an option: ");
     int op = int.Parse(Console.ReadLine());
     Console.WriteLine();
     return op;
   }

   public static void LibraryList(){
     Console.WriteLine("Meuovo");
   }

   public static void LibraryInsert(){
     Console.WriteLine("meupinto");
   }
}