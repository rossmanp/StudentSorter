using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_BonusLab6_StudentScores
{
    public class Student : IComparable<Student>
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public int Score { set; get; }

        public Student()
        {

        }

        public Student (string firstName, string lastName, int score)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Score = score;
        }

        public int CompareTo(Student other)
        {
            return this.LastName.CompareTo(other.LastName);
        }
    }
}
