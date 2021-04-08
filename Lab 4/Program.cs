using System;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopProgram = true;
            while (true)
            {

                Console.WriteLine("Please enter an integer");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Number      Squared       Cubed");
                Console.WriteLine("-------------------------------");
                CountUp(x);
                Console.WriteLine("Would you like to see another table? y/n");
                string answer = Console.ReadLine();
                if (answer == "n")
                {
                    loopProgram = false;
                    break;
                }
                if (answer == "y")
                {

                }
                else
                {
                    Console.WriteLine("Invalid input");

                }
            }




        }





        static void CountUp(int x)
        {
            for (int i = 1; i <= x; i++)
            {

                Console.WriteLine($" {i}  {Squared(i)}  {Cuber(i)}");

            }
        }

        static int getInput()
        {


            Console.WriteLine("Please enter an integer");
            int input = int.Parse(Console.ReadLine());
            return input; ;
        }

        static int Cuber(int x)
        {
            return x * x * x;

        }

        static int Squared(int x)
        {
            return x * x;
        }
    }
}
