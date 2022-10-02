/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10,10);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int FindOddIndex(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    
        if (i % 2 == 1)
        sum += arr[i];
        
    }
    return sum;
}





int [] massiv = new int [4];
FillArray(massiv); 
PrintArray(massiv);

Console.WriteLine("Сумма элементов, стоящих на нечётных позициях массива : "+FindOddIndex(massiv));


/*nt FindOddIndex(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
    
        sum += arr[i];
        
    }
    return sum;
}*/
