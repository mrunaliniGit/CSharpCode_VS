using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hellooooo!");
            int value=AddInts(3,2);
            Console.WriteLine(value);
            Console.WriteLine(IsOdd(5));
        }

        public static int AddInts(int x, int y){
            return x+y;
        }

        public static bool IsOdd(int a){
            //if(a%2==0)
            //return false;
            //return true;
            return a % 2 == 1;
        }
    }
}
