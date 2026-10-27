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

void PrintStudentCard(string name, int age, string budget)
{
    Console.WriteLine($"Студент: {name}, возраст: {age}, Бюджет {budget}");
}

PrintStudentCard("Егор", 18, "da");
PrintStudentCard("Валерия", 17, "net");
