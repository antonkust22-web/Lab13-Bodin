// See https://aka.ms/new-console-template for more information
// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader()
// {
//     Console.WriteLine("^_^");
//     Console.WriteLine("Лабораторная работа №13");
//     Console.WriteLine("Дата формирования отчета 27.10.2026");
//     Console.WriteLine("0_0");
// }

// void PrintFooter()
// {
//     Console.WriteLine(">_<");
//     Console.WriteLine("     Конец программы");
//     Console.WriteLine("X_X");
// }

// void PrintStudentCard(string name, int age, string budget)
// {
//     Console.WriteLine($"Студент: {name}, возраст: {age}, Бюджет {budget}");
// }

// PrintStudentCard("Егор", 18, "da");
// PrintStudentCard("Валерия", 17, "net");


// double studentGrade = 4.7;
// double money = 2000;
// double bonus = 15;

// if (IsEligibleForBonus(studentGrade))
// {
//     double finalAmount = CalculateScholarship(money, bonus);
//     Console.WriteLine(finalAmount);
// }
// else
// {
//     double finalAmount = CalculateScholarship(money, 0);
//     Console.WriteLine(finalAmount);
// }

// bool IsEligibleForBonus(double averageGrade)
// {
//     if (averageGrade >= 4.5) { return true; }
//     else { return false; }
// }



// double CalculateScholarship(double baseAmount, double bonusPercent)
// {
//     return baseAmount + baseAmount * bonusPercent / 100;
// }

double CalculateAverageGrade(int[] grades)
{
    int sum = 0;
    foreach (int grade in grades)
    {
        sum += grade;
    }
    return (double)sum / grades.Length;
}
int CountFives(int[] grades)
{
    int count = 0;
    foreach (int grade in grades)
    {
        if (grade == 5)
        {
            count++;
        }
    }
    return count++;
}



int[] grades = { 4, 5, 3, 5, 4 };
int[] grades2 = { 4, 5, 3, 5, 4 };
double average2 = CountFives(grades2);
double average = CalculateAverageGrade(grades);
Console.WriteLine(average);
Console.WriteLine(average2);
