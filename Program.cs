/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

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
