using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Arrays!");
            int[] numbers = {1, 1, 2, 3, 5, 8};
            foreach(int i in numbers) {
                if(i%2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
