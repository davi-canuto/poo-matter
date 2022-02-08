using System;
class MainClass{
  public static void Main(){
    Compromisso c1 = new Compromisso {
      Assunto = "Assunto 1",
      Local = "Local 1",
      Data = DateTime.Now
    };
    Compromisso c2 = new Compromisso {
      Assunto = "Assunto 2",
      Local = "Local 2",
      Data = DateTime.Now
    };

    Agenda a = new Agenda();
    a.Inserir(c1);
    a.Inserir(c2);
    foreach(Compromisso c in a.Listar()) Console.WriteLine(c);


    Colecoes<Compromisso> a2 = new Colecoes<Compromisso>();
    a2.Inserir(c1);
    a2.Inserir(c2);
    foreach(Compromisso c in a2.Listar()) Console.WriteLine(c);


    Applicativo app1 = new Applicativo{
      Nome = "Nome 1",
      Categoria = "Categoria 1",
      Preco = 100
    };
    Applicativo app2 = new Applicativo{
      Nome = "Nome 2",
      Categoria = "Categoria 2",
      Preco = 150
    };

    Loja l = new Loja();
    l.Inserir(app1);
    l.Inserir(app2);
    foreach(Applicativo app in l.Listar()) Console.WriteLine(app);

    Colecoes<Applicativo> l2 = new Colecoes<Applicativo>();
    l2.Inserir(app1);
    l2.Inserir(app2);
    foreach(Applicativo app in l2.Listar()) Console.WriteLine(app);
  }
}
class Compromisso{
  public string Assunto { get; set;}
  public string Local { get; set;}
  public DateTime Data { get; set;}
  public override string ToString()
  {
    return $"{Assunto} {Local} { Data}";
  }
}
class Applicativo{
  public string Nome { get; set;}
  public string Categoria { get; set;}
  public decimal Preco { get; set;}
  public override string ToString()
  {
    return $"{Nome} {Categoria} { Preco}";
  }
}
class Agenda{
  private Compromisso[] comps = new Compromisso[50];
  private int k;
  public void Inserir(Compromisso c){
    if (k < 50) comps[k++] = c;
  }
  public Compromisso[] Listar(){
    Compromisso[] r = new Compromisso[k];
    Array.Copy(comps, r, k);
    return r;
  }
}
class Loja {
  private Applicativo[] apps = new Applicativo[50];
  private int k;
  public void Inserir(Applicativo app){
    if (k < 50) apps[k++] = app;
  }
  public Applicativo[] Listar(){
    Applicativo[] r = new Applicativo[k];
    Array.Copy(apps, r, k);
    return r;
  }
}

class Colecoes<T> {
  private T[] apps = new T[50];
  private int k;
  public void Inserir(T app){
    if (k < 50) apps[k++] = app;
  }
  public T[] Listar(){
    T[] r = new T[k];
    Array.Copy(apps, r, k);
    return r;
  }
}