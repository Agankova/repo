/* Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/ 
Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit (int number) 
{
    int digit2 = ((number/10)%10);
    return digit2;
}
int digit2 = SecondDigit (number);
Console.WriteLine ($"вторая цифра {digit2}");
