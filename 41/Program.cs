/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/


Console.WriteLine("Сколько чисел будет введено?");
int s = int.Parse(Console.ReadLine()!);
int count =0;

for (int i = 0; i < s; i++)
{
    Console.WriteLine($"Введите {i+1} число");
    int a = int.Parse(Console.ReadLine()!);
    if (a > 0) count++;
}
Console.WriteLine($"Чисел больше 0 => {count}");