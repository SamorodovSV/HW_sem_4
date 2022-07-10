// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число, которое нужно возвести в степень:");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень:");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(A +" ^ " + B + " = " + Math.Pow(A, B));




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// void SumDigitsInNumber ( int number){ 
// while (number < 0)
// {
//     number = number * -1;
// }
// if (number < 10)
// {
//     Console.Write( number + " -> "+ number);
// }
// else if (number >= 10 & number < 100)
// {
//     int a1 = number % 10;
//     int a2 = number / 10;
//     int sum = a1 + a2;
//     Console.Write( number + " -> "+ sum);
// }
// else if (number >= 100 & number < 1000)
// {
//     int a1 = number % 10;
//     int a2 = number / 10 % 10;
//     int a3 = number /100 % 10;
//     int sum = a1 + a2 + a3;
//     Console.Write( number + " -> "+ sum);
// }
// else if (number >= 1000 & number < 10000)
// {
//     int a1 = number % 10;
//     int a2 = number / 10 % 10;
//     int a3 = number /100 % 10;
//     int a4 = number /1000 % 10;
//     int sum = a1 + a2 + a3 + a4;
//     Console.Write( number + " -> "+ sum);
// }
// else
// {
//     Console.Write( number + "-> "+ "Введено много символов. Введите число < 10000 ");
// }
// }
// Console.Write("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// SumDigitsInNumber(num);

