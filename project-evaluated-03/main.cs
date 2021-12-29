using System;

class MainClass{
   public static void Main(){
     Library l1 = new Library(1,"Biblioteca 1");
     Console.WriteLine(l1);

     Book b1 = new Book(1,"Harry Potter", "Romance", l1);
     Book b2 = new Book(2,"Senhor dos aneis", "Ficção", l1);
     Console.WriteLine(b1);
     Console.WriteLine(b2);

     l1.BookInsert(b1);
     l1.BookInsert(b2);

     Book[] b = l1.BookList();
     Console.Write("Livros na biblioteca: ");
     Console.WriteLine(l1.GetName());
     foreach (Book v in b) Console.WriteLine(v);
   }
}