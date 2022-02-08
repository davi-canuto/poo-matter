using System;

class MainClass{
  public static void Main(){
    int n1,n2,n3,n4;

    Discipline x = new Discipline();
    x.SetName("Quimica");
    x.SetN1(20);
    x.SetN2(60);
    x.SetN3(80);
    x.SetN4(100);

    n1 = x.GetN1();
    n2 = x.GetN2();
    n3 = x.GetN3();
    n4 = x.GetN4();
    int media = x.partial_average(n1,n2,n3,n4);
    if (media > 60) Console.WriteLine($"O Aluno passou com media: {media}");
    else {
      int nf;
      x.SetNf(40);

      nf = x.GetNf();
      Console.WriteLine($"O aluno ficou de recuperação e acabou com media final:{x.final_average(media,nf)}");
    }
  }
}

class Discipline {
  private string name;
  private int n1,n2,n3,n4,nf;

  public void SetName(string n){
    name = n;
  }
  public void SetN1(int n){
    n1 = n;
  }
  public void SetN2(int n){
    n2 = n;
  }
  public void SetN3(int n){
    n3 = n;
  }
  public void SetN4(int n){
    n4 = n;
  }
  public void SetNf(int n){
    nf = n;
  }


  public string GetName(){
    return name;
  }
  public int GetN1(){
    return n1;
  }
  public int GetN2(){
    return n2;
  }
  public int GetN3(){
    return n3;
  }
  public int GetN4(){
    return n4;
  }
  public int GetNf(){
    return nf;
  }

  public int partial_average(int n1, int n2, int n3, int n4){
    return ((n1*2)+(n2*2)+(n3*3)+(n4*3))/10;
  }
  public int final_average(int media, int nf){
    return (media+nf)/2;
  }
}