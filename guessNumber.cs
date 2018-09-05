using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp6
{
    class Program
    {
       /* the method of guess number,  program generates a number randomly,
           user input a number,
        */
        static void GuessNumber()
        {
            // program generates a number randomly,from 0-100
            Random randNumber = new Random();
            Int32 Number = randNumber.Next(0, 100);
            Console.WriteLine(Number);
            //the number of user input
            Int32 num = Convert.ToInt32(Console.ReadLine());
            //compare two numbers
            while (num != Number)
            {
                if (num > Number)
                {
                    Console.WriteLine("your input number is higher!");

                }
                else if (num < Number)
                {
                    Console.WriteLine("your input number is lowwer!");

                }
                //Console.WriteLine("again!");
                          num = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("your input number is " + num);
        }


        //the second method of guess number
        static void GuessNumberApp()
        {
            int minNum = 0;
            int maxNum = 10;


            // Console.WriteLine(Number);
            Console.WriteLine("Would you like to play the higher / lower game ? (Yes / No)");
            string input = Console.ReadLine();
            if (input == "Y")
            {
                Console.WriteLine("Okay");
                Console.WriteLine("Please pick a number");
                int numInput = Convert.ToInt32(Console.ReadLine()); //the number of user pick  
                while (input != "N")
                {

                    Random randNumber = new Random();
                    int Number = randNumber.Next(minNum, maxNum);// the profram output the number
                    Console.WriteLine(" Is your number higher or lower than " + Number + "? (Higher/Lower/Correct)");
                    input = Console.ReadLine();
                    //numbrt > input,
                    if (input == "H")
                    {
                        minNum = Number;
                        Console.WriteLine("min:" + minNum + "," + "max" + maxNum);
                    }
                    else if (input == "L")
                    {
                        maxNum = Number;
                        Console.WriteLine("min:" + minNum + "," + "max" + maxNum);
                    }
                    else if (input == "C")
                    {
                        Console.WriteLine("Great!I guessed your number.Would you like to play again? (Yes / No)");
                        input = Console.ReadLine();
                        if (input == "Y")
                        {
                            continue;
                        }
                        else if (input == "N")
                        {
                            Console.WriteLine("- Program Quits -");
                            break;
                        }
                    }


                }
            }

        }



            static void Main(string[] args)
        {
            // GuessNumber();
            GuessNumberApp();
            Console.ReadKey();

           
        }
        
    }
}
