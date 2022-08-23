namespace _7._For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int limit = int.Parse(Console.ReadLine());
            //for (int i = 0; i < limit; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (; ; )
            //{
            //    Console.WriteLine("Работает");
            //    System.Threading.Thread.Sleep(300);
            //    break;
            //}

            {
                Console.Clear();
                int i = 0;
                for (;i < 3;i++)
                {
                    Console.WriteLine(i + " 1");                                       
                }
                for (;i < 6;i++)
                {
                    Console.WriteLine(i + " 2");
                }
                Console.ReadLine();
            }

            int limit = int.Parse(Console.ReadLine());
            for (int i = 0,j = 5; i < limit; i++,j++)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("j: " + j);
            }

        }
    }
}