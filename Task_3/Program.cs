namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 5 || num == 10) Console.WriteLine("Число либо равно 5 либо равно 10");
            else Console.WriteLine("Неивзвестное число");
        }
    }
}