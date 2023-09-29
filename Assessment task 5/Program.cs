using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Prompt the user to enter marks for various subjects
                Console.WriteLine("Enter marks for the following subjects (out of 100):");

                // Read and store the marks for Math
                Console.Write("Maths: ");
                double mathmarks = double.Parse(Console.ReadLine());

                // Read and store the marks for Physics
                Console.Write("Physics: ");
                double physicsmarks = double.Parse(Console.ReadLine());

                // Read and store the marks for Chemistry
                Console.Write("Chemistry: ");
                double chemistrymarks = double.Parse(Console.ReadLine());

                // Read and store the marks for Computer Science
                Console.Write("Computer Science: ");
                double computersciencemarks = double.Parse(Console.ReadLine());

                // Create a new 'Student' object with subject marks
                var student = new Student
                {
                    MathMarks = mathmarks,
                    PhysicsMarks = physicsmarks,
                    ChemistryMarks = chemistrymarks,
                    ComputerScienceMarks = computersciencemarks
                };

                // Calculate the average marks for the student
                double average = student.calculateaverage();

                // Calculate the grade based on the average marks
                char grade = student.calculategrade();

                // Get remarks based on the grade
                string remarks = student.getremarks();

                // Display the average marks, grade, and remarks
                Console.WriteLine("Average Marks: " + average);
                Console.WriteLine("Grade: " + grade);
                Console.WriteLine(remarks);
            }
            catch (Exception ex)
            {
                // Handle exceptions, if any, and display an error message
                Console.WriteLine("Error: " + ex.Message);
            }

            // Wait for user input (e.g., pressing a key) before exiting
            Console.ReadKey();
        }
    }
}
