/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int number = Convert.ToInt32(Console.ReadLine()!);
int lenghth = NumberLen(number); 

SumNumbers(number, lenghth);

int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int n, int lenghth)
{
    int sum = 0;
    for (int i = 1; i <= lenghth; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"{number} -> {sum}");
}

