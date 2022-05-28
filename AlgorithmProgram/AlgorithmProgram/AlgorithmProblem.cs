using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class AlgorithmProblem
    {
        public void Insert()
        {
            string[] names = { "Yogesh", "Ganesh", "Nitin", "Madhav", "Arjun" };
            InsertSort(names);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
        public static void InsertSort(IComparable[] array)
        {
            int i, j;
            for (i = 1; i < array.Length; i++)
            {
                IComparable value = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = value;
            }
        }
        public static void Bubblesort()
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            int temp;
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - j - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                        Console.WriteLine("Sorted:");
                        foreach (int p in arr)
                            Console.WriteLine(p + " ");
                        Console.ReadKey();
                    }
                }
            }
        }
        public static void Anagrams()
        {
            Console.Write("Enter First word:");
            string wordOne = Console.ReadLine();
            Console.Write("Enter Second word:");
            string wordTwo = Console.ReadLine();

            char[] charOne = wordOne.ToLower().ToCharArray();
            char[] charTwo = wordTwo.ToLower().ToCharArray();
            Array.Sort(charOne);
            Array.Sort(charTwo);

            string NewWordOne = new string(charOne);
            string NewWordTwo = new string(charTwo);
            if (NewWordOne == NewWordTwo)
            {
                Console.WriteLine("Yes! Words are Anagrams", NewWordOne, NewWordTwo);
            }
            else
            {
                Console.WriteLine("No! Words are not Anagrams", NewWordOne, NewWordTwo);
            }
        }
        public void Primenumber()
        {
            int num, Start, End, flag;
            Console.WriteLine("Enter a Range for Prime number ");
            Console.WriteLine("Enter a Start value");
            Start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a End value");
            End = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Prime numbers in between {0} to {1} are : \n", Start, End);

            for (num = Start; num <= End; num++)
            {
                flag = 0;
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
        }
    }
}