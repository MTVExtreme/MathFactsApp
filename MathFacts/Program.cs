using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFacts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Math Facts App";
            int choice = 0;
            Addition addTable = new Addition();
            Multiply multTable = new Multiply();
            do
            {
                AppTitle();
                choice = MainMenu();
                //TODO - HAndle Addition CHoice
                if (choice == 1)
                {
                    bool continueChoice = true;
                    int startNum = 0;
                    int endNum = 0;
                    do
                    {
                        RunAddition(addTable, ref continueChoice, ref startNum, ref endNum);
                    } while (continueChoice == true);

                    
                }

                if (choice == 2)
                {
                    bool continueChoice = true;
                    int startNum = 0;
                    int endNum = 0;
                    do
                    {
                        RunMult(multTable, ref continueChoice, ref startNum, ref endNum);
                    } while (continueChoice == true);
                }

            } while (choice != 3);
        }

        private static void RunAddition(Addition addTable, ref bool continueChoice, ref int startNum, ref int endNum)
        {
            addTable.AdditionTable();
            try
            {
                Console.WriteLine("Enter your starting number: ");
                startNum = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter your ending number: ");
                endNum = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number");
                Console.ReadLine();

            }
            finally
            {
                //TODO validate
                if (startNum > 0 && endNum <= 10)
                {
                    addTable.AdditionTable();
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Your addition table for {0} - {1}", startNum, endNum);
                    addTable.AdditionSheet(startNum, endNum);

                    Console.WriteLine("");
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Would you like more additions facts [y/n]");
                        Console.ForegroundColor = ConsoleColor.White;
                        string moreFacts = Console.ReadLine();
                        if (moreFacts == "y")
                        {
                            continueChoice = true;

                        }
                        else if (moreFacts == "n")
                        {
                            continueChoice = false;
                        }

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }


                //handle addtiion table
                //logic to allow contine/end additions
            }
        }

        private static void RunMult(Multiply multTable, ref bool continueChoice, ref int startNum, ref int endNum)
        {
            multTable.MultTable();
            try
            {
                Console.WriteLine("Enter your starting number: ");
                startNum = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter your ending number: ");
                endNum = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number");
                Console.ReadLine();

            }
            finally
            {
                //TODO validate
                if (startNum > 0 && endNum <= 10)
                {
                    multTable.MultTable();
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Your addition table for {0} - {1}", startNum, endNum);
                    multTable.MultSheet(startNum, endNum);

                    Console.WriteLine("");
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Would you like more multiplication facts [y/n]");
                        Console.ForegroundColor = ConsoleColor.White;
                        string moreFacts = Console.ReadLine();
                        if (moreFacts == "y")
                        {
                            continueChoice = true;

                        }
                        else if (moreFacts == "n")
                        {
                            continueChoice = false;
                        }

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }


                //handle addtiion table
                //logic to allow contine/end additions
            }
        }

        private static int MainMenu()
        {
            int choice;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Option 1: Addition Facts");
            Console.WriteLine("Option 2: Multiplication Facts");
            Console.WriteLine("Option 3 Exit Program");
            //TODO - Fic Exception handleing
            choice = Int32.Parse(Console.ReadLine());
            return choice;
        }

        private static void AppTitle()
        {
            Console.Clear();
            string appTitle = @"
 __  __       _   _       _____          _            _                
|  \/  | __ _| |_| |__   |  ___|_ _  ___| |_ ____    / \   _ __  _ __  
| |\/| |/ _` | __| '_ \  | |_ / _` |/ __| __|_  /   / _ \ | '_ \| '_ \ 
| |  | | (_| | |_| | | | |  _| (_| | (__| |_ / /   / ___ \| |_) | |_) |
|_|  |_|\__,_|\__|_| |_| |_|  \__,_|\___|\__/___| /_/   \_\ .__/| .__/ 
                                                          |_|   |_|    ";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(appTitle);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
