using System;

class MainClass { 
  public static void Main(){
    Turma x = new Turma("Mat",50,80,20,40,20);
    Console.WriteLine(x);
  }
}

class Turma {
  private string matter;
  private int n1,n2,n3,n4,nf;
  public Turma(string matter, int n1, int n2, int n3, int n4, int nf){
    this.matter = matter;
    this.n1 = n1;
    this.n2 = n2;
    this.n3 = n3;
    this.n4 = n4;
    this.nf = nf;
  }

  public int partial_average(int n1,int n2, int n3,int n4){
    return ((n1*2)+(n2*2)+(n3*3)+(n4*3))/10;
  }

  public int final_media(int nf){
    return (partial_average + nf)/2;
  }
  public override string ToString(){
    if (partial_average(n1,n2,n3,n4) > 60) 
      return "Matter:"+ matter + " - Media = " + partial_average(n1,n2,n3,n4).ToString();
    else
      return "Matter: "+ matter + " - Media = " + partial_average(n1,n2,n3,n4).ToString() + " Final Media = " + final_media(nf).ToString();
  }
}