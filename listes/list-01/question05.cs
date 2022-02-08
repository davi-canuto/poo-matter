using System;

class MainClass { 
  public static void Main(){
    MovieTicket x = new MovieTicket("Quarta", 14);
    Console.WriteLine(x);
  }
}

class MovieTicket {
  private string session_day;
  private int session_time;

  public MovieTicket(string session_day, int session_time){
    this.session_day = session_day;
    this.session_time = session_time;
  }

  public int ticket_amount(string session_day, int session_time){
    int base_value;
    int value;
    if (session_day == "Segunda" || session_day == "Terça" || session_day == "Quinta"){
      base_value = 16;
      if (session_time > 17 && session_time < 24)
        return value = (base_value/2)+16;
      else
        return value = base_value;
    }
    if (session_day == "Quarta"){
      base_value = 8;
      if (session_time > 17 && session_time < 24)
        return value = (base_value/2)+8;
      else
        return value = base_value;
    }

    if (session_day == "Sexta" || session_day == "Sabado" || session_day == "Domingo"){
      base_value = 20; 
      if (session_time > 17 && session_time < 24)
        return value = (base_value/2)+20;
      else
        return value = base_value;
    } 
  }

  public override string ToString(){
    return "Ticket = " + ticket_amount(session_day, session_time)+ "R$";
  }
}
