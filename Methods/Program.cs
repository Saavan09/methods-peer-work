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
        int shawnFavNumber;
        int shawnLuckyNumber;

        //Saavan's variable initializations
        saavanFavNumber = 8;
        saavanLuckyNumber = 9;

        //Shawn's variable initializations
        shawnFavNumber = 43;
        shawnLuckyNumber = 7;

        ///Subtraction function
        ///Takes in 2 integer parameters
        ///Subtracts the 2nd value from the 1st parameter given
        int Subtract(int x, int y){
            return (x - y);
        }

        //start of program
        Console.WriteLine("Saavan's favorite number is " + saavanFavNumber + ", and his lucky number is " + saavanLuckyNumber + ".");
        Console.WriteLine("Shawn's favorite number is " + shawnFavNumber + ", and his lucky number is " + shawnLuckyNumber + ".");


        //testing the functions
        int saavanAdd = Add(saavanFavNumber, saavanLuckyNumber);
        int shawnSubtract = Subtract(shawnFavNumber, shawnLuckyNumber);
        Console.WriteLine("Adding Saavan's numbers..." + saavanFavNumber + " + " + saavanLuckyNumber + " = " + saavanAdd);
        //adding shawn's numbers
        Console.WriteLine("Adding Shawn's numbers..." + shawnFavNumber + " + " + shawnLuckyNumber + " = " + saavanAdd);
        //subtracting saavan's numbers

        //subtracting shawn's numbers
        Console.WriteLine("Subtracting Shawn's numbers..." + shawnFavNumber + " - " + shawnLuckyNumber + " = " + shawnSubtract);

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