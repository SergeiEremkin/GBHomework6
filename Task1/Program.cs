void CountPositivNumbers()
{
    int[] array = UserInputInterface();
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            counter++;
        }
    }
    System.Console.WriteLine($"Кол-во положительных чисел: {counter}");
}
int[] UserInputInterface()
{
    System.Console.WriteLine("Сколько чисел хотите ввести?");
    int M = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[M];
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine("Введите число:");
        int Number = Convert.ToInt32(Console.ReadLine());
        arr[i] = Number;
    }
    return arr;
}
CountPositivNumbers();
