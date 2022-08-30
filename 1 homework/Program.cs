int num = int.Parse(Console.ReadLine());



if (num > 9999)
{
    if (num < 99999) 
    {
        int a, b, c, d, e;
        a = num / 10000;
        b = num / 1000 % 10;
        c = num / 100 % 10;
        d = num / 10 % 10;
        e = num % 10;
            if (a == e && b == d) 
            {
                Console.Write("палиндромом");
            }
            else 
            {
                Console.Write("не является палиндромом");
            }
    }
    else 
    {
        Console.Write("неверное число");
    }
}
else 
{
    Console.Write("неверное число");
}