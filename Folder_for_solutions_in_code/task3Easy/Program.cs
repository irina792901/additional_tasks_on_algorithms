/*Введение в программирование(семинары)
Урок 3. Сравниваем разные алгоритмы решения задач.
Уровень EASY
Задача 3. С клавиатуры вводится натуральное число N>5.
Вычислить величину А/G, где А - среднее арифметическое чисел
1,2...N;G - среднее геометрическоечисел 1,2..N
*/
using static System.Console;
Clear();
WriteLine("Введите натуральное число больше 5: ");
int N = Convert.ToInt32(ReadLine());
int n = 0;
int sum = 0;
int mult = 1;
while (n<N) 
{
    n++;
    sum +=n;
    mult*=n;
}
double A=sum/N;
double G = Math.Pow(mult, (double)1/N);
WriteLine($"{A},  {G:f2},  {A/G:f2}");