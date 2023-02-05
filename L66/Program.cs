/* Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120*/ 

int getUserMsg(string message)
{
    Console.WriteLine(message);
    int messege = int.Parse(Console.ReadLine()!);
    return messege;
}
int getSumNumbers (int M, int N)

{
    if (N == 1)
    { 
        return M;
    }
    return N + getSumNumbers(M, N - 1);
}

int M = getUserMsg ("Введите число M ");
int N = getUserMsg ("Введите число N ");

int result = getSumNumbers (M, N);
Console.WriteLine (result);