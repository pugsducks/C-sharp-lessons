namespace lessons

{ internal class Program
    {
        static void Main(string[] args)
        {

            // Команда WriteLine;
            Console.WriteLine("Bebrick");

            Console.WriteLine("Dima loh");

            /* Объявление переменной
            * Инициализация переменной
            */

            int a;
            a = 109;

            Console.WriteLine(a);

            int b = 10;

            Console.WriteLine(b);

            int c, d;
            c = 2;
            d = 5;
            Console.WriteLine(c);
            Console.WriteLine(d);

            bool Droos = true;
            Console.WriteLine(Droos);

            char e = '#';
            Console.WriteLine(e);

            int f = 1;
            Console.WriteLine(f);

            f = 6;
            Console.WriteLine(f);

            // Ввод двнных в консоль

            string data;

            data = Console.ReadLine();
            Console.WriteLine("Привет, " + data + ", как дела?");

            // Конвертация данных

            string str = "3";
            string str2 = "12";

            Console.WriteLine(str + str2);

            int t = 3;
            int t2 = 7;

            Console.WriteLine(t + t2);

            int k = Convert.ToInt32(str);
            Console.WriteLine(k);

            string stri = "1,2";
            double stri2 = Convert.ToDouble(stri);
            Console.WriteLine(k + stri2);

            // Конвертация с помощью parse и tryparse

            string cha = "43";
            int cha2 = int.Parse(cha);

            string cha3 = "4,3";
            try
            {
                double cha4 = double.Parse(cha3);
                Console.WriteLine(cha4 + "\nУспешно");
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка конвертации");
            }

            Console.WriteLine("Проба конвертации данных\nВведите число");

            string tr = Console.ReadLine();
            int l;
            bool result = int.TryParse(tr, out l);
            if (result)
            {
                Console.WriteLine("Успешная конвертация \n" + l);
            }
            else
            {
                Console.WriteLine("Конвертация не удалась");
            }

            //Операторы и арифметические операции.

            int num1 = 184;
            int num2 = 109;
            int num3 = 9;

            double numbers = (double)num1 / num2;

            Console.WriteLine(numbers);

            double numbers2 = num1 % num2 + num3;


            Console.WriteLine(numbers2);

            // Приоритет

            int prior1 = 2 + 2 * 2;
            int prior2 = (2 + 2) * 2;
            Console.WriteLine(prior1);
            Console.WriteLine(prior2);

            // Инкримент и Дикримент

            int a1 = 0;
            a1++;
            int a2 = 10;
            a2--;
            Console.WriteLine(a1);
            Console.WriteLine(a2);

            // Постфикс и Префикс

            int grom = 0;

            Console.WriteLine(grom++);
            Console.WriteLine(++grom);

            Console.WriteLine(grom--);
            Console.WriteLine(--grom);

            int grom1 = 1;

            grom1 = ++grom1 * grom1;
            Console.WriteLine(grom1);


            /* Операторы отношений и операторы сравнений
             * == Равно
             * != Не равно
             * < Меньше
             * > Больше
             * <= Меньше или равно
             * >= Больше или равно
            */

            int d1 = 5;
            int d2 = 3;
            bool d3 = d1 > d2;
            Console.WriteLine(d1 == d2);
            Console.WriteLine(d3);

            /* if (утверждение или выражение)
             * {
             *  действие 1
             * }
             * else
             * {
             *  действие 2
             * }
             */

            bool infected = true;
            if (infected)
            {
                Console.WriteLine("Заражение");
            }
            else
            {
                Console.WriteLine("Здоров");
            }

            /* Логические операторы
             * && Сокращенное И
             * || Сокращенное ИЛИ
             * & И
             * | ИЛИ
             * ! НЕ (унарный)
             */

            bool infected2 = false;
            if (!infected2)
            {
                Console.WriteLine("Заражен");
            }

            bool over = true;
            bool tm = true;
            if (over && tm)
            {
                Console.WriteLine("Перегрет");
            }

            int fanspeed = 3000;
            bool over2 = false;
            bool tm2 = fanspeed <= 0;
            if (over2 || tm2)
            {
                Console.WriteLine("Нагрет");
            }

            // Условный оператор switch

            int SW = int.Parse(Console.ReadLine());
            switch (SW)
            {
                case 1:
                    Console.WriteLine("Вы ввели цмфру 1");
                    break;
                case 2:
                    Console.WriteLine("Вы ввели цмфру 2");
                    break;
                default:
                    Console.WriteLine("Не известное число");
                    break;

            }
            // Аналогичная запись, но более развитое простарнство.
            string lm = Console.ReadLine();
            int m;            
            switch (int.TryParse(lm, out m))
            {
                case true:
                    Console.WriteLine("Вы ввели цмфру " + lm);
                    break;
                case false:
                    Console.WriteLine("Число не определенно");
                    break;

            /* Кейсы можно объеденить, убрав ключевое слово "break"
             * Пример:
             * switch (...)
             *{
             *case 1:
             *case 2:
             *................
             *break;
             *}
             */
            

                    //Продолжение в других проектах


            }


            }
        }
}
