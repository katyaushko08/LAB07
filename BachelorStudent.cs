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
            double scholarship, 
            double tuitionFee,
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
                Scholarship = AverageGrade >= 8.0 ? 250 :
                              (AverageGrade >= 6.0 ? 150 : 0);
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
