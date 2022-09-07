namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада: ");
            double deposit = Convert.ToDouble(Console.ReadLine());
            if (deposit < 100) Console.WriteLine($"Сумма с процентами равна {deposit + deposit * 0,05}");
            else if (deposit >= 100 && deposit <= 200) Console.WriteLine($"Сумма с процентами равна {deposit + deposit * 0,07}");
            else Console.WriteLine($"Сумма с процентами равна {deposit + deposit * 0,1}");
        }
    }
}

//static void Main(string[] args)
//{
//    Console.WriteLine("Введите сумму вклада: ");
//    double sum = Convert.ToDouble(Console.ReadLine());

//    if (sum < 100)
//    {
//        sum += sum * 0.05;
//    }
//    else if (sum <= 200)
//    {
//        sum += sum * 0.07;
//    }
//    else
//    {
//        sum += sum * 0.1;
//    }
//    Console.WriteLine($"Сумму вклада после начисления процентов: {sum}");

//    Console.ReadKey();
//}