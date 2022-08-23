namespace _6._4_ДЗ_Сумм_Чет_и_Не_чет_и_тд_
{
    internal class Program
    {                                                   // Программа которая будет подсчитывать сумму и кол-во чет и не чет чисел в заданном диапазоне
        static void Main(string[] args)
        {            
            int chet = 0;
            int sumchet = 0;
            int nechet = 0;
            int sumnechet = 0;
            Console.WriteLine("Начало диапазона:");
            int st = int.Parse(Console.ReadLine());
            Console.WriteLine("Конец диапазона:");
            int fin = int.Parse(Console.ReadLine());            
            while (st <= fin)
            {
                if (st % 2 == 0)
                {
                    sumchet = sumchet + st;
                    chet++;
                }
                else
                {
                    sumnechet = sumnechet + st;
                    nechet++;
                }
                st++;                
            }
            Console.WriteLine(chet + " - Колличесвто четных");
            Console.WriteLine(nechet + " - Колличесвто нечетных");
            Console.WriteLine(sumchet + " - Сумма четных");
            Console.WriteLine(sumnechet + " - Сцмма нечетных");
        }
    }
}