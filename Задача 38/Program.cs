/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/


void FillArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,100);
    }
}


void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

double GetMax (double[] arr)
{
    double maxNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (maxNumber < arr[i])
        maxNumber = arr[i];
    }
    return maxNumber;
}

double GetMin (double[] arr)
{
    double minNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
       if (minNumber > arr[i])
       minNumber = arr[i];
    }
    return minNumber;
}


double [] massiv = new double [5];
FillArray(massiv); 
PrintArray(massiv);

Console.WriteLine("Максимальный элемент массива :"+GetMax(massiv));
Console.WriteLine("Минимальный элемент массива :"+GetMin(massiv));
Console.WriteLine("Разница между максимальным и минимальным элементов массива :"+(GetMax(massiv)-GetMin(massiv)));



