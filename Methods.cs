using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    internal class Methods
    {

        //public static void NegetiveCount()
        //  {
        //      var count = -1000;
        //      for (var i = 1000; i >= count; i--)
        //      {
        //          Console.WriteLine(i);
        //      }
        //  }



        //public static void CountBy3()
        //{
        //    var threes = 3;
        //    while(threes < 999)
        //    {
        //        threes+=3;
        //        Console.WriteLine(threes);

        //    }

        //}






        //public static void EqualInts()
        //{
        //    Console.WriteLine("Please enter a number");
        //    var firstNum = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Please enter a second number");
        //    var secondNum = int.Parse(Console.ReadLine());
        //    while (firstNum != secondNum)
        //    {
        //        Console.WriteLine($"{firstNum} and {secondNum} are not equal");
        //        break;
        //    }
        //    while (firstNum == secondNum)
        //    {
        //        Console.WriteLine($"{firstNum} and {secondNum} are equal");

        //    }

        //}





        //public static void EvenOrOdd()
        //{
        //    Console.WriteLine("Please enter a number for evaluation");
        //    var userIn = int.Parse(Console.ReadLine());
        //    if (userIn % 2 != 0)                                                        //< -----------------Needs Work
        //    {
        //        Console.WriteLine("Your number is determined to be odd");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Your number has been determined to be even");
        //    }
        //}







        //public static void PositiveOrNegetive()
        //{
        //    Console.WriteLine("What is your chosen number");
        //    var randomInput = int.Parse(Console.ReadLine());
        //    if (randomInput < 0)
        //    {
        //        Console.WriteLine($"{randomInput} is a negetive number.");

        //    }
        //    else
        //    {
        //        Console.WriteLine($"{randomInput} is a poitive number.");
        //    }
        //}





        //public static void CanYouVote()
        //{
        //    Console.WriteLine("How old are you");
        //    var age = int.Parse(Console.ReadLine());
        //    if (age >= 18)
        //    {
        //        Console.WriteLine("You are allowed to vote");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Sorry kiddo, not today");
        //    }
        //}





        //public static void RangeCheck()
        //{
        //    Console.WriteLine("Enter a number between 10 and -10");
        //    var wrongNum = int.Parse(Console.ReadLine());
        //    while (wrongNum > -11 && wrongNum < 11)
        //    {
        //        Console.WriteLine($"{wrongNum} is within good range");
        //        break;
        //    }
        //    if (wrongNum > 10 && wrongNum > -10)
        //    {
        //        Console.WriteLine($"{wrongNum} is not within range. You lost");
        //    }
        //}




        public static void TablesForDays()
        {
            Console.WriteLine("Please enter a number you want to see Muliplied by 1 - 12");
            var anotherNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($" {anotherNumber * 1} \n {anotherNumber * 2} multiplied by 2 \n {anotherNumber * 3} multiplied by 3 \n " +
                               $" {anotherNumber * 4} multiplied by 4 \n {anotherNumber * 5} multiplied by 5 \n {anotherNumber * 6} multiplied by 6 \n" +
                                $" {anotherNumber * 7} Multiplied by 7 \n {anotherNumber * 8} Multiplied by 8 \n {anotherNumber * 9 } Multiplied by 9 \n"  +
                               $" {anotherNumber * 10} multiplied by 10 \n {anotherNumber * 11} Multiplied by 11 \n {anotherNumber * 12} multiplied by 12");

        }













    }
}
