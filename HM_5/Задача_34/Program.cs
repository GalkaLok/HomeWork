//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// Cоздаем функцию 
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

Console.Clear();

int[] array = GetArray(5, 100, 999);

Console.WriteLine(String.Join(", ", array)); // формируется строка из элементов массива

int count = 0;

//стандартно через цикл for
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count ++;
    }
}

Console.WriteLine($"В массиве {count} четных чисел");