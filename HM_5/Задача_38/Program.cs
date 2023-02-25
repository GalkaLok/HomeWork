//  Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// Cоздаем функцию 
double[] GetDoubleArray(int size, double minValue, double maxValue)
{
    double[] result = new double[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 2);
    }

    return result;
}

// Cоздаем функцию 
double Difference(double[] inArray)
{
    double max = inArray[0];
    double min = inArray[0];
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] > max)
        {
            max = inArray[i];
        }
        else if (inArray[i] < min)
        {
            min = inArray[i];
        }
    }
    double diff = max - min;
    return diff;
}

Console.Clear();
double[] array = GetDoubleArray(6, 0, 10);
Console.WriteLine(String.Join(", ", array)); // формируется строка из элементов массива

double diff = Difference(array);
Console.WriteLine($"Разница между максимальным и минималным элементами = {diff}");