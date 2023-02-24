/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
/* 
int A = Convert.ToInt32(Console.ReadLine()!);
int B = Convert.ToInt32(Console.ReadLine()!);

todegree(A, B);

void todegree(int _A, int _B)
{
    int result = 1;
    for (int i = 1; i <= _B; i++)
    {
        result = result * _A;
    }
    Console.WriteLine($"{_A}, {_B} -> {result}");
}
 */
 
/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
/* 
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
*/

/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */
/* 
Console.WriteLine($"Введите длину массива: ");
int lenArray = Convert.ToInt32(Console.ReadLine()!);

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write($"{randomArray[i]}, ");
}
 */