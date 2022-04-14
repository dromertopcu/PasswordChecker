using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Input a password:  ");
      string password = Console.ReadLine();
      bool lowercase = false;
      bool uppercase = false;
      bool digit =false;
      bool symbol =false;
      if(password.Length >= 8)
      {
        foreach(char c in password)
        {
          lowercase = (lowercase ==false) ? Char.IsLower(c) : true;
          uppercase = (uppercase == false) ? Char.IsUpper(c) : true;
          digit = (digit ==false) ? Char.IsNumber(c) : true;
          symbol = (symbol == false) ? Char.IsPunctuation(c) : true;
          if(lowercase&&uppercase&&digit&&symbol)
          {
            Console.WriteLine("Password is saved!");
            break;
          }
        }
          if(!(lowercase&&uppercase&&digit&&symbol))
          {
            Console.WriteLine("\nPassword cannot be saved!\n\n***\nA strong password:\nis at least 8 characters long\nhas lowercase letters\nhas uppercase letters\nhas numerical digits\nhas symbols, like #, ?, !\n***\n");
          }
      }
      else
      {
        Console.WriteLine("Password has to at least 8 characters long!");
      }
    }
  }
}
