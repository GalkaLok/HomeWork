// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

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

// Cоздаем функцию для суммы элементов на нечетных позициях
int OddSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

Console.Clear();
int[] array = GetArray(6, 0, 10);
Console.WriteLine(String.Join(", ", array)); // формируется строка из элементов массива

int sum = OddSum(array);
Console.WriteLine(sum);