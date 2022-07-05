// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольное целое число A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите произвольное целое число B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Exponentiation(a, b);
        }

        public static void Exponentiation(int x, int y)
        {
            int c = x;
            if (y > 0)
            {
                for (int i = 1; i < y; i++)
                {
                    c = c * x;
                }
                Console.WriteLine();
                Console.WriteLine($"Result: {x}, {y} -> {c}"); 
            }

            if (y == 0)
            {
                int d = 1;
                Console.WriteLine();
                Console.WriteLine($"Result: {x}, {y} -> {d}"); 
            } 
        }
        
    }
}



