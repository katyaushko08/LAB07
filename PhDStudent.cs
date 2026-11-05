using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace LAB07
{
    public class PhDStudent : Student
    {
        public string ScientificSupervisor {  get; set; }
        public string ResearchArea { get; set; }

        public PhDStudent(
            string name,
            int age,
            int course,
            string studyForm,
            double averageGrade,
            decimal scholarship,
            decimal tuitionFee,
            string scientificSupervisor,
            string researchArea
            ) : base(name, age, course, studyForm, averageGrade, scholarship, tuitionFee)
        {
            ScientificSupervisor = scientificSupervisor;
            ResearchArea = researchArea;
        }

        public override void RecalculatePayments()
        {
            base.RecalculatePayments();
            if (StudyForm == "Бюджет")
            {
                if (AverageGrade >= 8.0)
                {
                    Scholarship = 350m;
                }
                else if (AverageGrade >= 6.0)
                {
                    Scholarship = 200m;
                }
                else
                {
                    Scholarship = 0m;
                }
            }
        }

        public override void TransferToNextCourse()
        {
            if (Course < 4)
            {
                Course++;
                Console.WriteLine($"{Name} переведен(a) на {Course} курс. ");
            }
            else
            {
                Console.WriteLine($"{Name} закончил(a) аспирантуру. ");
            }
        }

        public void PublishResearch()
        {
            Console.WriteLine($"{Name} опубликовал(a) научную работу.");
            Console.WriteLine($"Область исследования: {ResearchArea}");
        }

        public override string ToString()
        {
            return base.ToString() + $", Научный руководитель: {ScientificSupervisor}, Область исследования: {ResearchArea}";
        }
    }
}
