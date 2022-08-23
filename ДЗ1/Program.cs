namespace ДЗ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Среднее арифметическое чисел");
            Console.WriteLine("Введите 1-ое число");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите 2-ое число");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Результат: \n" + (double) (num1 + num2) / 2);

            int num3, num4, num5, sym, prois;
            Console.WriteLine("Сумма и Произведение");
            Console.WriteLine("Введите 1-ое число");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите 2-ое число");
            num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите 3-ее число");
            num5 = Convert.ToInt32(Console.ReadLine());

            sym = num3 + num4 + num5;
            prois = num3 * num4 * num5;

            Console.WriteLine("Сумма: \n" + sym + "\nПроизведение: \n" + prois);


            double euro, num6;
            Console.WriteLine("Конвертер евро\nВведите колличество денег в рублях:");
            /*
             * string euros = "0,016";
               double euro = Convert.ToDouble(euros);
             */
            euro = 0.016;
            num6 = double.Parse(Console.ReadLine()) * euro;

            Console.WriteLine("Вы имеете " + num6 + " Евро");
        }
    }
}