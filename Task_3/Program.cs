// Задача 29: Напишите программу, которая задаёт случайный массив случайного размера (от 5 до 10) 
// элементов (значение элементов от -15 до 15) и выводит на экран массив квадратов этих чисел.

// 1, 2, 5, 7, 19 -> [2, 4, 25, 49, 361]
// 6, 1, 33 -> [36, 1, 1089]
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = new Random().Next(5, 11);
            int[] array = new int[a];
            arrayRandomSquare(array);
            PrintArray(array);
        }  
        
        public static void arrayRandomSquare(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(-15, 16);
                arr[i] = arr[i] * arr[i];
            }
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}





