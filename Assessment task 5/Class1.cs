using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_task_5
{
    class Student
    {
        // Properties to store subject marks
        public double MathMarks { get; set; }
        public double PhysicsMarks { get; set; }
        public double ChemistryMarks { get; set; }
        public double ComputerScienceMarks { get; set; }

        // Method to calculate the average marks
        public double calculateaverage()
        {
            // Calculate the average by summing all subject marks and dividing by the number of subjects
            return (MathMarks + PhysicsMarks + ChemistryMarks + ComputerScienceMarks) / 4;
        }

        // Method to calculate the grade based on the average marks
        public char calculategrade()
        {
            // Calculate the average marks
            double average = calculateaverage();

            // Determine the grade based on the average marks
            if (average >= 80)
                return 'A';
            else if (average >= 70)
                return 'B';
            else if (average >= 60)
                return 'C';
            else if (average >= 50)
                return 'D';
            else
                return 'F';
        }

        // Method to get remarks based on the grade
        public string getremarks()
        {
            // Calculate the grade
            char grade = calculategrade();

            // Provide remarks based on the grade using a switch statement
            switch (grade)
            {
                case 'A':
                    return "Your grade is A";
                case 'B':
                    return "Your grade is B";
                case 'C':
                    return "Your grade is C";
                case 'D':
                    return "Your grade is D";
                case 'F':
                    return "Your grade is F";
                default:
                    return "Invalid grade";
            }
        }
    }
}

