using System;

class Program {
  public static void Main (string[] args) {
    string op;
    Console.WriteLine("A - Solteiro");
    Console.WriteLine("B - Casado");
    Console.WriteLine("C - Viúvo");
    Console.WriteLine("D - Divorciado");
    op = Console.ReadLine();
    op = op.ToUpper();
    
    switch (op)
    {
    case "A":
      Console.WriteLine("Vai pra balada 1");
      break;
    case "B":
      Console.WriteLine("Vai pra balada 2");
      break;
    case "C":
      Console.WriteLine("Vai pra balada 3");
      break;
    case "D":
      Console.WriteLine("Vai pra balada 4");
      break;
    default:
      Console.WriteLine("?");
      break;
    }
  }
}