using System;

class Program
{
    public static int Main()
    {
        /*переменная, которой потом присвоим значение этой суммы, 
        должна сразу быть инициализирована нулем*/
        double res = 0;
        for (; ; )
        {
            Console.Write("Введите число, для вывода суммы этих чисел введите 0 : ");
            double num = double.Parse(Console.ReadLine());
            if (num == 0)
            {
                break;
            }
            res += num;
        }
        Console.WriteLine("\nСумма : {0}", res);
        Console.ReadKey();
        return 0;
    }
}