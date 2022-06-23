void UserInput()
{
    System.Console.WriteLine("Введите b1");
    int b1 = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите k1");
    int k1 = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите b2");
    int b2 = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите b2");
    int k2 = Convert.ToInt32(Console.ReadLine());
    ThePointOfiIntersectionLogic(b1,k1,b2,k2);
}

void ThePointOfiIntersectionLogic(int b1, int k1, int b2, int k2)
{
    int x = (b2-b1)/(k1-k2);
    int y = (k2*x) + b2;
    System.Console.WriteLine($"Точка пересечения:X = {x} Y = {y}");
}
UserInput();