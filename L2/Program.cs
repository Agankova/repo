/*Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/ 
Console.WriteLine("Введите число от 1-7, соответствующее дню недели:");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 6 || day == 7)
{
    Console.WriteLine("Ура, выходной!");
}
else if (day > 0 && day <= 5)
{
    Console.WriteLine("рабочий день");
}




