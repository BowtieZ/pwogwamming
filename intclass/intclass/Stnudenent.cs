using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intclass
{
    class Stnudenent
    {
        //properties
        int studentID;
        String name;
        double contentGrade;
        double workHabitGrade;
        double participation;
        int age;

        //constructors
        public Stnudenent(String Name, int ID, int Age)
        {
            name = Name;
            studentID = ID;
            age = Age;
            contentGrade = 0;
            workHabitGrade = 0;
            participation = 0;
        }
        public Stnudenent()
        {
            name = "Test Student";
            studentID = -1;
            contentGrade = 0;
            workHabitGrade = 0;
            participation = 0;
            age = 18;
        }

        //methoods
        public void SetContentGrade(int grade)
        {
            contentGrade = grade;
        }
        public void SetWorkHabitGrade(int grade)
        {
            workHabitGrade = grade;
        }
        public void SetParticipation(int grade)
        {
            participation = grade;
        }
        public double GetGrade ()
        {
           double overallGrade =  .35 * workHabitGrade + .4 * contentGrade + .25 * participation;
            return overallGrade;
        }
        public void PrintGrade()
        {
            Console.WriteLine(GetGrade());
        }
    }
}
