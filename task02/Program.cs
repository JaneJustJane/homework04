// Написать программу копирования массива
void PrintArray (int [] arr)
{
    for (int x=0; x<arr.Length; x++)
    {
        Console.Write($"{arr[x]} ");
    }
}

int [] array = new int [9]{1,4,5,6,2,4,0,3,6};
Console.WriteLine($"Заданный массив:");
PrintArray(array);
Console.WriteLine();
int [] array1 = new int [9];
int j=0; 

for (int i=0; i<array.Length; i++)
{
        array1[j]=array[i];
        j++;
}
Console.WriteLine($"Копия заданного массива:");
PrintArray(array1); 