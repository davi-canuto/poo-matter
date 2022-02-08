using System;

class MainClass{
  public static void Main(){

  }
}

class Converter{
  private int num;
  public Converter(int num){
    this.num = num;
  }

  public void SetNum(int num){
    this.num = num;
  }
  public int GetNum(){
    return num;
  }
  public string Binary(int numeroDecimal){
      string valor = "";
      int dividendo = Convert.ToInt32(numeroDecimal);
      if (dividendo == 0 || dividendo == 1)
        {
          return Convert.ToString(dividendo);
        }
      else
        {
          while (dividendo > 0)
            {
              valor += Convert.ToString(dividendo % 2);
              dividendo = dividendo / 2;
            }
          return ReverteString(valor);
        }
  }
  public override string ToString(){
    return "Decimal: " + num + " - " + " binario " + 
  }
}
