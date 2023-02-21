//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

int raiseToDegree(int a, int b)
{
    int raise = 1;
    for (int i = 0; i < b; i++)
    {
        raise *= a;
    }
    return raise;
}

bool ConfirmExp(int b)
{
    if (b < 0)
    {
        Console.Write("Показатель степени должен быть больше нуля");
        return false;
    }
    return true;
}

Console.Write("Введите основание: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine();

Console.Write("Введите показатель степени");
int b = int.Parse(Console.ReadLine()!);

if (ConfirmExp(b))
{
    Console.Write($"Число {a} в степени {b} равно {raiseToDegree(a, b)}");
}