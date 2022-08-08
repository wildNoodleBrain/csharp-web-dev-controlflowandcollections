using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I better get used to Lists");

            Console.WriteLine(FindSum(new List<int> { 1, 1, 2, 3, 5, 8 }));

            List<string> wordsList = new List<string> { "green", "blue", "purple", "yellow", "pink", "mauve", "periwinkle", "black", "orange", "red" };
            printFiveLetterWords(wordsList);
            
            // List<int> evenNums = new List<int>() { 1, 1, 2, 3, 5, 8 };

           /* for (int i = 0; i < evenNums.Count; i++)
            {
                if(int % 2 != 0);
                Console.WriteLine(evenNums[i]);*/
            }
        static int FindSum(List<int> nums)
        {
            int sum = 0;
            foreach (int x in nums)
            {
                if(x % 2 == 0) { sum+= x; }
            }
            return sum;
        }
        static void printFiveLetterWords(List<string> words)
        {
            Console.Write("Enter a number: ");
            int numberOfLetters = int.Parse(Console.ReadLine());
            foreach (string word in words)
            {
                if (word.Length == numberOfLetters)
                {
                    System.Console.WriteLine(word);
                }
            }
        }
           }
          /// 
        }
    
/* 1. Write a static method to find the sum of all the even numbers in a List.
2. Within Main, create a list with at least 10 integers and call your method on the list.
3. Write a static method to print out each word in a list that has exactly 5 letters.
4. Modify your code to prompt the user to enter the word length for the search.*/
