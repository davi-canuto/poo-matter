using System;
using System.Collections;
using System.Collections.Generic;

class MainClass{
  public static void Main(){
    string [] v = new string[5];
    v[0] = "Colecoes";
    v[1] = "em";
    v[2] = "c#";
    v[3] = "02";
    v[4] = "2020";
    foreach(string s in v) Console.WriteLine(s);

    // ARRAY LIST
    ArrayList a = new ArrayList();
    a.Add("colescoes");
    a.Add("em");
    a.Add("c#");
    a.Add("11");
    a.Add("2020");
    foreach(object s in a) Console.WriteLine(s);

    // LIST
    List<string> a2 = new List<string>();
    a2.Add("COlecoes");
    a2.Add("em");
    a2.Add("c#");
    a2.Add("10");
    a2.Add("2020");
    foreach(string s in a2) Console.WriteLine(s);

    // QUEUE
    Queue<string> f = new Queue<string>();
    f.Enqueue("COlecoes");
    f.Enqueue("em");
    f.Enqueue("c#");
    f.Enqueue("10");
    f.Enqueue("2020");
    while(f.Count > 0) Console.WriteLine(f.Dequeue());

    // PILHA
    Stack<string> p = new Stack<string>();
    p.Push("COlecoes");
    p.Push("em");
    p.Push("c#");
    p.Push("10");
    p.Push("2020");
    while(p.Count > 0) Console.WriteLine(p.Pop());


  }
}