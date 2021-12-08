using System;

class MainClass { 
  public static void Main(){
    Travel x = new Travel(400, 5, 30);
    
    Console.WriteLine(x);
  }
}


class Travel {
  private int distance;
  private int hour;
  private int minute;

  public Travel(int distance, int hour, int minute){
    this.distance = distance;
    this.hour = hour;
    this.minute = minute;
  }

  public int average_speed(int distance, int hour){
    return distance/hour;
  }
  public override string ToString(){
    return "Distance: " + distance + "km" + ", Time of travel = " + hour +":"+ minute +"hr"+ ", Average speed = " + average_speed(distance,hour).ToString()+"km/h";
  }
}
