try
{
    Console.WriteLine("Введите первое целое число ");
    int x=Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine("Введите второе целое число ");
    int y=Convert.ToInt32 (Console.ReadLine());
    if (x>y)
        {
        Console.WriteLine("Большее число "+x);
        }
    else Console.WriteLine("Большее число "+y);
}
catch
{
Console.WriteLine("Необходимо ввести целое число цифрами");
}
