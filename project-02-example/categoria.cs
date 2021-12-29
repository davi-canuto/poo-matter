using System;

class Categoria {
  private int id;
  private string descricao;
  private Produto[] produto = new Produto[10];

  public Categoria(int id, string descricao) {
    this.id = id;
    this.descricao = descricao;
  }
  public void SetId(int id) {
    this.id = id;
  }
  public void SetDescricao(string descricao) {
    this.descricao = descricao;
  }
  public int GetId() {
    return id;
  }
  public string GetDescricao() {
    return descricao;
  }
  public Produto[] ProdutoListar(){
    return produtos;
  }

  public void ProdutoInserir( Produto p){
    produtos[np] = p;
    np++;
  }
  public override string ToString() {
    return id + " - " + descricao + " - Numero de produtos: " + np; 
  }
}