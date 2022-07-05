// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольное целое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            string b = a.ToString();
            int c = SumNumbers(b);
            Console.WriteLine();
            Console.Write($"Result: {a} -> {c}");
        }  
        
        public static int SumNumbers(string n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum = sum + Convert.ToInt32(n[i].ToString());
            }
            return sum;
        }
    }
}




