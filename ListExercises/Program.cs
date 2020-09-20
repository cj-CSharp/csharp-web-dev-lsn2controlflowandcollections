using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(sumEven(myList));

            string phrase = "I would not, could not, in a box. I would not, could not with a fox.";
            
            
            
            
            List<string> myListStrings = stringIntoList(phrase);
            Console.WriteLine("How many long of word would you like to find?");
            int numberOfLetters = int.Parse(Console.ReadLine());
            exactFiveLetters(myListStrings, numberOfLetters);
            

            
        }

        public static int sumEven (List<int> arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                if(i%2==0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        public static void exactFiveLetters(List<string> stringList, int numOfLetters)
        {
            foreach(string s in stringList)
            {
                if(s.Length == numOfLetters)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static List<string> stringIntoList(string s) 
        {
            string[] arrayString = s.Split(" ");
            List<string> stringList = new List<string>();
            foreach(string word in arrayString)
                {
                    stringList.Add(word);
                }
            return stringList;
        }
    }
}

