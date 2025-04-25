using System;
using System.Linq;
namespace Calc
{
  public class Calc
  {
    public static void Start()
    {
      Console.WriteLine("");
      Console.WriteLine("write exit to exit");
      Console.WriteLine("");
      while (true)
      {
        Console.Write("> ");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        if (input == "exit")
        {
          Console.WriteLine("");
          Console.WriteLine("bye");
          break;
        }
        if (parts.Length == 3)
        {
          if (parts[0].All(char.IsDigit) && parts[2].All(char.IsDigit))
          {
            float num1 = float.Parse(parts[0]);
            float num2 = float.Parse(parts[2]);
            if (parts[1] == "+" || parts[1] == "-" || parts[1] == "x" || parts[1] == "*"|| parts[1] == "/")
            {
              string op = parts[1];
              Console.WriteLine("");
              Console.WriteLine("result:");
              if (op == "+")
              {
                Console.WriteLine(num1 + num2);
              }
              else if (op == "-")
              {
                Console.WriteLine(num1 - num2);
              }
              else if (op == "x" || op == "*")
              {
                Console.WriteLine(num1 * num2);
              }
              else if (op == "/")
              {
                Console.WriteLine(num1 / num2);
              }
              else
              {
                Console.WriteLine("error");
              }
            }
            else
            {
              Console.WriteLine("error");
            }
          }
          else
          {
            Console.WriteLine("error");
          }
        }
        else
        {
          Console.WriteLine("error");
        }
      }
    }
  }
}
