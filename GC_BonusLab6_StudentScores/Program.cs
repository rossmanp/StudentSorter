using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_BonusLab6_StudentScores
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Welcome to the Student Scores Application!");
            Console.WriteLine("\nEnter number of students: ");
            int students = Validator.getIntWithinRange(1, 100);           
            Student[] list = new Student[students];
            for (int i = 0; i < students; i++)
            {
                Console.Write("\nStudent " + (i + 1) + " last name: ");
                string lastName = Validator.getString(Console.ReadLine());
                Console.Write("\nStudent " + (i + 1) + " first name: ");
                string firstName = Validator.getString(Console.ReadLine());
                Console.Write("\nStudent " + (i + 1) + " score: ");
                int score = Validator.getIntWithinRange(1,100);
                list[i] = new Student(firstName, lastName, score);
            }
            foreach (Student s in list)
            {
                Console.WriteLine(s.LastName + ", " + s.FirstName + ": " + s.Score);
            }
            Console.ReadLine();
        }
    }
}
