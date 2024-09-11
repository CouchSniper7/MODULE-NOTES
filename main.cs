using System;

class Program {
  private const double MY_CONST = 1.00;
  
  public static void Main (string[] args) {
    const double ANOTHER_CONST = 2.00;
    var fullName = ConcatName("Joseph", "Simonin");
    Console.WriteLine ("Hello World! " + fullName + " is Here");
  }

  private static string ConcatName(string firstName, string lastName) {
    return firstName + ' ' + lastName;
  }
}