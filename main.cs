using System;

class Program {

  const double CentimetersPerInch = 2.54;

  public static void Main (string[] args) {
    Console.WriteLine ("Enter a number of inches: ");
    string inches = Console.ReadLine();
    double centimeters = Double.Parse(inches) * CentimetersPerInch;
    Console.WriteLine("{0} inches is {1} centimeters", inches, centimeters);
  }
}