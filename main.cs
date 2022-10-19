// Created by: Claire Bedrossian
// Created on: Sep 2022
//
// This program calculates someones pay and tax deductions

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        float wage;
        float hours;
        float totalDeductions;
        float grossPay;
        float netPay;
        const float TAX_RATE = 0.18f;

        Console.WriteLine("This program calculates the area and perimeter of a triangle.");
        Console.WriteLine("");
        Console.Write("Enter your hourly wage ($): ");
        wage = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter the amount of hours you worked (h): ");
        hours = Convert.ToSingle(Console.ReadLine());

        grossPay = hours * wage;
        totalDeductions = TAX_RATE * grossPay;
        netPay = grossPay - totalDeductions;

        Console.WriteLine("");
      
        Console.WriteLine("Your total pay will be " + netPay.ToString("0.00") + ".");
        Console.WriteLine("The government will take " + totalDeductions.ToString("0.00") + ".");

        Console.WriteLine("\nDone.");
    }
}
      
