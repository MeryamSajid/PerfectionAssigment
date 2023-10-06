using System;

class Program {
    // Function to check for the number perfection
    static bool PerfectNumber(int num)
    {
        int sumInt = 0;

        // Loop to find divisors and continuously sum them as the loop iterates
        for (int divisor = 1; divisor < num; divisor++)
        {
            if (num % divisor == 0)
            {
                sumInt += divisor;
            }
        }

        // Check if the sum of divisors equals the input number
        return sumInt == num;
    }

    static void Main()
    {
        Console.WriteLine("Enter the number to check for perfection: ");
      if (int.TryParse(Console.ReadLine(), out int inputNum)) 
      {
          if (PerfectNumber(inputNum)) 
          {
            Console.WriteLine ("Perfect Number"); 
          }
        else
          {
            Console.WriteLine ("Not A Perfect Number");
          }
        }
      else 
      {
      Console.WriteLine ("Please enter a valid integer to test.");
      }
  
    }
 }
            
  

        