﻿// Задача 26: Возведите число А в натуральную степень B, используя цикл.
Console.WriteLine("Введите число и степень в которую его необходимо вознести, через ENTER");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
for(int i=1;i<=b;i++)
            {
                result *= a;
            }
Console.Write("Ответ: ");
Console.WriteLine(result);