using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OddSum(IsOdd,5,10));
            Console.WriteLine(OddSum(i => i % 2 != 0,5,10));

            Func<string, string> print = StrNameInsert;
            Console.WriteLine(print("Gasimzada"));

            Action<string, string> words = FullName;
            words("Hikmet","Hikmetov");
            words("Rovshen", "Agayev");
        }

        public static bool IsOdd(int i)
        {
            return i % 2 != 0;
        }
        // Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapan metod
        public static int OddSum(Predicate<int>func,int n,int m)
        {
            int sum = 0;
            if (n < 1 || m < 1)
            {
                Console.WriteLine("Enter the correct number");
            }
            else
            {
                for (int i = n; i < m; i++)
                {
                    if (func(i))
                    {
                        sum += i;
                    }
                }
            }
            return sum;
        }
        public static string StrNameInsert(string str)
        {
            return str.Insert(0,"Rashad ");
        }
        public static void FullName (string name,string surname)
        {
            Console.WriteLine($"{name} {surname}");
        }
    }
}
