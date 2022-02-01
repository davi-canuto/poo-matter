using System;
using System.Collections;
class MainClass{
public static void Main(){
    Aluno a = new Aluno("Pedro","Matricula 1", DateTime.Parse("01/01/2001"));
    Aluno b = new Aluno("Maria","Matricual 2", DateTime.Parse("01/02/2001"));
    Aluno c = new Aluno("Joao", "Matricula 3",DateTime.Parse("01/03/2001"));
    Aluno[] v = { a,b,c};
    // Array.Sort(v);
    AlunoNascimentoComp x = new AlunoNascimentoComp();
    // AlunoMatriculaComp y = new AlunoMatriculaComp();
    Array.Sort(v,x);
    foreach (Aluno i in v) Console.WriteLine(i);
  }
}
class Aluno : IComparable {
  private string nome;
  private string matricula;
  private DateTime nascimento;

  public Aluno(string nome, string matricula, DateTime nascimento) {
    this.nome = nome;
    this.matricula = matricula;
    this.nascimento = nascimento;
  }
  public override string ToString(){
    return $"Nome: {nome}, Matricula: {matricula}, Nascimento: {nascimento:dd/MM/yyyy}.";
  }
  public int CompareTo(object obj){
    Aluno x = (Aluno) obj;
    return this.nome.CompareTo(x.nome);
  }
  public DateTime GetNascimento(){
    return nascimento;
  }
  public string GetMatricula(){
    return matricula;
  }
}

class AlunoNascimentoComp : IComparer {
  public int Compare(object x, object y){
    Aluno a = (Aluno)x;
    Aluno b = (Aluno)y;
    return a.GetNascimento().CompareTo(b.GetNascimento());
  }
}

class AlunoMatriculaComp : IComparer{
  public int Compare(object z, object h){
    Aluno w = (Aluno)z;
    Aluno q = (Aluno)h;
    return q.GetMatricula().CompareTo(w.GetMatricula());
  }
}