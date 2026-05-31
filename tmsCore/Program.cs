
using System;
class Program
{
    static void Main(){
        Console.Write("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        var result=num1 % num2;
        if(num1 % num2 == 0)
        {
            Console.WriteLine($"Even number: {num1} is divisible by {num2} remindervalue= {result}");
        }
        else
        {
            Console.WriteLine($"Odd number: {num1} is not divisible by {num2}  remindervalue={result}");
        }
        Console.ReadLine();

    }
}