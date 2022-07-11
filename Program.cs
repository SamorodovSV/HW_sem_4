// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.Clear();
//         Console.WriteLine("Введите число, которое нужно возвести в степень:");
//         int A = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Введите степень:");
//         int B = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine(A + " ^ " + B + " = " + Math.Pow(A, B));
//     }
// }

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.Clear();
//         Console.WriteLine("Введите число, которое нужно возвести в степень:");
//         int A = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Введите степень:");
//         int B = Convert.ToInt32(Console.ReadLine());
//         int i = 1;
//         int C = A;
//         while (i < B)
//         {
//             C = C * A;
//             i++;
//         }
//         Console.WriteLine(A + ", " + B + "-> " + C);
//     }
// }



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         void SumDigitsInNumber(int number)
//         {
//             if (number < 0)
//             {
//                 number = number * -1;
//             }
//             else if (number < 10)
//             {
//                 Console.Write(number + " -> " + number);
//             }
//             else if (number >= 10 & number < 100)
//             {
//                 int a1 = number % 10;
//                 int a2 = number / 10;
//                 int sum = a1 + a2;
//                 Console.Write(number + " -> " + sum);
//             }
//             else if (number >= 100 & number < 1000)
//             {
//                 int a1 = number % 10;
//                 int a2 = number / 10 % 10;
//                 int a3 = number / 100 % 10;
//                 int sum = a1 + a2 + a3;
//                 Console.Write(number + " -> " + sum);
//             }
//             else if (number >= 1000 & number < 10000)
//             {
//                 int a1 = number % 10;
//                 int a2 = number / 10 % 10;
//                 int a3 = number / 100 % 10;
//                 int a4 = number / 1000 % 10;
//                 int sum = a1 + a2 + a3 + a4;
//                 Console.Write(number + " -> " + sum);
//             }
//             else
//             {
//                 Console.Write(number + "-> " + "Введено много символов. Введите число < 10000 ");
//             }
//         }
//         Console.Clear();
//         Console.Write("Введите число:");
//         int num = Convert.ToInt32(Console.ReadLine());
//         SumDigitsInNumber(num);
//     }
// }



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         int[] RandomArray()
//         {
//             int[] Array = new int[8];
//             for (int i = 0; i < 8; i++)
//             {
//                 Array[i] = new Random().Next(1, 1000 + 1);
//             }
//             return Array;
//         }

//         void PrintArray(int[] array)
//         {
//             for (int i = 0; i < array.Length; i++)
//             {
//                 Console.Write(array[i] + ", ");
//             }
//             Console.WriteLine();
//         }
//         Console.Clear();
//         Console.WriteLine("Массив из 8 случайных элементов:");
//         int[] NewArray = RandomArray();
//         PrintArray(NewArray); 
//     }
// }
