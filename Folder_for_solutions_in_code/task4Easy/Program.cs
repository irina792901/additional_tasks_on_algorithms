/*Введение в программирование(семинары)
Урок 3. Сравниваем разные алгоритмы решения задач.
Уровень EASY
Задача 4. С клавиатуры вводится массив из N целых чисел. 
Определить, есть ли в нем элементы, равные среднему 
арифметическому среди всех жлементов. 
Вывести на экран ответ: Да/Нет 
*/
using static System.Console;
int[] array = new int[10]; 
int size= array.Length;
int index = 0;
double sum = 0;
string answer = "Нет";
while (index < size)
{
    WriteLine("Введите целое число для наполнения массива ");
    array[index] = Convert.ToInt32(ReadLine());
    sum += array[index];
    index++;
}
double arg = sum/size;
index = 0;
while (index<size)
{
    if (array[index]==arg) answer = "Да";
    index++;
} 
WriteLine(answer);

