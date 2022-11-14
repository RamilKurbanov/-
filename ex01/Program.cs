// Задайте массив из 12 элементов, заполненный случайными числами из промежутка 

int [] GetArray (int size, int minValue, int maxValue)
{
    int[] res = new int [size];
    
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }

    return res;
}

void countNumbers(int[] array)
{
    int positiveSum = 0;
    int negativeSum = 0;
    

    foreach (int el in array)
    {
    positiveSum += el > 0 ? el : 0;
    negativeSum += el < 0 ? el : 0;
    }

    Console.WriteLine($"Cумма положительных элементов: {positiveSum}");
    Console.WriteLine($"Cумма отрицательных элементов: {negativeSum}");
}
 
 int[] array = GetArray (20, -99, 99);
 Console.WriteLine(string.Join(" ", array));
 countNumbers(array);