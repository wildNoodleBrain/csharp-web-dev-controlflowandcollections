﻿using System;
using System.Collections.Generic;

namespace ListGradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            List<double> grades = new List<double>();
            List<string> planets = new List<string>();
            string newStudent;
            string input;
            string[] planetsArray = planets.ToArray();

            Console.WriteLine("Enter your students (or ENTER to finish):");

            // Get student names
            do
            {
                input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    students.Add(newStudent);
                }

            } while (!Equals(newStudent, ""));

            // Get student grades
            foreach (string student in students)
            {
                Console.WriteLine("Grade for " + student + ": ");
                input = Console.ReadLine();
                double grade = Double.Parse(input);
                grades.Add(grade);
            }

            // Print class roster
            Console.WriteLine("\nClass roster:");
            double sum = 0.0;

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i] + " (" + grades[i] + ")");
                sum += grades[i];
            }

            double avg = sum / students.Count;
            Console.WriteLine("Average grade: " + avg);

            planets.Add("Mercury");
            planets.Add("Venus");
            planets.Add("Earth");
            planets.Add("Mars");
            planets.Add("Jupiter");
            planets.Add("Saturn");
            planets.Add("Uranus");
            planets.Add("Neptune");
        }
    }
}
