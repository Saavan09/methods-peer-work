/*

Names: Saavan Tandon and Shawn Tyson
Class: IGME 201.01 with Nick
Due date: Sunday October 13

*/

using System;
class Program 
{
    public static void Main(string[] args)
    {
        //Saavan's variable declarations
        int saavanFavNumber;
        int saavanLuckyNumber;

        //Shawn's variable declarations



        //Saavan's variable initializations
        saavanFavNumber = 8;
        saavanLuckyNumber = 9;

        //Shawn's variable initializations



        //start of program
        Console.WriteLine("Saavan's favorite number is " + saavanFavNumber + ", and his lucky number is " + saavanLuckyNumber + ".");


        //testing the functions
        int saavanAdd = Add(saavanFavNumber, saavanLuckyNumber);
        Console.WriteLine("Adding Saavan's numbers..." + saavanFavNumber + " + " + saavanLuckyNumber + " = " + saavanAdd);
        //adding shawn's numbers
        //subtracting saavan's numbers
        //subtracting shawn's numbers
    }

/// <summary>
/// Takes in 2 integers and returns the result of them added together
/// </summary>
/// <param name="num1">First integer</param>
/// <param name="num2">Second integer</param>
/// <returns>Integer equal to num1 + num2</returns>
    static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}