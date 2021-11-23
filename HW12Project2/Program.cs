/// Homework No. 12 Lab No. 1
/// File Name : Program.cs
/// @author : Joshua Um
/// Date : November 15 2021
/// 
/// Problem Statement : Create a test programs that uses optional parameters, named parameter and variable number of parameters.
/// 
/// Plan:
/// 1. Call optionalFunction() with no params passed to test default value of function.
/// 2. Call namedFunctions() with named params passed to test the named parameters.
/// 3. Call variableFunction() with n amount of parms passed to test the variable # of parameters.



using System;

namespace HW12Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(optionalFunction());

            namedFunction(name: "joe", a: 10, b: 4.23);

            Console.WriteLine(variableFunction(1,2,3,4,5,6,7,8,9,19,21));

        }


        static int optionalFunction(int number = 21)
        {
            return number * 2;
        }

        static void namedFunction(int a , string name, double b)
        {
            Console.WriteLine(name + " " + a * b);
        }

        static int variableFunction(params int[] numbers)
        {
            int acc = 0;
            foreach(int number in numbers)
            {
                acc += number;
            }
            return acc;
        }



    }
}
