namespace Четность_ДЗ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, number2;
            Console.WriteLine("Введите число");
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Четное");
            }
            else
            {
                Console.WriteLine("Не четное");
            }

        }
    }
}