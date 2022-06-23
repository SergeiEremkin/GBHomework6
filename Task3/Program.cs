int[] CheckCountOfNumbers(int number)
{
    int length = 0;
    while (number != 0)
    {
        number = number / 2;
        length++;
    }
    return new int[length];
}

int[] CreateBinaryNumber(int number)
{
    int[] array = CheckCountOfNumbers(number);

    for (int i = 0; i < array.Length; i++)
    {

        array[array.Length - 1 - i] = number % 2;
        number = number / 2;

    }
    return array;
}

void ShowArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");

    }
    System.Console.WriteLine();
}

int[] array = CreateBinaryNumber(10);
ShowArray(array);
int[] array2 = CreateBinaryNumber(2);
ShowArray(array2);
int[] array3 = CreateBinaryNumber(34);
ShowArray(array3);
