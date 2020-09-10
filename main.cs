using System;

class MainClass {
  public static double toFarenheit(double temp)
  {
    return((temp * 9/5) + 32);
  }
  public static void Main (string[] args) {
    Console.WriteLine ("Enter Temperature In Celsius");
    double temp = double.Parse(Console.ReadLine());
    double fTemp = toFarenheit(temp);
    Console.WriteLine("Farenheit equivalent for " + temp + " degrees Celsius is " + fTemp);
    if (fTemp < 32)
    {
      Console.WriteLine("This temperature is below the freezing temperature of 32 degrees farenheit");
    }
    else if (fTemp > 212)
    {
      Console.WriteLine("This temperature is above the boiling temperature of 212 degrees farenheit");
    }
  }
}