// Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
int GetUserValue(string message)
{
     Console.WriteLine ("Введите n:");
     int result = int.Parse(Console.ReadLine()!);
     return result;
}
void cube(int n)
{
    for (int i = 1; i < n + 1; i = i + 1)
    {
        int temp = i * i * i;
        if (i < n)
        {Console.Write ($" {temp},");}
        else
        {Console.Write ($" {temp}");}
    }
}
int n = GetUserValue("Введите n: ");
cube(n);