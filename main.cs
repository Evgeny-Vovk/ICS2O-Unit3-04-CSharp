// Created by: Evgeny
// Created on: Mar 2022
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        //input
        float fahrenheit;

        Console.WriteLine("This program calculates celsius out of fahrenheit.");
        Console.WriteLine("");

        Console.Write("Enter the fahrenheit(°F): ");
        fahrenheit = Convert.ToInt32(Console.ReadLine());

        //process
        double celsius = (fahrenheit - 32) * 5 / 9;

        //output
        Console.WriteLine("");
        Console.WriteLine(fahrenheit + " fahrenheit is " + celsius.ToString("0.00") + " celsius.");

        Console.WriteLine("\nDone.");
    }
}