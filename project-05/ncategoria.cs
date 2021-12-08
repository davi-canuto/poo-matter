using System;

class NCategoria {
  private Categoria[] categorias = new Categoria[10];
  private int nc;

  public void Inserir(Categoria c){
    if (nq == categorias.Length) {
      Array.Resize(ref categorias, 2 * categorias.Length);
    }
    categorias[nc] = c;
    nc++;
  }
}