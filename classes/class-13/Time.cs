using System;

class MainClass{
  public static void Main(string[] args){
    Time time = new Time("XYZ");
    Jogador j1 = new Jogador("Jogador 1",10);
    Jogador j2 = new Jogador("Jogador 2",20);
    time.Inserir(j1);
    time.Inserir(j2);
    foreach(Jogador x in time.Listar())
      Console.WriteLine(x);
  }
}

class Jogador{
  private string name;
  private int shirt;

  public Jogador(string name, int shirt){
    this.name = name;
    this.shirt = shirt;
  }
  public override string ToString(){
    return $"{name} {shirt}";
  }
}

class Time{
  private string name;
  private Jogador[] player;
  private int k;
  public Time(string name){
    this.name = name;
    player = new Jogador[6];
  }
  public void Inserir(Jogador play){
    if(k < 6) {
      player[k] = play;
      k++;
    }
  }
  public Jogador[] Listar() {
    Jogador[] r = new Jogador[k];
    Array.Copy(player,r,k);
    return r;
  }
}