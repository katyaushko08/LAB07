using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07
{
    public class BachelorStudent : Student
    {
        public string Group {  get; set; }
        public string Direction { get; set; }

        public BachelorStudent(
            string name, 
            int age, 
            int course, 
            string studyForm, 
            double averageGrade, 
            decimal scholarship, 
            decimal tuitionFee,
            string group,
            string direction
            ) : base (name, age, course, studyForm, averageGrade, scholarship, tuitionFee)
        {
            Group = group;
            Direction = direction;
        }

        public override void RecalculatePayments()
        {
            base.RecalculatePayments();
            if (StudyForm == "Бюджет")
            {
                if (AverageGrade >= 8.0)
                {
                    Scholarship = 250m;
                }
                else if (AverageGrade >= 6.0) 
                {
                    Scholarship = 150m;
                }
                else
                {
                    Scholarship = 0m;
                }

            }
        }

        public override void TransferToNextCourse()
        {
            if(Course < 4)
            {
                Course++;
                Console.WriteLine($"{Name} переведен(a) на {Course} курс.");
            }
            else
            {
                Console.WriteLine($"{Name} закончил(a) бакалавриат.");
            }
        }

        public int GetStudyDuration()
        {
            return 4;           
        }

        public override string ToString()
        {
            return base.ToString() + $", Группа: {Group}, Направление: {Direction}";
        }
    }
}
