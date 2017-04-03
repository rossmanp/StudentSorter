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
            int students = 1;
            Console.WriteLine("Welcome to the Student Scores Application!");
            Console.WriteLine("\nEnter number of students: ");
            int.TryParse(Console.ReadLine(), out students);
            Student[] list = new Student[students];
            for (int i = 0; i < students; i++)
            {
                Console.Write("\nStudent " + (i + 1) + " last name: ");
                string lastName = Console.ReadLine();
                Console.Write("\nStudent " + (i + 1) + " first name: ");
                string firstName = Console.ReadLine();
                Console.Write("\nStudent " + (i + 1) + " score: ");
                int score = int.Parse(Console.ReadLine());
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
