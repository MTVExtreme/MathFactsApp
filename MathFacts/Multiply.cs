using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFacts
{
    class Multiply
    {
        public void MultTable()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            string appTitle = @"
 __       __            __    __      __            __  __                        __      __                     
|  \     /  \          |  \  |  \    |  \          |  \|  \                      |  \    |  \                    
| $$\   /  $$ __    __ | $$ _| $$_    \$$  ______  | $$ \$$  _______   ______   _| $$_    \$$  ______   _______  
| $$$\ /  $$$|  \  |  \| $$|   $$ \  |  \ /      \ | $$|  \ /       \ |      \ |   $$ \  |  \ /      \ |       \ 
| $$$$\  $$$$| $$  | $$| $$ \$$$$$$  | $$|  $$$$$$\| $$| $$|  $$$$$$$  \$$$$$$\ \$$$$$$  | $$|  $$$$$$\| $$$$$$$\
| $$\$$ $$ $$| $$  | $$| $$  | $$ __ | $$| $$  | $$| $$| $$| $$       /      $$  | $$ __ | $$| $$  | $$| $$  | $$
| $$ \$$$| $$| $$__/ $$| $$  | $$|  \| $$| $$__/ $$| $$| $$| $$_____ |  $$$$$$$  | $$|  \| $$| $$__/ $$| $$  | $$
| $$  \$ | $$ \$$    $$| $$   \$$  $$| $$| $$    $$| $$| $$ \$$     \ \$$    $$   \$$  $$| $$ \$$    $$| $$  | $$
 \$$      \$$  \$$$$$$  \$$    \$$$$  \$$| $$$$$$$  \$$ \$$  \$$$$$$$  \$$$$$$$    \$$$$  \$$  \$$$$$$  \$$   \$$
                                         | $$                                                                    
                                         | $$                                                                    
                                          \$$                                                                    ";
            Console.WriteLine(appTitle);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You Will be able to sleect numbers 1 - 10");
            Console.WriteLine("Next you will see the numbers between these selections be added");
            Console.WriteLine(" to numbrrs 1 - 10");
            Console.WriteLine("");
            Console.WriteLine("Select a starting number 1 and 10");
        }

        public void MultSheet(int startNum, int endNum)
        {
            for (int i = startNum - 1; i <= endNum; i++)
            {
                if (i == startNum - 1)
                {
                    Console.Write(String.Format("{0, 6}", "n"));
                }
                else
                {
                    Console.Write(String.Format("{0, 6}", i));
                }
            }
            Console.WriteLine("\n");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(String.Format("{0, 6}", i));
                for (int n = startNum; n <= endNum; n++)
                {
                    string output = String.Format("{0, 6}", i * n);
                    Console.Write(output);
                }
                Console.WriteLine("");


            }
            Console.ReadLine();

        }
    }
}

