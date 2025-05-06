using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Ask user for a decimal number
        Console.Write("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        if (decimalNumber == 0)
        {
            Console.WriteLine("The binary equivalent of 0 is: 0");
            return;
        }

        StringBuilder binaryNumber = new StringBuilder();

        while (decimalNumber > 0)
        {
            binaryNumber.Insert(0, decimalNumber % 2);
            decimalNumber /= 2;
        }

        Console.WriteLine($"The binary equivalent is: {binaryNumber}");
    }
}
