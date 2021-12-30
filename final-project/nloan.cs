using System;

class NLoan{
  private Loan[] loanbooks = new Loan[10];
  private int nc;


  public void Insert(Loan l){
    if (nc == loanbooks.Length) {
      Array.Resize(ref loanbooks, 2 * loanbooks.Length);
    }
    loanbooks[nc] = l;
    nc++;
  }

  public Loan[] List() {
    Loan[] c = new Loan[nc];
    Array.Copy(loanbooks, c, nc);
    return c;
  }

  public Loan List(int id) {
    for (int i = 0 ; i < nc; i++)
      if (loanbooks[i].GetId() == id) return loanbooks[i];
    return null;                                  
  }   

  public void Delete(Loan l){
    int n = Indice(l);
    if (n == -1) return;
    for (int i = n; i < nc-1; i++)
      loanbooks[i] = loanbooks[i + 1];
    nc--;
  }

  private int Indice(Loan c){
    for (int i = 0; i < nc; i++)
      if(loanbooks[i] == c) return i;
    return -1;
  }
}