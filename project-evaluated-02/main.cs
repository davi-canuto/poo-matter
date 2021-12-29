using System;

class MainClass{
   public static void Main(){
     Library l1 = new Library(1,"Biblioteca 1", 2);
     Console.WriteLine(l1);

     Book b1 = new Book(1,"Harry Potter", "Romance", l1);
     Book b2 = new Book(2,"Senhor dos aneis", "Ficção", l1);
     Console.WriteLine(b1);
     Console.WriteLine(b2);
   }
}