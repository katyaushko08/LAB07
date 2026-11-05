using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07
{
    public class MasterStudent : Student
    {
        public string Program { get; set; }
        public string ResearchTopic { get; set; }

        public MasterStudent(
            string name,
            int age,
            int course,
            string studyForm,
            double averageGrade,
            double scholarship,
            double tuitionFee,
            string program,
            string researchTopic
            ) : base(name, age, course, studyForm, averageGrade, scholarship, tuitionFee)
        {
            Program = program;
            ResearchTopic = researchTopic;
        }
        public override void RecalculatePayments()
        {
            base.RecalculatePayments();
            if (StudyForm == "Бюджет")
            {
                Scholarship = AverageGrade >= 8.0 ? 300 :
                              (AverageGrade >= 6.0 ? 180 : 0);
            }
        }

        public override void TransferToNextCourse()
        {
            if(Course < 2)
            {
                Course++;
                Console.WriteLine($"{Name} переведен(a) на {Course} курс. ");
            }
            else
            {
                Console.WriteLine($"{Name} закончил(a) магистратуру. ");
            }
        }

        public string GetResearchTopic()
        {
            return ResearchTopic;
        }

        public override string ToString()
        {
            return base.ToString() + $", Программа: {Program}, Тема исследования: {ResearchTopic}";
        }
    }
}
