namespace Task_6_7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool exitCommand = false;
            while (!exitCommand)
            {
                Console.WriteLine("Choose operation");
                Console.WriteLine("1.Addition 2.Subtraction 3.Multiplication 4.Division 5.Exit");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num <= 0 && num > 5)
                {
                    Console.WriteLine("Wrong choice");
                    exitCommand = true;
                }
                else if (num == 5)
                    exitCommand = true;
                else
                {
                    Console.WriteLine("Введите первое число: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine($"{x} + {y} = {x + y}");
                            break;

                        case 2:
                            Console.WriteLine($"{x} - {y} = {x - y}");
                            break;

                        case 3:
                            Console.WriteLine($"{x} * {y} = {x * y}");
                            break;

                        case 4:
                            Console.WriteLine($"{x} / {y} = {x / y}");
                            break;
                    }
                }
            }
        }
    }
}