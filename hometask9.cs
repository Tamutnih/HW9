// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1

// Console.Clear();
// int n = InputInt("Введите число n: ");
// int m = 1;
// if (n < 1)
// {
//     Console.WriteLine("Ввели не положительное число");
// }
// Console.WriteLine(NaturalNumber(n, m));

// int NaturalNumber(int n, int m)
// {
//     if (n == m)
//         return n;
//     else
//         Console.Write($"{NaturalNumber(n, m + 1)}, ");
//     return m;
// }

// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.Clear();
// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");
// int temp = m;

// if (m > n)
// {
//     m = n;
//     n = temp;
// }

// PrintSumm(m, n, temp = 0);

// void PrintSumm(int m, int n, int summ)
// {
//     summ = summ + n;
//     if (n <= m)
//     {
//         Console.Write($"Сумма элементов= {summ} ");
//         return;
//     }
//     PrintSumm(m, n - 1, summ);
// }

// int InputNumbers(string input)
// {
//     Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = Ack(m, n);

Console.WriteLine($"A({m}, {n}) = {Ack(m, n)}");

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

