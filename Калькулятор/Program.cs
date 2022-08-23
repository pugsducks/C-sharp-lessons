namespace Калькулятор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1-ое число");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите операцию");
            string operation = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Введите 2-ое число");
            int b = Convert.ToInt32(Console.ReadLine());
            bool b2 = b == 0;

            switch (operation)
            {
                case "+":
                    Console.WriteLine("Результат " + (a + b));
                    break;
                case "-":
                    Console.WriteLine("Результат " + (a - b));
                    break;
                case "*":
                    Console.WriteLine("Результат " + (a * b));
                    break;
                case "/":
                    if (b2)                  
                        Console.WriteLine("Ошибка!");                    
                    else                    

                        Console.WriteLine("Результат " + (a / b));                               
                    break;
                    default:
                    Console.WriteLine("Ошибка! <" + operation + "> не является операцией");
                    break;
            }
            }


        }
}