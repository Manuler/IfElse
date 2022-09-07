namespace Task_1
{
    internal class Program
    {
        static void Compare(int x, int y)
        {
            if (x == y) Console.WriteLine($"{x} равен {y}");
            else if (x > y) Console.WriteLine($"{x} больше {y}");
            else if (x < y) Console.WriteLine($"{y} больше {x}");  
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int num_0 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int num_1 = Convert.ToInt32(Console.ReadLine());
            Compare (num_0, num_1);

        } 
        
    }
}