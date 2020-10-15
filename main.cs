using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Input number.");
    int i = Int32.Parse(Console.ReadLine());

    Console.WriteLine ("Input power.");
    int p = Int32.Parse(Console.ReadLine());

    Console.WriteLine("Result: " + IntegerPower(i, p));
  }

  public static int IntegerPower(int i, int p) {
    return i * ((p - 1) * i);
  }
}