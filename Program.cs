using LAB07;

Student[] students =
{
    new BachelorStudent("Даник", 18, 1, "Бюджет", 9.5, 0, 0, "СДП-ЭлЭ-261", "Программирование"),
    new BachelorStudent("Настя", 19, 2, "Платная", 8.2, 0, 4000, "СДП-ЭлЭ-251", "Экономика"),
    new BachelorStudent("Юля", 21, 3, "Бюджет", 7.5, 0, 0, "СДП-ЭлЭ-241", "Маркетинг"),
    new BachelorStudent("Денис", 22, 4, "Платная", 6.5, 0, 3500, "СДП-ЭлЭ-231", "Программирование"),
    new MasterStudent("Рома", 23, 1, "Бюджет", 9.8, 0, 0, "Разработка ПО", "Искусственный интеллект"),
    new MasterStudent("Макар", 24, 2, "Платная", 7.0, 0, 2500, "Информационные системы", "Базы данных"),
    new MasterStudent("Вика", 23, 1, "Бюджет", 7.7, 0, 0, "Кибербезопасность", "Защита данных"),
    new PhDStudent("Милана", 26, 1, "Бюджет", 9.9, 0, 0, "Сидорова И.И.", "Нейронные сети"),
    new PhDStudent("Максим", 27, 2, "Платная", 8.6, 0, 3000, "Платонов С.И.", "Компьютерные сети"),
    new PhDStudent("Виолетта", 25, 3, "Бюджет", 9.4, 0, 0, "Романов И.В.", "Машиное обучение")
};

foreach (Student student in students)
{
    Console.WriteLine(student);
}
Console.WriteLine();

foreach (Student student in students)
{
    student.TransferToNextCourse();
}
Console.WriteLine();

foreach (Student student in students) 
{
    student.RecalculatePayments();

if (student.StudyForm == "Бюджет")
{
    Console.WriteLine($"{student.Name} получает стипендию: {student.Scholarship}BYN.");
}
else
{
    Console.WriteLine($"{student.Name} учится на платном. Стоимость обучения после скидки: {student.TuitionFee}BYN.");
}
}
Console.WriteLine();

students[1].PayTuition(1000);
students[3].PayTuition(1500);
students[5].PayTuition(2000);
students[8].PayTuition(2500);
students[2].PayTuition(1000);



decimal totalPayment = 0;                                            
foreach (Student student in students)
{
    totalPayment += student.GetRemainingPayment();
}
Console.WriteLine($"Общий остаток оплаты: {totalPayment}BYN.");
Console.WriteLine();


Student bestStudent = students[0];
foreach (Student student in students)
{
    if (student.AverageGrade > bestStudent.AverageGrade)
    {
        bestStudent = student;
    }
}
Console.WriteLine($"Обучающийся с максимальным средним баллом: {bestStudent}");
Console.WriteLine();


foreach (Student student in students)
{
    if (student is PhDStudent phd)
    {
        phd.PublishResearch();
        Console.WriteLine();
    }
}

