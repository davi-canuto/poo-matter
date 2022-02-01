using System;
using System.Collections;
using System.Collections.Generic;

class MainClass{
  public static void Main(){
    Hashtable h = new Hashtable();
    h["Brasil"] = 5;
    h["Italia"] = 4;
    h["Alemanha"] = 4;
    h["Argentina"] = 2;
    h.Add("Uruguai", 2);
    h.Add("França", 2);
    h.Add("Inglaterra", 1);
    h.Add("Espanha", 1);
    foreach (DictionaryEntry x in h) Console.WriteLine(
      $"{x.Key} = {x.Value} Titulo(s)"
    );
    Console.WriteLine("---------------------------------------------------------------");
    
    SortedList<string, int> d = new SortedList<string, int>();
    d["Brasil"] = 5;
    d["Italia"] = 4;
    d["Alemanha"] = 4;
    d["Argentina"] = 2;
    d.Add("Uruguai", 2);
    d.Add("França", 2);
    d.Add("Inglaterra", 1);
    d.Add("Espanha", 1);
    foreach (KeyValuePair<string, int> x in d) Console.WriteLine(
      $"{x.Key} = {x.Value} Titulo(s)"
    );
  }
}