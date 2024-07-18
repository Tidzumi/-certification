// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void Numbers(int M, int N)
{
    if (M > N)
    {
            return;
    }
    Console.WriteLine(M);
    Numbers(M + 1, N);
}

Console.Write("Input M: ");
int M = Convert.ToInt32(Console.ReadLine());
        
 Console.Write("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());
        
Numbers(M, N);