using System;

class MainClass{
  public static void Main(){
    int a = 5;
    int b = 3;
    int c = 1;

    if ( a > b) Swap<int>(ref a, ref b);
    if ( a > c) Swap<int>(ref a, ref c);
    if ( b > c) Swap<int>(ref b, ref c);
    Console.WriteLine($"{a} {b} {c}");

    string a2 = "FF";
    string b2 = "BB";
    string c2 = "AA";

    if (a2.CompareTo(b2) == 1) Swap<string>(ref a2, ref b2);
    if (a2.CompareTo(c2) == 1) Swap<string>(ref a2, ref c2);
    if (b2.CompareTo(c2) == 1) Swap<string>(ref b2, ref c2);
    Console.WriteLine($"{a2} {b2} {c2}");
  }
  public static void Swap<T>(ref T x, ref T y) {
    T aux = x;
    x = y;
    y = aux;
  }
}