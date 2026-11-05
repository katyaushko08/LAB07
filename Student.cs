using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Course { get; set; }
        public string StudyForm { get; set; }
        public double AverageGrade { get; set; }
        public decimal Scholarship { get; set; }
        public decimal TuitionFee { get; set; }
        public decimal BaseTuitionFee { get; set; }

        public Student(string name, int age, int course, string studyForm, double averageGrade, decimal scholarship, decimal tuitionFee)
        {
            Name = name;
            Age = age;
            Course = course;
            StudyForm = studyForm;
            AverageGrade = averageGrade;
            Scholarship = scholarship;
            TuitionFee = tuitionFee;
            BaseTuitionFee = tuitionFee;

            RecalculatePayments();
        }
        public virtual void RecalculatePayments()
        {
            if (StudyForm == "Бюджет")
            {
                if (AverageGrade >= 8.0)
                {
                    Scholarship = 200m;
                }
                else if(AverageGrade >= 6.0)
                {
                    Scholarship = 150m;
                }
                else
                {
                    Scholarship = 0m;
                }
                TuitionFee = 0m;
            }
            else
            {
                Scholarship = 0;
                if (AverageGrade >= 9.0)
                {
                    TuitionFee = BaseTuitionFee * 0.8m;
                }
                else if (AverageGrade >= 8.0)
                {
                    TuitionFee = BaseTuitionFee * 0.9m;
                }
                else
                {
                    TuitionFee = BaseTuitionFee; 
                }
            }
        }
        public virtual void PayTuition(decimal amount)
        {
            if(StudyForm == "Платная")
            {
                TuitionFee -= amount;         //Остаток  - внесенная сумма
                if (TuitionFee < 0)
                {
                    TuitionFee = 0;
                }
                Console.WriteLine($"{Name} оплатил {amount}BYN Остаток: {TuitionFee} руб.");
            }
            else
            {
                Console.WriteLine($"{Name} учится на бюджете, оплата не требуется.");
            }
        }
        public virtual void TransferToNextCourse()
        {
            Course++;
        }

        public virtual decimal GetRemainingPayment()   //Остаток оплаты
        {
            return TuitionFee;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {Name}, Возраст: {Age}, Курс: {Course}, Форма: {StudyForm}, " +
                   $"Ср.балл: {AverageGrade}, Стипендия: {Scholarship}, Остаток оплаты: {GetRemainingPayment()}";
        }

    }
}
