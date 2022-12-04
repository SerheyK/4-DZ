// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Не используя Math.Pow

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.WriteLine ("Введите число А");
string str1 = Console.ReadLine();
Console.WriteLine ("Введите число В");
string str2 = Console.ReadLine();
int A = int.Parse(str1);
int B = int.Parse(str2);
int x = 1;
for (int i = 1; i <= B; i++)
{
    x = x * A;
}
Console.WriteLine(x);