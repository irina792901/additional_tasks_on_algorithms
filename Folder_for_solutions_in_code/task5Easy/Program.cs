/*Введение в программирование(семинары)
Урок 3. Сравниваем разные алгоритмы решения задач.
Уровень EASY
Задача 5. С клавиатуры вводится массив из N целх чисел. 
Найти среднее арифметическое (СА) и среднее геометрическое
(СГ) среди всех элементов. Затем найти сумму элементов 
массива меньших СА, но больших СГ.
*/
using static System.Console;
int[] array = new int[10]; 
int size= array.Length;
int index = 0;
int sum = 0;
int mult = 1;
while (index < size)
{
    WriteLine("Введите целое число для наполнения массива ");
    array[index] = Convert.ToInt32(ReadLine());
    sum += array[index];
    mult*=array[index];
    index++;
}
int Sar = sum/size;
double Sgeo = mult,; // TO
index = 0;
int sumEl = 0;
while (index<size)
{
    if (array[index]>Sgeo && array[index]<Sar) sumEl+=array[index];
    index++;
} 
WriteLine(sumEl);
