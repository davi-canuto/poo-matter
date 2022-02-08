using System;

class MainClass{
  public static void Main(){
    double d,t;
    Travel x = new Travel();
    x.SetDistance(400);
    x.SetTime(5.40);
    d = x.GetDistance();
    t = x.GetTime();
    Console.WriteLine(x.average_speed(d,t));
  }
}

class Travel{
  private double distance;
  private double time;

  public void SetDistance(double d){
    distance = d;
  }
  public void SetTime(double t){
    time = t;
  }

  public double GetDistance(){
    return distance;
  }
  public double GetTime(){
    return time;
  }

  public double average_speed(double distance, double time){
    return distance/time;
  }
}
