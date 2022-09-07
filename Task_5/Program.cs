namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Введите сумму вклада: ");
                double sum = Convert.ToDouble(Console.ReadLine());

                if (sum < 100)
                {
                sum += sum * 0.05;
                sum += 15;
                }
                else if (sum <= 200)
                {
                sum += sum * 0.07;
                sum += 15;
                }
                else
                {
                sum += sum * 0.1;
                sum += 15;
                }
                Console.WriteLine($"Сумму вклада после начисления процентов: {sum}");

                Console.ReadKey();
        }
    }
}

//Console.WriteLine("Введите сумму вклада: ");
//double sum = Convert.ToDouble(Console.ReadLine());
//double percent = 0;
//if (sum < 100)
//{
//    percent = 0.05;
//}
//else if (sum <= 200)
//{
//    percent = 0.07;
//}
//else
//{
//    percent = 0.1;
//}
//sum += sum * percent + 15;

//Console.WriteLine($"Сумму вклада после начисления процентов: {sum}");

//Console.ReadKey();