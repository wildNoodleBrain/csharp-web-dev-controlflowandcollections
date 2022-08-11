using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            while (true)
            {
                Console.WriteLine("Enter Student Name: ");
                string studentName = Console.ReadLine();
                if (studentName == "")
                {
                    Console.WriteLine("input ended.");
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Student ID: ");
                    int studentID = int.Parse(Console.ReadLine());
                    students.Add(studentName, studentID);

                }
            }
            foreach (string studentName in students.Keys)
            {
                Console.WriteLine($"{studentName}: {students[studentName]}");
            }
        }                
    }
}
