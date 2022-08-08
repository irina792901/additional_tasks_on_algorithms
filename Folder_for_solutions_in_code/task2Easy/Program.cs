/*Введение в программирование(семинары)
Урок 3. Сравниваем разные алгоритмы решения задач.
Уровень EASY
Задача 2. С клавиатуры вводится натуральное число N. 
Выведите на экран количетсво делителей числа N и их сумму
*/
using static System.Console;
Clear();
WriteLine("Введите натуральное число: ");
int N = Convert.ToInt32(ReadLine());
int del = 2;
int count = 0;
int sum = 0;
while (del<=N/2) 
{
    if (N % del == 0) 
    {
        count++;
        sum+=del;
    }
    del++;
}
WriteLine($"Количество делителей = {count}\nСумма делителей = {sum}");