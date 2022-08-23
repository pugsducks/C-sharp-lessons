namespace Калькулятор_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            Console.Clear();

            Console.WriteLine("Введите 1-ое число");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите операцию");
            string operation = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Введите 2-ое число");
            int b = Convert.ToInt32(Console.ReadLine());
            bool b2 = b == 0;

            if (operation == "+")                       
                    Console.WriteLine("Результат " + (a + b));
            else if (operation == "-")
                    Console.WriteLine("Результат " + (a - b));
            else if (operation == "*")  
                    Console.WriteLine("Результат " + (a * b));
            else if (operation == "/")
            {
                if (b2)
                    Console.WriteLine("Ошибка!");
                else
                    Console.WriteLine("Результат " + (a / b));
            }                                                               
            else
                

                    Console.WriteLine("Ошибка! <" + operation + "> не является операцией");
             Console.ReadLine();
            }           
        }
    }
}