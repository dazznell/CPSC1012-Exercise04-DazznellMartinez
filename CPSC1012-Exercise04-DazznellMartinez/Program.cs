/*  Purpose:            This program is a "fool-proof" menu-driven math quiz program that allows the user to select the type of math questions they want.
 *  
 *  Input:              mathChoice = (a = addition,
 *                                s = subraction,
 *                                m = multiplication,
 *                                d = division, 
 *                                or x = exit program)
 *                      mathAnswer
 *                      tryAgain (y/n)
 *  
 *  Process:            - Display welcome message and options users can choose from
 *                      - Create random numbers
 *                      - Prompt user for choice and read
 *                      - Calculate sum of two numbers for user to answer
 *                      - Prompt user for mathAnswer and display result
 *                            i - if incorrect, allow user to try again
 *                            ii - if correct, display "Correct!" message 
 *                            iii - Display welcome message and options user can choose from
 *                            iv - Prompt user for choice and read
 *                            v - if user chooses x, program will end and display message "Thank you for taking the quiz! 
 *                     
 *                      
 *  
 *  Output:             Correct! 
 *                      Incorrect! Would you like to try again? (y/n)
 * 
 *  ---------------------------------------------------------------------------
 *  
 *  Author:             Dazznell Martinez
 *  Last Modified:      Feb 25, 2021
 * 
 * 
 */

using System;

namespace CPSC1012_Exercise04_DazznellMartinez
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare all the variables, inputs and outputs
            string mathChoice;  // Which type of math question user will choose
            int correctAnswer;  // Math correct answer
            int userAnswer;     // Answer the user will input 
            string repeat;    // User can choose to try question again if incorrect answer previously


            // Create random numbers for the calculation
            Random keygen = new Random();
            int number1 = keygen.Next(1, 101);
            int number2 = keygen.Next(1, 101);


            // Display welcome message and options users can choose from
            Console.WriteLine("Math Quiz");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("a) Addition");
            Console.WriteLine("s) Subtraction");
            Console.WriteLine("m) Multiplication");
            Console.WriteLine("d) Division");
            Console.WriteLine("x) Exit Program");

            Console.WriteLine();

            // Prompt user for their choice of math question and read
            Console.WriteLine("Enter a letter for your choice: ");
            mathChoice = Console.ReadLine();

            Console.WriteLine();

            // Execute calculation and prompt user for their answer
            switch (mathChoice)
            {
                /**======================================================*/

                case "a":
                    // Addition
                    correctAnswer = number1 + number2;

                    // Promt user for answer
                    Console.WriteLine($"What is {number1} + {number2}?");
                    userAnswer = int.Parse(Console.ReadLine());

                    // Determine if user is correct or not
                    while(userAnswer != correctAnswer)
                    {
                        // Allow user to try again
                        Console.WriteLine("Incorrect. Try again (y/n)?");
                        repeat = Console.ReadLine();

                        while(repeat == "y" || repeat == "Y") // Answer yes to try again
                        {
                            Console.WriteLine($"What is {number1} + {number2}?");
                            userAnswer = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            if (userAnswer == correctAnswer) // if users answer matches correct answer
                            {
                                Console.WriteLine("Correct Answer!");
                            }
                            Console.WriteLine("That's incorrect.");
                        }
                        Console.WriteLine();  
                    }
                    Console.WriteLine("Correct!");

                    return;

                /**======================================================*/

                case "s":
                    // Subtraction
                    correctAnswer = number1 - number2;

                    // Prompt user
                    Console.WriteLine($"What is {number1} - {number2}?");
                    userAnswer = int.Parse(Console.ReadLine());

                    // Determine if user is correct or not
                    while (userAnswer != correctAnswer)
                    {
                        // Allow user to try again
                        Console.WriteLine("Incorrect. Try again (y/n)?");
                        repeat = Console.ReadLine();

                        while (repeat == "y" || repeat == "Y") // Answer yes to try again
                        {
                            Console.WriteLine($"What is {number1} - {number2}?");
                            userAnswer = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            if (userAnswer == correctAnswer)
                            {
                                Console.WriteLine("Correct Answer!");
                            }
                            Console.WriteLine("That's incorrect.");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Correct!");

                    
                    return;


               /**======================================================*/

                case "m":
                    // Multiply
                    correctAnswer = number1 * number2;

                    // Prompt user for their answer
                    Console.WriteLine($"What is {number1} x {number2}?");
                    userAnswer = int.Parse(Console.ReadLine());

                    // Determine if user is correct or not
                    while (userAnswer != correctAnswer)
                    {
                        Console.WriteLine("Incorrect. Try again (y/n)?");
                        repeat = Console.ReadLine();

                        while (repeat == "y" || repeat == "Y") // Answer yes if user wants to try again
                        {
                            Console.WriteLine($"What is {number1} x {number2}?");
                            userAnswer = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            if (userAnswer == correctAnswer)
                            {
                                Console.WriteLine("Correct Answer!");
                            }
                            Console.WriteLine("That's incorrect.");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Correct!");

                    
                    return;


                /**======================================================*/

                case "d":
                    // Division
                    correctAnswer = number1 / number2;

                    // Prompt the user for their answer
                    Console.WriteLine($"What is {number1} / {number2}?");
                    userAnswer = int.Parse(Console.ReadLine());

                    // Determine if user is correct or not
                    while (userAnswer != correctAnswer)
                    {
                        Console.WriteLine("Incorrect. Try again (y/n)?");
                        repeat = Console.ReadLine();

                        while (repeat == "y" || repeat == "Y") // Answer yes if user wants to try again
                        {
                            Console.WriteLine($"What is {number1} / {number2}?");
                            userAnswer = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            if (userAnswer == correctAnswer) // if user gets correct answer
                            {
                                Console.WriteLine("Correct Answer!");
                            }
                            Console.WriteLine("That's incorrect.");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Correct!");

                    return;


                /**======================================================*/

                case "x": // Stops program
                    return;


                /**======================================================*/
                default:
                    Console.WriteLine("Invalid entry. Please try again.");
                    return;
            }
        }
    }
}
