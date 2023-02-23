// Показать кубы чисел, заканчивающихся на четную цифру

int[] numbers = new int[]{2,15,3,4,77,38};
 
for (int i = 0; i < numbers.Length; i++)
{
     int number = numbers[i];
     int cube = (int)Math.Pow(number, 3);
     if (cube % 2 == 0)
        Console.WriteLine($"Куб числа {number} равен {cube} и заканчивается на чётную цифру");

}
