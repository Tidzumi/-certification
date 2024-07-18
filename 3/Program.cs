Console.WriteLine("Input size of array");
int size = Convert.ToInt32(System.Console.ReadLine());

int[] myArray = CreateRandomArray(size);

PrintArray(myArray);
PrintArrayRevers(myArray, myArray.Length - 1);

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    Random random = new Random();
     for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 9 + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
            Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void PrintArrayRevers(int[] array, int index)
{
    if (index < 0)
    {
        return;
    }

        Console.Write(array[index] + " ");
        PrintArrayRevers(array, index - 1);
}

