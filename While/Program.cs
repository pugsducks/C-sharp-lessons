namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 5;
            while (a < 10) // Если в скобках поставить false, не будет работать
            {               
                Console.WriteLine(a++);

            }
            do
            {
                Console.WriteLine(b++);
            } while (b < 5); // Выполнит хотяб 1 раз
        }      	

	}
    
}




/* Интересно можно ли при помощи While и if/else внутри него
 * Cделать пародию на обучение?
 */