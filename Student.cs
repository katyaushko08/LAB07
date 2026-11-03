using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Course { get; set; }
        public string StudyForm { get; set; }
        public double AverageGrade { get; set; }
        public double Scholarship { get; set; }
        public double TuitionFee { get; set; }

        public Student(string name, int age, int course, string studyForm, double averageGrade, double scholarship, double tuitionFee)
        {
            Name = name;
            Age = age;
            Course = course;
            StudyForm = studyForm;
            AverageGrade = averageGrade;
            Scholarship = scholarship;
            TuitionFee = tuitionFee;

            RecalculatePayments();
        }
        public virtual void RecalculatePayments()
        {

        }
    }
}
