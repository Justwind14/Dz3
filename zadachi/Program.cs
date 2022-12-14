void Task19()
{
    int CheckNumber()
    {
        while (true)
        {
            Console.Write("Ведите пятизначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 9999 && number < 100000)
                return number;
        }
    }
    int num = CheckNumber();
    string chars = num.ToString();
    if (chars[0] == chars[4] && chars[1] == chars[3])
    {
        Console.Write("Число является палиндромом");
    }
    else
    {
        Console.Write("Число не является палиндромом");
    }
}

void Task21()
{
    Console.WriteLine("Введите точку A");
    Console.Write("введите координату 1: ");
    int ax = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите координату 2: ");
    int ay = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите координату 3: ");
    int az = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите точку B");
    Console.Write("введите координату 1: ");
    int bx = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите координату 2: ");
    int by = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите координату 3: ");
    int bz = Convert.ToInt32(Console.ReadLine());

    double dist = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
    Console.Write("Расстояние между точками: ");
    Console.Write(dist.ToString("#.00"));

}
void Task23()
{
    Console.Clear();
    Console.WriteLine("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n < 1)
    {
        Console.Write("Не корректно введено число, введите число больше 0");
    }
    else
    {
        Console.Write(n + " -> ");
    }
    TablCalc(n);
}
void TablCalc(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write(Math.Pow(i, 3));
        if (i != n)
            Console.Write(", ");
    }
}

Task19(); // Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Task21(); // Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Task23(); // Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.