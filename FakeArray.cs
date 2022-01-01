using System;

class FakeArray
{
   public static void Main(string[] args)
   {
        ///Array Declaration
      int[] num = new int[10];
      double sum, avg;

      Console.Write("\nEnter number 1:> ");
      num[0] = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter number 2:> ");
      num[1] = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter number 3:> ");
      num[2] = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter number 4:> ");
      num[3] = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter number 5:> ");
      num[4] = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter number 6:> ");
      num[5] = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter number 7:> ");
      num[6] = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter number 8:> ");
      num[7] = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter number 9:> ");
      num[8] = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter number 10:> ");
      num[9] = Convert.ToInt32(Console.ReadLine());
      
      sum = num[0] + num[1] + num[2] + num[3] + num[4] + num[5] + num[6] + num[7] + num[8] + num[9] ;
      avg = sum / 10;

      Console.WriteLine("\nThe average is " + avg);
   }
}