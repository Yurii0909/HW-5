/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

//Инициализируем массив размером 4 

int size = 4;
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

// Счетчик массива +1 индекс, а также определение четных чисел, вывод количества чётных чисел

int countEvenNumbers = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0) countEvenNumbers ++;
}
Console.WriteLine(countEvenNumbers);

// Заполнения массива случайными трехзначными числами
void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

// Вывод массива на терминал 
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

//Инициализируем массив размером 4 
int size1 = 4;
int[] numbers1 = new int[size1];
FillArrayRandomNumbers1(numbers1);
PrintArray1(numbers1);

//Счетчик массива, +2 т.к не четные позиции массива (1,3), вывод суммы
int sumNumbersEvenIndex1 = 0;

for (int i = 1; i < numbers1.Length; i += 2)
{
    sumNumbersEvenIndex1 += numbers1[i];
}
Console.WriteLine(sumNumbersEvenIndex1);


// Функция заполнения массива случайными числами от -100 до 100
void FillArrayRandomNumbers1(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}

// Функция вывода массива в терминал
void PrintArray1(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76
*/

//Инициализируем массив размером 10 

int size2 = 10;
int[] numbers2 = new int[size2];
FillArrayRandomNumbers2(numbers2);
PrintArray2(numbers2);

//Присваевыем мин и макс индекс на начало массива, счетчик массива +1, вывод результата

int max = numbers2[0];
int min = numbers2[0];

for (int i = 0; i < numbers2.Length; i++)
{
    if (numbers2[i] > max)
    {
        max = numbers2[i];
    }
    else if (numbers2[i] < min)
    {
        min = numbers2[i];
    }
}

Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Минимальное число: {max}");
Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");

// Функция заполнения массива случайными числами от 1 до 777

void FillArrayRandomNumbers2(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 778);
    }
}

// Функция вывода массива в терминал
void PrintArray2(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}