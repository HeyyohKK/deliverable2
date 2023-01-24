/*
 Author: Kyle Kettles
 Date: 1/24/23
 Descript: Console app to calc letter grades
*/

using System;

namespace deliverable_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numeric grade:");

            try
            {
                int grade = int.Parse(Console.ReadLine());

                string letter;
                if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your ISM 4300 Grade is: " + letter);
                }

                else if (grade >= 80 && grade < 90)
                {
                    letter = "B";
                    Console.WriteLine("Your ISM 4300 Grade is: " + letter);
                }
                else if (grade >= 70 && grade < 80)
                {
                    letter = "C";
                    Console.WriteLine("Your ISM 4300 Grade is: " + letter);
                }
                else if (grade >= 60 && grade < 70)
                {
                    letter = "D";
                    Console.WriteLine("Your ISM 4300 Grade is: " + letter);
                }
                else
                {
                    letter = "F";
                    Console.WriteLine("Your ISM 4300 Grade is: " + letter);
                }
            }           
            catch
            {
                Console.WriteLine("Enter a numeric grade:");
            }


        }
    }
}
