using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            
            List<double> grades = new List<double>();
            string newStudent;
            string input;


            int id = 0;
            // Get student names
            do
            {
                
                Console.WriteLine("Enter your students name (or ENTER to finish):");
                input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    students.Add(id, newStudent);
                }
                id++;

            } while (!Equals(newStudent, ""));

            // Get student grades
            

            // Print class roster
            Console.WriteLine("\nClass roster:");
            double sum = 0.0;

            foreach (KeyValuePair<int, string> student in students)                
            {
                Console.WriteLine(student.Key + " : " + student.Value);
                
            }

        }
    }
}
