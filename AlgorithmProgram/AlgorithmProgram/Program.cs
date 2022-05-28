using System;

namespace AlgorithmProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome in Alogrithm Program");
            int Input;
            do
            {
                Console.WriteLine("\n1:For InsertionSort");                
                Console.WriteLine("0: For Exit Program");
                Input = int.Parse(Console.ReadLine());
                switch (Input)
                {
                    case 1:
                        AlgorithmProblem insertionSort = new AlgorithmProblem();
                        insertionSort.Insert();
                        break;                   
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Input is Invalid");
                        break;
                }
            }
            while (Input != 0);            
        }

    }
}