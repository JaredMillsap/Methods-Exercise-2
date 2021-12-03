using System;

namespace Methods_Ecercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a variable
            string random;

            //Initialize it
            random = "2000";



            // Opporators

            int x = 101;
            int y = 100;
            int answer = x / y;
            Console.WriteLine(answer);

            //Selection Statements

            string mystring = "Hello";

            if (mystring != "Hello")
            {
                Console.WriteLine("the expression evaluated to true");
            }
            else
            {
                Console.WriteLine("the expression is evauated to be false");

            }



            int num1 = 2;
            int num2 = 1;

            if (num1 % 2 == 0)
            {
                Console.WriteLine("Is even");
            }
            else
            {
                Console.WriteLine("Is odd");
            }

            int a = 20;
            int b = 30;




            Console.WriteLine("Please enter a value for string 1?");
            string userInput = Console.ReadLine();


           
                
















        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int x, int y)
        {
            return  x * y;
        }


        



        


        

      

    






    }
}
